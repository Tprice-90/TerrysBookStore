~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````
										TERRY'S BOOK STORE README

Date: 2021/11/01
Time: 11:35AM
-Forgot to create README when I started the project so here is a breakdown of what I did:
	-Created the project using ASP.Net Core web app with MVC
	-added Individual User Accounts, enabled Razor Runtime Compilation to allow for live editing
	-Removed AddDefaultIdentity options
	-Created the Github Repository for the project
	-Imported new Bootstrap Lux style from Bootswatch
	-Updated the _Layout shared view to allow bootstrap.css to be applied
	-Added 2 breakpoints; 1 at the Index View method, 1 at the Privacy view method to see how setting breakppoints can assist in
	 finding bugs


Time: 11:43AM
-Made further updates to _layout file; Changed navbar from light to dark, changed bg from white to primary, updated footer text
 to remove dark text
-updated LoginPartial.cshtml to remove dark-text references
-Ran the project to view the updates and make sure everything worked... It looks GOOD!

Time: 12:01PM
-Renamed site.css to Old_site.css and created new stylesheet file and inserted css code provided by Andrew
-Added additional css stylesheet and javascript script file links provided by Andrew
-Tried adding a dropdown menu but having trouble getting it to work...Menu displays on page but is not clickable

Date: 2021/11/02
Time: 2:02PM
-Discovered in powerpoint that there was a link provided that showed all the code needed to make the dropdown
 menu work... Going to complete the code then test for functionality
-Test was successful! Dorpdown menu functions!!
-Updated Dropdown link to read Content Management

Time: 2:11PM
-Next step is to create 3 new .Net core class libraries to the existing project, doing that now
-Currently unsure of what category of project to create...Slides state .Net Core Class Library but no such specific
 option exists...Going to select C# Class library because description notes that it can be used for .Net AND .Net Core
 frameworks...in slides, it shows that each project has a Dependencies and Class.cs file, mine does as well but also
 contains: Properties, Appsettings.development.json,Appsettings.json, program.cs, and startup.cs...We will see how this
 goes!
-Noticing that ONLY TerrysBooks.DataAccess project contains extra folders...Will continue with these folders included...

Time: 2:32PM
-Next need to install Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages...Forgot the install comman
 so used get-help NuGet comman...HELPFUL!
-First package installed successfully, second one package was NOT found then I realized i forgot to add Microsoft.
 EntityFrameworkCore before hand...Packages now installed
-Installed Identity.EntityFrameworkCore NuGet package via suggestion lightbulb in ApplicationDbContext.cs for DataAccess
 project...
-Break for lunch...

Time: 3:40PM
-After viewing the slides, realized I didnt't install previous packages to the project itself...corrected that.
-Updated namespace to reflect project
-Deleted Class1.cs from each project
-Attempted to build project, recieved errors... The type name Data does not exist in the namespace...This appears to
 be intended according to slides...

 Time: 3:53PM
 -Moved Model file to .Models project and deleted original.
 -Added references to .Models and .DataAccess to main project which resolved errors
 -Updated ErrorViewModel.cs namespace to reflect name change of Model folder to ViewModels
 -Built project to view errors that occured.. COMMENTED out using TerrysBookStore.Data statement in startup.cs
 -updated HomeController.cs to reflect new ViewModels folder...going to run project to see if it worked....SUCCESS!!!
  Looking good so far...

Time: 4:07PM
-Created new static class file in Utility project, adding reference to it in main project
-Added references to Models and Utility projects to DataAccess project
-Created new Customer area to Areas folder on main project...Build and scaffolding was successful...These things always
 make me nervous...
-Moved HomeControllers.cs to Area/Customer/Controllers and deleted the Data and Model folders inside it
-Modified HomeController.cs to define controller in Customer area
-Moved Home folder from project Views file to Area Views file and ran the app...got a blank screen...
-Possibly need to update the _Layout file to reflect which asp-area index page is in???
-Realized that the page should not be blank then checked route on Startup.cs, made a spelling mistake.. >.<
-Copied the _ViewImports.cshtml and _ViewStart.cshtml files to Area/Customer and updated _ViewStart.cshtml to reflect
 new path...ran app only to recieve an error on the page that ~/Views/Shared/_Layout could not be found.... corrected
 this after realizing i forgot to include .cshtml after _Layout...ran again and error was gone...page looks GOOD again!

Time: 4:34PM
-Adding new Admin area...Scaffolding was successful
-Copied _ViewImports.cshtml and _ViewStart.cshtml to Admin Views Folder and deleted main Controllers folder which
 at this point was emtpy...
-Now pushing updated project to GitHub... 

Date: 2021/11/14
Time: 1:55PM
-I have ran into so many issues with github commits...I lost most all of my progress on second step including most of the 
 Readme file so now I am just trying to grind this through to get it done
