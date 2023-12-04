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

@09.20am New CoverType.cs model added to ShobhinsBooks.Models Directory

@09.22am ID and Name properties added to the model.

@09.30am New CoverTypeRepository class and ICoverTypeRepository interface added to respective folders in DataAccess directory.

@09.34am Relevant using statements added to CoverTypeRepository class.

@09.45am Methods pointing to ApplicationDBContext added to CoverTypeRepository class.

@10.15am ICoverTypeRepository interface modified add Update method added.

@10.25am ICoverTypeRepository implemented in CoverTypeRepository class and added code to retreive first or default object 

@10.34am CoverType added to ApplicatioDbContext to resolve error in CoverTypeRepository

@01.00pm CoverType added to UnitOfWork and IUnitOfWork

@01.15pm Migration added to implement CoverType and database updated
```
add-migration CoverTypeAdded
update-database
```
@01.20pm checked migration history to verify if new migration has been applied to db
```
get-migration
```
@01.26pm New controlled called CoverTypeController added in Areas/Admin/Controllers

@01.27pm Relevant code added to use the IUnitOfWork from .DataAccess project

@01.30pm New Folder called CoverType added in Areas/Admin/Views

@01.32pm Generated empty View file Index in the folder

Modified generic html code in View.

Tested To see if View is rendered correctly.

Added CoverType link to the navbar dropdownn menu.

CoverType.js created and added to wwwroot dir, section call added to Index.cshtml to invoke js

@01.37pm Tested CoverType Page to see if create and edit functions are working properly

Received NullException in CoverTypeController.cs GetAll() function invoke statement.

After a lot of headscratching, figured out that UnitOfWork.cs was missing object creation statement

```
 CoverType = new CoverTypeRepository(_db);
```
CoverType page tested to work with all functionalities.

Product.cs model added to ShobhinsBooks.Models

Reference to new product model class added to ApplicationDbContext

@01.40pm migration added and database updated
```
add-migration addProductToDb
update-database
```
[Required] validation rule added to Title,ISBN and autho fields 

@01.56pm migration added for new validation rules and database updated
```
add-migration addValidationToProduct
```
@01.58pm Got warning in PM console saying "An operation was scaffolded that may result in the loss of data.Please review the migration for accuracy"

@02.08pm ProductRepository and IProductRepository interface added

@02.13pm Reference to the same added to UnitOfWork and IUnitOfWork

@02.24pm Tested for build errors; none found.

@02.30pm ProductController class added to Area/Admin/Controllers and modified code as per instructions

@02.34pm Created new viewmodel ProductVM in ShobhinsBooksModels/ViewModels/

@02.43pm Microsoft.AspNetCore.Mvc.ViewFeatures package installed to resolve errors in ProductVM.cs.

@02.50pm ProductController modified to add IActionResult Upsert method and HttpPost,HttpDelete methods. commented out the HttpPost as per instructions. 

@02.55pm APICall modified to include call to Category and CoverType properties.

03.30pm New view file Index.cshtml created for Products and code copied from Category->Index.cshtml; Relevant properties of Product added.

@03.43pm product.js file added to wwwroot/css dir and modified for Products page.

@03.50pm Products page added to navbar drop down menu

@03.54pm Tested application for Products page rendering.

@04.00pm Upsert.cshtml view added to Product folder

@04.12pm Added code from files provided

@04.16pm Created a free account at tiny.cloud to integrate WYSIWYG editor to product page's create/edit product section

@04.30pm Tested the Product page for added functionalities

@04.32pm Uncommented the HttpPost method in Product Controller as per instructions.

2023-11-23 @04.15pm Noticed that the create new buttons on index pages for Category,CoverType and product were
aligned incorrectly,figured out it was because of the bootstrap class text-right used instead of text-end,
corrected the same on all 3 index views and tested the output.

@9.46pm Tried to insert a new product and noticed that the CoverType dropdown lists out categories,instead of covertypes, fixed the same 
in Product>upsert.cshtml

@10.02 Tried to insert a new product again and that didnt work,noticed that I was missing a bit of code for _CreateAndBackToListButton. 
Added the same and lets see if that would fix the issue with adding a product.

@10.29pm Noticed that the Product property Imageurl was incorrectly added as ImageUr1,created a migration for the same and updated
the database
```
add-migration EditProductDbFieldName
```

@10.48pm All that still didn't fix the issue with not being able to add a product. Checked product controller to see if there's anything wrong.  HttpPost had Product product being passed
insteead of ProductVM productVM. Changed the same and lets see if that's fix the issue

@10.50pm Got sql exception
"SqlException: The INSERT statement conflicted with the FOREIGN KEY constraint "FK_Products_CoverTypes_CategoryId". The conflict occurred in database "ShobhinsBookStore", table "dbo.CoverTypes", column 'Id'."

@11.03pm Corrected the forien key constraint in Product Model

@11.20pm Added a migration for the changes made in Product Model
```
add-migration EditProductModel
```

@11.30pm SQL Exception resolved. Encountered datatable error when populating data in Product index page. 
"DataTables warning: table id=tblData - Requested unknown parameter 'price' for row 0, column 2."

2023-11-24 @12.10pm Checked datatables init script product.js if I missed something in there

@12.30pm After a lot of headscratching and with a li'l bit of help from google,finally figured out what was going wrong with the 
data retrieval, the property names to be returned had a few mismatches with the property names in the json data file generated. 
Fixed the same and now the issue has been resolved.

@11.05pm So far I've completed working with how products get added or modified,the next phase of the Bookstore project is to modify ProductController to 
ensure the image uploaded during product creation is properly stored and the Homecontroller also needs to be modified to ensure it has 
relevant code to display the book images.

@11.10 Referring to BulkyBook,added code to ProductController,to store the image uploaded to wwwroot/images/products/ dir.

@11.30pm Tested out updating the existing product entry that I made yesterday and the image is being stored as intended. Noticed that the column
widths of product page needs to be adjusted. Did a bit of research and found that the width of columns can be adjusted from 
product.js, changed the same and the columns look much better now.

@11.55pm I need to modify the HomeController which controls the index view which is the first thing that is rendered when the app is launched.
The homescreen needs to retreive the cover images of book records and show it.


2023-11-25 @12.40pm Done with the additions and tested out the new homepage. Gor NullObjectException.
Checked HomeController and index.cshtml again. Turns out the IActionResult Index() method was returning view without passing the
IEnumerable produclList as parameter. Corrected the same and everythings working as expected.

@12.50am Added a few more categories,covertypes and added one more product,everything works as expected

@05.40 Reviewed the final output and noticed that the card layout on the homepage needs to aligned properly,added height attribs to 
card element and tested the output.

2023-11-28 @01.44am Modified the if condition in index view of home to display a welcome message in case there are no products instead of 
showing a blank screen.

2023-12-2 @3.00pm Noticed that my delete function had an issue where in .if a product doesn't have animage added to ot,then,
the delete function returns a null exception as <<objFromDb.Product.ImageUrl>> returns null.

@3.15pm Added an if block which checks if objFromDb.Product.ImageUrl is != null, and runs the image deleteion only if this condition
returns true, else, the product is removed entirely.

@3.15pm Tested if the new if block works as intended. 

@3.26pm Everything works as intended so far. Pushing progress to Git
******************************************************************

**Testing**

![Screenshot_WlcmePage](https://github.com/madmax117/ShobhinsBookStore/blob/master/Screenshot%20(369).png)

The web app has been tested to work as intended.
*******************************************************************

**Author**

Author: Shobhin Thomas Saj

Student number: 0819372

Purpose: WEB452 Assignment#2


