using ClaysBooks.DataAccess.Repository.IRepository;
using ClaysBooks.Models;
using ClaysBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ClaysBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType covertype)
        {

            // IMPORTANT!!! use .NET LINQ to retrieve the first or default category object,
            // then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb != null) // save changes if not null
            {
                objFromDb.Name = covertype.Name;
                _db.SaveChanges();
            }


        }
    }
}