-Added default identity migration file added: 20211114223717_AddDefaultIdentityMigration.cs

Time: 5:28PM
-Restarted entire project but forgot yet again to save the readme... first part of Assignment 2 done, now starting part 2
-Cleaned project solution and built to make sure there were no errors, none found build successful
-Updated appsettings.json Database connection name, now adding migration
-Migration file: 20211114223325_AddDefaultIdentityMigration.cs added
-Created Category Model and updated ApplicationDbContext to recieve model then created Category Migration
-file: 20211114224405_AddCategoryToDb.cs added

Time: 5:46PM
-Added Repository folder to DataAccess project and an IRepository folder inside that one
-Created Irepository Interface and updated it to include CRUD properties

Time: 6:14PM
-After completing all CRUD method updating, cleaned and built solution to check for errors..none found

Time: 11:56PM
-Created the IUnitOfWork interface which implements the IDisposable interface
-Created UnitOfWork class which implements IUnitOfWork interface and Dispose and Save functions
-Modified startup.cs to include IUnitOfWork and UnitOfWork in the ConfigureServices call, included new using 
 statements which call to the Repository and Data section in the DataAccess project

Date: 2021/11/15
Time: 12:43AM
-After updating Admin/View Index.cshtml to include Edit and Delete tabs, first with div tags, then
 added javascript code to category.js within the wwwroot/js folder
-ran project and everything appeared to be working except for the Add Category Button....
-I tried hard coding a category but was unsuccessful...
-pushing to GitHub now.

Time: 12:06PM
-I had some issues regarding the Add Category button functionality... I tried updating the database and
 recieved the error: There is already an object named 'Categories' in the database. as well as an error:
 failed executing DbCommand (5s) [Parameters=[], CommandType='Text', CommandTimeout='30']

Date: 2021/11/17
Time: 9:26AM - 10:43AM
-Trying to debug 2 issues:
	1.Add Category function not working
	2.Update-Database throwing error..
-Found that trying to hard code a Category on the Index.cshtm page was the issue behind the database-update
-going to go through slides and see if there was a step that I missed
-Noticing that the AddDefaultIdentityMigration is not appearing in the SqlObjectExplorer
-tried deleting the migration and re-adding it with file: 20211117143825_AddDefaultIdentityMigration.cs
 was not successful, still not showing up in server objects
-Solved issue with DefaultIdentityMigration not displaying by removing the migration then re-adding with file
 20211117152721_AddDefaultIdentityMigration no will add Category Migration 20211117153528_AddCategoryToDb
-was only successful by creating the table and drop function manually
-Add Category function still not working....
-stoping now, will pick back up later

Date: 2021/11/22
Time: 10:58 - 12:15PM [1 hour 17 minutes]
Applying Code To Create a Category, Edit, and Delete
-Created the Upsert.cshtml method within the CategoryController.cs file
-Added Upsert view to the Views/Shared directory and added code provided in the Category Upsert.txt file
-Created partial view for Edit and Back functions with _CreateAndBackToListButton.cshtml and 
-EditAndBackToList.cshtm files, added in code which contained form control and asp-routing information
-Modified Upsert file to include the added partial views
-updated Index.cshtml in the Admin/Views/Category directory to include the newly created Upsert asp-action
-Updated Title h2 tag to use the @title variable which now displays Edit Category/Create Category based on
 the context
-included validation script to show any errors when editing or creating a category name
-Created an Upsert POST action method which calls to _unitOfWork, added Void to Save() method
-Removed SaveChanges() method from the CategoryRepository file and moved the Save() function to outside of the
 validation check, as well as added a return to the Index
-Tested the app to see if Category could be created and edited...SUCCESS!
-Added Delete function to CategoryController.cs then added that functionality to the category.js file
-tested Delete functionality and it is not working...

Date: 2021/11/23
Time: 2:00PM-4:00PM [2 hours]
Creating Cover CRUD
-created CoverType.cs and copied Category class and updated the class name to reflect CoverType
-updated dbContext file to include CoverType because my initial migration failed
-migration also failed because i forgot to select .DataAccess as the default project
-New migration file: 20211123193015_AddCoverTypeToDb.cs
-database updated
-Created CoverTypeController, copied code from CategoryController and updated all instances
 of the word Category and category to CoverType and coverType since both controllers use the
 same methods
-Had issue where when testing CoverType CRUD, error thrown with db_save(), checked SQL server
 Object and saw CoverType table was not created, to resolve, had to delete Categories table
 then re-update database, both tables were created.. tested CRUD and it worked this time.

