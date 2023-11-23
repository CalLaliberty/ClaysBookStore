Date: 2023-10-25
Author: Clay Laliberty
Purpose: BookStore App using Asp.net


-------------------------------------------------------------
|2:19PM	⏰			📅 2023-10-25 			    
-------------------------------------------------------------

Created a new ASP.net app ran code and tested 

Created a README.txt

no issues or errors.

-------------------------------------------------------------
|2:19PM	⏰			📅 2023-10-25 			    
-------------------------------------------------------------

Going through slides slowly and reading and verifying code in files.

In Startup.cs removed a line of code and commented it out so if I need it again I can use it.

Created a Github repo 

Created a README.mb pulled code and pushed 

commented out //"sslPort": 44350 inside launchSettings.json

-------------------------------------------------------------
|2:45PM	⏰			📅 2023-10-25 			    
-------------------------------------------------------------

Starting 1.2 Debugging 

Completed debugging process to understand for the future if I run
into any issues.

-------------------------------------------------------------
|2:51PM	⏰			📅 2023-10-25 			    
-------------------------------------------------------------

Starting 1.3 Bootstrap

Selected a theme called called "Darkly" 

Renamed bootstrap.css to bootsrtapOLD.css

Added my new theme inside wwwroot/lib/bootstrap/dist/css

Replaced my site.css code with new updated code provided

Updated my _Layout.cshtml with new code from slides

Updated my _LoginPartial.cshtml with new code from slides

Ran and tested code, no issues or errors new theme is applied.

-------------------------------------------------------------
|3:05PM	⏰			📅 2023-10-25 			    
-------------------------------------------------------------

Updated and added new css and js files provided 

Added a dropdown menu in _Layout.cshtml using this code:

<li class="nav-item dropdown">
    <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button"data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
        Dropdown
    </a>
    <div class="dropdown-menu" aria-labelledby="navbarDropdown">
        <a class="dropdown-item" href="#">Action</a>
        <a class="dropdown-item" href="#">Another action</a>
        <div class="dropdown-divider"></div>
        <a class="dropdown-item" href="#">Something else here</a>
    </div>
</li>

Ran and tested code, dropdown works as it should

No issues or errors

Renamed dropdown to "Content Management" tested to see if the 
new title was applied.

-------------------------------------------------------------
|3:53PM	⏰			📅 2023-10-25 			    
-------------------------------------------------------------

Strating 1.4 Add Projects & Modify 

Created three new projects nameed:

ClaysBooks.DataAccess
ClaysBooks.Models
ClaysBooks.Utiliy

Copied my Data folder and pasted it in the ClaysBooks.DataAccess folder 
and deleted the original

Installed 

Microsoft.EntityFramework.Core.Relational and Microsoft.Core.SqlServer packages

Deleted my migrations folder 

-------------------------------------------------------------
|5:20PM	⏰			📅 2023-10-25 			    
-------------------------------------------------------------

Installed 

Microsoft.Identity.EntityFramework

Updated namespace to "namespace ClaysBookStore.DataAccess.Data" in ApplicationDbContext.cs

Deleted default Class1.cs files in all projects

Build ClaysBooks.DataAccess, Build successful

Moved Models folder into ClaysBooks.Models and deleted the original.

Added project reference - .DataAccess and .Models

Renamed Models folder to "ViewModels"

Inside ErrorViewModel.cs changed namespace to "namespace ClaysBookStore.Models.ViewModels"

Build ClaysBooks.Models, Build successful

-------------------------------------------------------------
|6:57PM	⏰			📅 2023-10-25 			    
-------------------------------------------------------------

Went through all issues and errors was able to run program without
any new errors

Added this using ClaysBookStore.DataAccess.Data; to Startup.cs

Added this ClaysBookStore.Models.ViewModels.ErrorViewModel to Error.cshtml

I get a prompted message when I run the program though, doesnt 
seem to appear anymore but the program seems to run..

-------------------------------------------------------------
|7:43PM	⏰			📅 2023-10-25 			    
-------------------------------------------------------------

Moving on to the Utilty project folder

Created a class inside Utility folder called "SD.cs"

Added properties to the main project "ClaysBookStore"

Added properties to the main project "ClaysBookStore.DataAccess"

Added a "Customers" area to Areas no issues or errors... thank god..🙏

In Startup.cs pattern line of code with this code - pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

Moved HomeController.cs into Areas/Customers/Controllers

Deleted the Data and Models folders located in  Areas/Customers/

After trail and error I've realized I created a folder called "Customers" not "Customer"
this caused me tons!!! of greif luckily I figured it out and program ran without any issues...

-------------------------------------------------------------
|9:20PM	⏰			📅 2023-10-25 			    
-------------------------------------------------------------

Updated _ViewStart.cshtml

Ran code, the theme has been applied again, let's go🎉🎉🎉  

Added a new item in Areas called Admin 

Added the proper view files into Admin/Views
Deleted Data,Models and Controller folders

