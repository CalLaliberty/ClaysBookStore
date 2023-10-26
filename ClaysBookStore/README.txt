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