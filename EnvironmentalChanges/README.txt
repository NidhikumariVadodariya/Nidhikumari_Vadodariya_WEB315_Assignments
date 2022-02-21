Name: Nidhikumari Vadodariya
Student ID: 0788964
Date:19-02-2022
Assignment name: Assignment 1

Here are the written steps those I followed during assignment::

In order to make this assignment I create first repository on github and start my assignment named EnvironmentalChanges in Visual stuio code.
Then run the command that trusts the HTTPS development certificate which helps to run my assignment on webpage by localhost.
It created the pages folder along with the supported files .cshtml file for HTML markup with C# code using Razor syntax and .cshtml.cs file that has C# code that handles page events.
Pages that contains wwwroot folder, appsettings.json, Program.cs, Startup.cs. 
(if you run these by dotnet watch run then you will get a simple welcome webpage on webbrowser).
I added data model then, in which I created folder and model file created named EChange.cs and add my environment properties for annotation.
These make app's model classes use Entity Framework Core (EF Core) to work with the database.
After that I installed NuGet packages and EF tools and run the commands of vsersion 5 for SqLite and SqlServerdatabse which will help me in scaffolding.
I added Packages needed for scaffolding: Microsoft.VisualStudio.Web.CodeGeneration.Design and Microsoft.EntityFrameworkCore.SqlServer.
Now, the EChange model is scaffolded. That is, the scaffolding tool produces pages for Create, Read, Update, and Delete (CRUD) operations for the Echange model.
The scaffolded model creates automatically CRUD pages under the EChange which are ready for adding, updating, and deleting the properties and values
It is readyfor the development right after added SQLite for development, SQL Server for production of Create, Delete, Details, Edit, and Index files or pages.
It then needed to create the initial database schema using EF's migration feature by dotnet ef migrations add InitialCreate, and dotnet ef database update command.
Above command will helps to generate the code to create the initial database schema. The schema is based on the model specified in DbContext. The InitialCreate argument is used to name the migrations and The update command runs the Up method in migrations that have not been applied.
Now it's time to test the app which has been created.
Run the app on http://localhost:port/Echange and append the given name of the repository or app to the URL in the browser.
Then I created the test link which inserts my new data first then perform the same action on the Edit, Details, and Delete links.
Then SQL is being Logged of Entity Framework Core with the help of To log SQL statements, add "Microsoft.EntityFrameworkCore.Database.Command": "Information" to the appsettings.Development.json file.
I examined all the features and files those are told to do then.
When I reached at the Create page model, it says to examine and make some neccesary changes for Pages/Echanges/Create.cshtml.cs
Now, Its an interesting things to do for me is seeded the database.
I opened up a new class named SeedData in the Models folder and make changes which are being said.
I, along with that given values to my properties and seeded the data.
I also replace then some code in Program.cs which called "Adding the seed initializer"
These also needed to add namespace packages, and using statement which ensures the context is disposed. 
Before seeing the seeded databse records, it needs to delete previous records from the app and closing and restart it again.

