# Animal Shelter API Solution
<div align="center">
<img src="https://github.com/Dave-Sterry.png" width="200px" height="auto">
</div>

### A C# website by David Sterry
Initialized on 01/22/21
Last updated on 01/22/21

## **Project Description**
An API that allows users to GET, POST, PUT, and DELETE listings for Cats and Dogs at an Animal Shelter 

## **User Stories**

As a user, I want to GET and POST Dogs and Cats.
As a user, I want to GET Dogs and Cats by id.
As a user, I want to PUT and DELETE Dogs and Cats from the shelter.

## **Required for Use**
* C# and .Net Core installed on your local machine. Download .Net Core [Here](https://dotnet.microsoft.com/download) Follow the instructions to install on your machine
* Console/Terminal access.
* Code Editor like VSCode download [Here](https://code.visualstudio.com/) Follow the instructions to install on your machine
* MySQL Community Server download [Here](https://dev.mysql.com/downloads/mysql/) Follow the instructions to install on your machine
* MySQL Workbench [Here](https://www.mysql.com/products/workbench/) Follow the instructions to install on your machine
* Postman download [Here](https://www.postman.com/downloads/)Follow the instructions to set up an account and install on your machine
* Swashbuckle follow the setup tutorial [here](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-2.2&tabs=visual-studio-code)
* An internet browser of your choice; I prefer Chrome


## **How to get this project**

### Download from Github:
1. Use the browser navigate to my GitHub page [respository](https://github.com/Dave-Sterry/PortlandAnimalShelter.Solution
2. Click the Green **Code** button and select **Download Zip**

### Alternatively clone from Github via Gitbash:
1. In your terminal, navigate to the folder where you would like to clone the project too
2. Clone this repo to your chosen folder using "git clone https://github.com/Dave-Sterry/PortlandAnimalShelter.Solution in terminal


## **Installation Instructions**
### **Setup Database Connection**

AppSettings
* This project requires an AppSettings file. Create your `appsettings.json` file in the main `TravelAPI` directory.
* Format your `appsettings.json` file as follows including your unique password that was created at MySqlWorkbench installation:

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=david_sterry3;uid=root;pwd=epicodus;"
  }
}

```
* Update the Server, Port, and User ID as needed with your own

Import Database using Entity Framework Core
* Navigate to TravelAPI.Solution/TravelAPI and type `dotnet ef database update` into the terminal. This will update the existing migrations

Launch the API
1. Navigate to AnimalShelter.Solution/AnimalShelter and type `dotnet run` into the terminal.

## API Documentation
Explore our API endpoints with Swagger Documentation:
* After launching the API, use a browser to navigate to `http://localhost:5000/swagger/`

## Endpoints
Base URL: `https://localhost:5000`

Http Request Structure

```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```
### Example Query
```
https://localhost:5000/api/dogs/2
```
### Sample JSON Response
```
{
    "Id": 2,
    "Name": "Rosie",
    "Age": 12
}
```
### Cats
Access information on Cats in the shelter

```
GET /api/cats
GET /api/2.0/cats
POST /api/2.0/cats
GET /api/2.0/cats{id}
PUT /api/2.0/cats{id}
DELETE /api/2.0/cats{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| Name | string | none | true | Return matches by cat name.
| Age | int | none | true | Return age of cat|

### Example Query
```
https://localhost:5000/api/cats/?name=Neptune 
```
### Sample JSON Response
```
{
    "Id": 1,
    "Name": "Neptune",
    "Age": 3
}
```
..........................................................................................

### Dogs 
Access information on Dogs in the Shelter

```
GET /api/cats
GET /api/2.0/dogs
POST /api/2.0/dogs
GET /api/2.0/dogs{id}
PUT /api/2.0/dogs{id}
DELETE /api/2.0/dogs{id}
```
#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| Name | string | none | true | Return matches by dog name.
| Age | int | none | true | Return age of dog|

### Example Query 
```
http://localhost:5000/api/dogs/?name=Kiva
```
### Sample JSON Response 
```
{
    "Id: 2, 
    "Name": "Kiva",
    "Age": 11
}
```
## **Known Bugs**
No known bugs at this time

## **Technology Used**
* C# 7.3
* .NET Core 2.2
* Entity
* Git
* MySQL
* dotnet script, REPL
* Identity
* Postman
* Swagger
* Swashbuckle

<table>
  <tr>
    <th>Author</th>
    <th>GitHub Profile</th>
    <th>Contact Email</th>
  </tr>
  <tr>
    <td>David Sterry</td>
    <td>https://github.com/Dave-Sterry</td>
    <td>sterry.david@gmail.com</td>
  </tr>
  </table>

  ## **Contact**
If you have any issues during installation delete both the bin and obj folders and follow the set up instructions again. Please contact me at sterry.david@gmail.com for help. 

## **License**

This project is licensed under **MIT 2.0**

Copyright © 2020 David Sterry