-------------------------------------------------------------
|9:43PM	⏰			📅 2023-10-25 			    
-------------------------------------------------------------

Ran code to verify everything is still working. 
No issues or errors.

Push code to Github.

-------------------------------------------------------------
|8:35AM	⏰			📅 2023-11-03 			    
-------------------------------------------------------------

Build app no errors.

Ran app, no issues or errors.

In appsettings.json modified code from this:

"Server=(localdb)\\mssqllocaldb;Database=aspnet-ClaysBookStore-D911B6ED-C22B-4602-B024-760F9BC6C2CA;Trusted_Connection=True;MultipleActiveResultSets=true"

To this:

"Server=(localdb)\\mssqllocaldb;Database=ClaysBookStore;Trusted_Connection=True;MultipleActiveResultSets=true"

Changed default project to: ClaysBooks.DataAccess

Ran this command:
add-migration AddDefaultIdentityMigration

Build succeeded.

Make note of this code: To undo this action, use Remove-Migration.

New file created: 20231103124130_AddDefaultIdentityMigration.cs

After migration was completed, update-database

Build started...
Build succeeded.
Done.

Reviewed SQL Server Object Exploerer all files are there and match whats on pp slides

Ran app to check for issues or errors
program ran fine no problems.

Added new file to ClaysBooks.Models called: Category.cs

-------------------------------------------------------------
|8:03PM	⏰			📅 2023-11-03 			    
-------------------------------------------------------------

In order for me to create the table I had to delete the file: 20231104000201_AddCategoryToDb.cs and re-run commands 

Now the Categories table is made and appears in the SQL Server Object Explorer

Completed 2.1 Create the DB 

Check everything over once more, run code for any errors or issues if none push the code to github.

-------------------------------------------------------------
|8:36PM	⏰			📅 2023-11-03 			    
-------------------------------------------------------------

Starting part 2.2 Repository

In ICategoryRepository.cs removed

using System.Threading.Tasks;
using System.Linq;

Also changed this:

class ICategoryRepository => interface ICategoryRepository 

In CategoryRepository.cs Modify

Removed this:

using System.Linq;
using System.Threading.Tasks;


-------------------------------------------------------------
|10:35PM	⏰			📅 2023-11-03 			    
-------------------------------------------------------------

Fix any errors that appeared, ran code project builds with no issues or errors

commits made and pushed to GitHub

-------------------------------------------------------------
|10:35PM	⏰			📅 2023-11-03 			    
-------------------------------------------------------------

Created a new file called ISP_Call.cs inside IRepository

Removed these lines of code:

using System.Threading.Tasks;
using System.Linq;

-------------------------------------------------------------
|12:06AM	⏰			📅 2023-11-03 			    
-------------------------------------------------------------

Created a file called IUnitOfWork.cs inside IRepository

Ran app just to test if any errors or issues, no problems.


-------------------------------------------------------------
|12:26AM	⏰			📅 2023-11-03 			    
-------------------------------------------------------------

using ClaysBooks.DataAccess.Repository; <--- Added to the top of Startup.cs

Also had to change names so that it was both UnitOfWork, IUnitOfWork was causing an error...

Ran program, no issues or errors.

-------------------------------------------------------------
|11:46AM	⏰			📅 2023-11-05 			    
-------------------------------------------------------------

Resovled issue in startup.cs

Ran code no issues or errors.

Starting part 2.3 Category CRUD

Created new item in dropdown and created my Category page

Ran program no issues or errors, push code to GitHub.

-------------------------------------------------------------
|1:22PM	⏰			📅 2023-11-05 			    
-------------------------------------------------------------

Modify the Index.cshtml

Ran code, webpage matches whats displayed on slides.

Added the new file called category.js inside wwwroot/js/category.js

Ran code no issues or errors, webpage matches slides.

Created Upsert.cshtml

-------------------------------------------------------------
|2:27PM	⏰			📅 2023-11-05 			    
-------------------------------------------------------------

Ran code to test for errors or issues afer updates to code.

No issues or errors..

-------------------------------------------------------------
|3:02PM	⏰			📅 2023-11-05 			    
-------------------------------------------------------------

Update and created a edit and create in shared 

In Shared created the following created my Razor View files:

_CreateAndBackToListButton.cshtml

_EditAndBackToListButton.cshtml

Ran code, was able to add and update fields

Now adding the delete funciton in CategoryController.cs

-------------------------------------------------------------
|3:15PM	⏰			📅 2023-11-05 			    
-------------------------------------------------------------

Tested app once more to make sure update and adding new fields works currently.

Eveything seems to function as its supposed to still. 

-------------------------------------------------------------
|3:21PM	⏰			📅 2023-11-05 			    
-------------------------------------------------------------

Creating the delete fucntion 

Updated code in category.js 

Updates made to these block of code:

<a onclick=Delete("/Admin/Category/Delete/${data}") class="btn btn-danger text-white" style="cursor:pointer">

