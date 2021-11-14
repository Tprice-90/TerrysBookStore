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