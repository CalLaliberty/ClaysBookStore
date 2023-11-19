using ClaysBooks.Models;
using Microsoft.AspNetCore.Mvc;
using ClaysBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaysBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)    // action method for Upsert
        {
            CoverType covertype = new CoverType();
            if (id == null)
            {
                // this is for create 
                return View(covertype);
            }
            // this for the edit
            covertype = _unitOfWork.CoverType.Get(id.GetValueOrDefault());
            if (covertype == null)
            {
                return NotFound();
            }
            return View(covertype);
        }

        // use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(CoverType covertype)
        {
            if (ModelState.IsValid)  // checks all validation in the model (e.g. Name Required) to increase security
            {
                if (covertype.Id == 0)
                {
                    _unitOfWork.CoverType.Add(covertype);

                }
                else
                {
                    _unitOfWork.CoverType.Update(covertype);
                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));

            }
            return View(covertype);
        }

        // API calls here
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            // return NotFound();
            var allObj = _unitOfWork.CoverType.GetAll();
            return Json(new { data = allObj });
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.CoverType.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.CoverType.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete sucessful" });
        }

        #endregion
    }
}