function Delete(url) {
    swal({
        title: "Are you sure you want to delete?",
        text: "You will not be able to restore the data!",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}

Ran and tested code delete works as attended. Save work. 

-------------------------------------------------------------
|3:42PM	⏰			📅 2023-11-05 			    
-------------------------------------------------------------

Final review of all code, running final test and making sure everything works
currently 

-------------------------------------------------------------
|4:13PM	⏰			📅 2023-11-05 			    
-------------------------------------------------------------

Everything works with no issues or errors!! 

Completed part 2 of assignment, push to GitHub.

-------------------------------------------------------------
|11:49AM	⏰			📅 2023-11-19 			    
-------------------------------------------------------------

Created my CoverType Model

Created CoverTypeRepository

Createed ICoverTypeRepository

Add CoverType to UnitOfWork and IUnitOfWork

Created migration: 20231119164821_AddCoverTypeToDb.cs

Updated-databae, Covertype appears in SQL Viewer. 

------------------------------------------------------------
|11:52AM	⏰			📅 2023-11-19 			    
-------------------------------------------------------------

Created the controller for CoverType with all required action methods 

Added it to navbar, modified the layout.

Added covertype to index view and added it to the js file.

Ran code to test my app and make sure Covertpye appears and works correctly.

No issues or errors. Pushing to GitHub

------------------------------------------------------------
|12:25PM	⏰			📅 2023-11-19 			    
-------------------------------------------------------------

Starting on 3.2 Product CRUD.

Testing app to make sure everything still works correctly. 

Created new class in models called Product.

Created my addProductToDb to migrations folder:

20231119175036_addProductToDb.cs

update-database, build succeeded Products shows up in SQL viewer.

added addValidationToProduct: 20231119180452_addValidationToProduct.cs

------------------------------------------------------------
|1:11PM	⏰			📅 2023-11-19 			    
-------------------------------------------------------------

Added ProductRepository to Repository folder

Added IProductRepository to IRepository folder

Updated code in both files

Added Product to UnitOfWork and IUnitOfWork

No errors or issues, Ran code to test app 

No issues or errors, Pushing code to github.

------------------------------------------------------------
|2:17PM	⏰			📅 2023-11-19 			    
-------------------------------------------------------------

Starting on 3.2 Product CRUD(2)

Created my Product controller 

Created my ProductRepository

Created my IProductRepository 

Created my ProductVM 

Created product.js and modified code 

Modified code and commented it:

// use HTTP POST to define the post-action method
        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public IActionResult Upsert(Product product)
        //{
        //    if (ModelState.IsValid)  // checks all validation in the model (e.g. Name Required) to increase security
        //    {
        //        if (product.Id == 0)
        //        {
        //            _unitOfWork.Product.Add(product);

        //        }
        //        else
        //        {
        //            _unitOfWork.Product.Update(product);
        //        }

        //        _unitOfWork.Save();
        //        return RedirectToAction(nameof(Index));

        //    }
        //    return View(product);
        //}

Added it under dropdown 

------------------------------------------------------------
|3:57PM	⏰			📅 2023-11-19 			    
-------------------------------------------------------------

3.2 Product CRUD 

Created Upsert.cs for products

Used code from assignment 2 file

Singed up for tiny.cloud and applied to my app.

Ran the app to test for errors.

Added folder in wwwroot => images/products

Uncommented block of code inside ProductController.cs

Ran code to test for errors or issues. Api doesn't seem to appear just says loading...

------------------------------------------------------------
|6:26PM	⏰			📅 2023-11-19 			    
-------------------------------------------------------------

Added a new theme called "minty" so you can view the text better.

Removed this from nav:

<li class="nav-item">
    <a class="nav-link" asp-area="Admin" asp-controller="Category" asp-action="Index">Category</a> <!--Removed text-dark-->
</li>

------------------------------------------------------------
|7:47PM	⏰			📅 2023-11-19 			    
-------------------------------------------------------------

Getting error when trying to create a product "System.InvalidOperationException"

This block of code inside ProductController.cs:

public IActionResult GetAll()
        {
            // return NotFound();
            var allObj = _unitOfWork.Product.GetAll(includeProperties:"Category,CoverType");   // Included Category and CoverType
            return Json(new { data = allObj });
        }

This had a space and was "Category, CoverType" changed to "Category,CoverType"

Ran and tested app no issues or errors after removal of space. 

------------------------------------------------------------
|1:52PM	⏰			📅 2023-11-23 			    
-------------------------------------------------------------

Fixed error in Product/Upsert.cshtml

<div class="col-8">
                    @Html.DropDownListFor(m => m.Product.CoverTypeId, Model.CoverTypeList, "-Select a Cover Type",
                   new { @class = "form-control" })
                    <span asp-validation-for="Product.CoverTypeId" class="text-danger"></span>
</div>

Had CategoriesId instead of CoverTypeId