Time: 4:00PM - 4:45PM {45 Minutes}
Creating Product CRUD
-created Product model and added reference to it in dbContext
-file created: 20211123211055_AddProductToDb.cs
-checked SOE to make sure table was created and it was
-updated Product class to require Title, ISBN and Author, created new migration
-file created: 20211123211809_AddValidationToProduct.cs
-Created ProductRepository and updated code
-Created IProductRepository and updated code
-added Product to both UnitOfWork and IUnitOfWork

Time: 5:00PM - 5:43PM [43 Minutes]
Product CRUD Part 2
-Created ProductController.cs then copied code from CoverType.cs
-updated code to use IWebHostEnvironment and added using statement to include AspNetCore.Hosting
-Created ProductVM in ViewModels directory in .Models project
-set class to public and updated code and installed Microsoft.AspNetCore.Mvc.ViewFeatures NuGet
 package
-updated ProductControler to include ProductVM and added using statements to resolve issue with
 ProductVM not being found: using TerrysBooks.Models.ViewModels as well as AspNetCore.Mvc.Rendering
-Modified ProductController API to include Category and CoverType
-Added Index view for Product and updated it to include all properties for the Product class as well
 as modifying the js script to reference a newly created product.js
-copied category.js and renamed it product.js and modified it to include columns for all the properties
 in Product class
-updated _Layout.cshtml so it would include the Product view in the dropdown list
-tested app to make sure product view was working and it did...Now pushing to GitHub

Date: 2021/11/24
Time: 10:16AM
-Was having an issue where when trying to access Product list on the app was generating an error:
 System.InvalidOperationException: 'An error was generated for warning 
 'Microsoft.EntityFrameworkCore.Query.InvalidIncludePathError': 
 Unable to find navigation ' CoverType' specified in string based include path ' CoverType'. 
 This exception can be suppressed or logged by passing event ID 'CoreEventId.InvalidIncludePathError' 
 to the 'ConfigureWarnings' method in 'DbContext.OnConfiguring' or 'AddDbContext'.'
-With some assistance from Abby I found that I had a syntax error in the ProductController.cs file
 where there was an extra space between the two included properties in the GetAll() method...
 removing the space allowed the app to function properly

Date: 2021/11/29
Time: 5:00PM - 5:44PM [44 minutes]
Debugging Delete Function
-Was comparing my code to github example code provided
-started with DataAccess Repository and IRepostory files for both Category and Cover Type
-Moved on to compare each Category and CoverType Index files and Upsert files
-found issue was a Typo in the ........ ONCLICK function where I had it spelled Onlcik...
-Tested and not only did it fix the issue I had with the delete button not working, but also with
 the Category data loading in CoverType as well. all seems right now....

Time: 5:45PM - 6:10PM [25 minutes]
-Found issue with the Add product page where when selecting a Cover Type it would show a list of 
 Categories instead...

Date: 2021/12/03
Time: 8:30PM - 8:44PM [14 minutes]
-After looking through the code from github, solved the issue with Categories showing up in the
 Cover Type dropdown when I found that Categories was being called instead of Cover Type in the 
 Product Upsert file.

Time: 10:22PM - 11:10PM [48 Minutes]
Create Product Not Working
-When Creating a product I get the error:
  DataTables warning: table id=tblData - Requested unknown parameter 'name' for row 0, column 0. 
						For more information about this error, please see http://datatables.net/tn/4
-All that appears in the table is the ISBN and the Author, however, in SQL Object Viewer it shows
 all information except for the ImgUrl.... Delete Button also not functional.
-Going through provided github code to compare and see errors I have in my code.
-Noticed that in the provided code, the Product Upsert was altered to include an Image folder in the wwwroot
 folder.
-Solved the issue, on the product.js load data tables function, the data categories needed to be updated 
 to reflect the product properties.

Date: 2021/12/04
Time: 2:33PM - 2:56PM
Delete Product Debugging
-Product is added properly but delete function is not working...Looking through provided code to find
 inconsistencies with my code.
-Updated ProductController to include ProductVM calls

Time:4:15PM - 4:47PM [32 Minutes]
-Solved issue with Image not uploading to database, product folder should have been product"s".
-Still looking into Delete function for products not working...have gone over js code, product controller
 product upsert but have not found any errors yet...Will move on to Displaying Products on home screen and
 will come back to this

Time: 5:00PM
Updating HomeController
-Added using statements to import Models and IRepository
-Implemented unitOfWork into Home controller
-Imported Product list and View(ProductList)
-Removed defauly Welcome div on Home Index added Product list with sections for book title, author, listPrice
 and imgUrl
-After testing, image cards pop up but images do not load properly
-Fixed an error in the product controller when defining the webPath, forgot to include "\" after the product 
 folder name. updated database imgUrl paths in SQL Server Objects and images appeared properly