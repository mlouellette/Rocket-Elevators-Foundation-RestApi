# Rocket-Elevators-Foundation-RestApi

# Description
Rocket Elevators Website using the Ruby on rails framework. This website is connected to mysql database, user login and quote form connected. 
The administrator of the page have access to a back office page that displays the employees section and quote form input results. We implemented some API's that retrieve status of batteries, column, elevators, Interventions or that allows to change the status.

Using C# .NET RESTAPI

# Command to use

First, we use a lot of gem pluggins, so you need to type `bundle install` to download packages. It might not work because of previous tries, so you can try `bundle update`. 

Launch the server with : `rails s`or `rails server`.
After that go on `http://localhost:3000/`to see the result.

To check our databases and tables on the terminal you can go on the sql console with : `mysql -u root`.
To display databases type `SHOW DATABASES;`, and `USE <database_name>;` and now you just need to display the table you want with : `DESCRIBE <table_name>`.

# .NET Samples

To experiment our API's endpoint you can run `dotnet run` and in your browser or in Postman try some of these addresses :

* GET : `https://localhost:7234/api/interventions`to retrieve interventions status
* PUT : `https://localhost:7234/api/interventions/1/Status/InProgress` to change the status from 'Pending' to InProgress and the tart time will match the time now.
* PUT : `https://localhost:7234/api/interventions/1/Status/Completed` to change the status from 'InProgress' to Completed and the End time will match the time now.

(If you have no result it could be possible that in your database you are not meeting the conditions)

# Video's Link





