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