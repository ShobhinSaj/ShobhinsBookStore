## WEB452(DEVELOP WEB APPS IN ASP.NET) Assignment #2


**Description & General Notes**

An MVC Web app built using C# and ASP.NET visual studio.
*******************************************************************

This readme will take you through the process of building an ASP.net WEB APP in Visual Studio for the WEB452(DEVELOP WEB APPS IN ASP.NET) Course.
A presentation file has been provided by the instructor with steps to follow, to complete the first part of Assignment 2.

2023-10-28 @10.30am Created a new dot new ASP.net core web application with authentication type set to individual user accounts based on core 5.0.

@10.45am  Inspected the Areas folder which has the Identity folder in it and the default HomeController and ErrorModel.

@10.55am  Tried executing the web app with breakpoints at Actions Index() and Privacy(). 

@11.00am Created a new branch in existing Github repo for ASP assignments and named it Assignment2 and files were pushed to the branch.

@11.10am Visited the website Bootswatch.com which has custom themes for the webapp. Themes listed out were indeed overwhelming but I've decided to go with the theme Darkly since it
somewhat resembles with the kali linux os ui.

@11.20am Replaced default bootstrap.css file with bootstrap from bootswatch.com and replaced site.css with file provided.
Modified nav element class names to navbar-dark and bg-primary
Removed text-dark class from anchor tag

@11.35am Modified _LoginPartial.cshtml as per instructions in file provided 

@11.50am Added additional stylesheets and scripts provided to _Layout.cshtml
Added code for a dropdow menu in _Layout.cshtml, but for some reason the dropdown was not working on execution
Figured out i need to add a bootstrap script for the dropdown menu to work
```
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
```
Dropdown menu is working alright now

@12.00am Added 3 new .NET Core class libraries named ShobhinsBooks.DataAccess,ShobhinsBooks.Models and ShobhinsBooks.Utility
Copied Data folder to DataAccess library

@12.15am Microsoft.EntityFrameworkCore.Relational v5.0.17 and Microsoft.EntityFrameworkCore.SqlServer v5.0.17 installed via Nuget Packet Manager.

@12.25am Made changes to directory as instructed in file provided.
New Area called Customer and Admin added to Areas
References to _Layout.cshtml changed in  _ViewStart.cshtml.
Changes pushed to Github repo.

2023-11-02 @03.00pm Had to redo assignments part 1 steps as I forgot to uncheck the option which puts solution and project in same directory.
		   
@03.15pm  Modified site.css, _Layout.cshtml, _LoginPartial.cshtml, added new bootstrap theme 'Darkly'
		   
@03.22pm Added a dropdown menu to the navbar
		   
@03.30pm Created 3 new projects(.NET Core class libraries)
		   
@03.41pm Installed Microsoft.EntityFrameworkCore.SqlServer/Relational Packages v5.0.17
		   
@11.04pm Fixed build errors with namespaces and deleted default class files in new projects added
		   
@11.15pm Moved Models to library ShobhinsBooks.Models and renamed to ViewModels
		   
@11.46pm New Area "Customer" added
		   
@11.53pm Added Area "Admin" and updated reference to _Layout.cshtml in _ViewStart.cshtml

2023-11-06 @07.00pm appsttings.json modified to have DB name changed to ShobhinsBookStore
			
@07.20pm Migration added and database updated with commands: 
			
```
Add-Migration DefaultIdentityMigrationAdded
```
			
@07.25pm Database updated to apply new migration
			
```
update-database
```

2023-11-07 01.20am New Category Model added- 'Category.cs'
			
@01.24am Migration added to update database with new column Category
			
```
add-migration NewCategoryAdded

```

@01.40am New folder 'Repository' added to library ShobhinsBooks.DataAccess

2023-11-08 	@06.05pm Couldnt complete working on the assignment coz my bootloader was acting weird and the laptop was stuck in a boot loop.
			
@06.20pm Interfaces and corresponding classes added to Repository folder with interfaces in a subfolder 'IRepository'.
			
@11.01pm New folder 'Controllers' added to Admin Area in ShobhinsBookStore project and new controller added for Category.

2023-11-11 @12.30am _Layout.cshtml modified to have new nav link for category and also added a dropdown menu with code from bootswatch.com

```
<li class="nav-item dropdown">
	<a class="nav-link dropdown-toggle" data-bs-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">Dropdown</a>
	<div class="dropdown-menu">
		<a class="dropdown-item" href="#">Action</a>
		<a class="dropdown-item" href="#">Another action</a>
		<a class="dropdown-item" href="#">Something else here</a>
	<div class="dropdown-divider"></div>
	<a class="dropdown-item" href="#">Separated link</a>
	</div>
</li>
```

@12.50am Category.js added with code to display delete and edit icons

@1.35am View file created for the upsert function in Catgory page which lets user add/edit a category

@2.10am Validation functionalities added to Category page using validation script

@3.10am Create/edit functionalities added and tested in category page.

@3.18am Added and tested the delete function in category page which allows user to delete existing categories,uses toaster and sweetalert.

@3.40am Category.js modified to trigger delete category function.

2023-11-17 @08.15pm Found a duplicat readme file in the directory which must have been created by accident, deleted the same.

@8.40pm There was a duplicate NewCategoryAdded migration found,this should be from the previous attempt on the project. Removed the same and updated database.

2023-11-20 @09.00am Part 3 submission and assessment is due tomorrow. First step is to add another field to the db using a new model CoverType.

@09.10am The process is same as Category field which was added earlier.
New CoverType.cs model added to ShobhinsBooks.Models Directory
ID and Name properties sadded to the model.
New CoverTypeRepository class and ICoverTypeRepository interface added to respective folders in DataAccess directory.
Relevant using statements added to CoverTypeRepository class.
Methods pointing to ApplicationDBContext added to CoverTypeRepository class.
ICoverTypeRepository interface modified add Update method added.
ICoverTypeRepository implemented in CoverTypeRepository class and added code to retreive first or default object 
CoverType added to ApplicatioDbContext to resolve error in CoverTypeRepository
CoverType added to UnitOfWork and IUnitOfWork
Migration added to implement CoverType and database updated
checked migration history to verify if new migration has been applied to db
```
get-migration
```

******************************************************************

**Testing**

![Screenshot_WlcmePage](https://github.com/madmax117/ShobhinsBookStore/blob/master/Screenshot%20(369).png)

The web app has been tested to work as intended.
*******************************************************************

**Author**

Author: Shobhin Thomas Saj

Student number: 0819372

Purpose: WEB452 Assignment#2


