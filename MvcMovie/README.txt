2024-01-17
1800
I created new ASP.NET Core MVC web application (.Net 8) with no authentication and gave MVcMovie as the project name. 
Then there was webpage showing Welcome in the application. Then in the part 2 I have added a new Controller (MVC Controller-Empty) to the project.
I gave HelloWorldController to the newly created controller. Then I have changed the welcome code in the way that it gives output as 
"Hello Sharath, ID:"
Then I have created a folder in the Views section named Helloworld and then added Index.cshtml view (Razor view-Empty) and Welcome.cshtml view
(Razor view-Empty) and made changes in such a way that the web page displays Hello Sharath the number of times we have given the ID value.


2024-01-18
1415
I created new model under the models section named Movie.cs. And added the neccessary code into the Movie.cs model. Then added the new scaffolded
item (MVC Controller with views, using Entity Framework). Gave the Model Class as Movie(MvcMovie.Models), added DbContext Class with 
MvcMovie.Data.MvcMovieContext and Database provider as SQL server and performed initial migration using the commands Add-Migration InitialCreate
and Update-Database.

2024-01-25
1000
There was newly created folder under Migrations with timestamp "20240125025312_InitialCreate.cs"
There there was a creation of database table in the app showing Title, Release date, Genre and price. Then I visited the SQL server object explorer 
in view tab in menu and i have viewed the data in database which is null. Then I have created a SeedData class under models folder and added the
necessary code which is required to add the data to database table into the SeedData class and then run the code and there was available of data 
in table. And the database table with 4 entries is ready and I need to work further with it.
Database with 4 films have been created where it displays Title, Release Data, Genre and Price.
The I added search column which is used to find the required film and filter it. Then I checked it with entering the Url, it was success and then
code from "searchString" to "id" and run the code and it was success.
Then created new class named "MovieGenreViewModel" and added the necessary code into it. Whenever I run the code it was succesful and search option
was visible and searching of the movies was successful.


2024-01-31
1800
Next I have tried to add a new field to the web page named rating and I was successful in adding it. Firstly I have added Rating property to the
Movie.cs class. Then I have added tha Rating property in Bind attribute in MovieController.cs for both create and edit actions. Further made
made changes to Index.cshtml adding neccessary liness to the code to add the Rating field. I then added a new form in Create.cshtml and Edit.cshtml.
Then added the Rating field for each movie added in the Seed.cs. Then added the migration named Rating and updated the database. Then the rating field
has been added to the page and I can even edit the rating field. 
Then added validation rules to the movie model. Some of the validation rules are "The field title must be a minimum length of 3 and maximum length of 60".
"The field rating must match the regular expression '^[A-Z]+[a-zA-Z0-9""'\s-]*$' etc. So that the fields should not be empty and need to be exact datatype
mentioned.


2024-02-08
1330
And the final application viewing movies with the title, release date, genre, price and rating is been successfully created.
Then I have examined the details and delete method in the application. I have looked at the delete code which is placed in the MovieController.cs class.


It was quite interesting to learn the tutorial to create a web application. I have faced lot of troubles while doing this but I have solved it using various
resources. This tutorial will be helping me to create a new web application in the future.