# TravelApi.Solution

#### By _**Joseph Jack** && **Matt Wilkinson**_  

#### _A project to introduce practices for building a Web Api and a Client App that consumes it. C#/.NET Core 5.0. Users interact with the Api and database through the localhost on the client app or through Swagger UI. From there users can see lists of destinations and ratings. Additional functionality to edit, post, delete listings. Users must register and login using JWT Tokens to acccess site._

---


## Technologies Used

* [C#](https://en.wikipedia.org/wiki/C_Sharp_(programming_language))
* [.NET](https://dotnet.microsoft.com/en-us/)
* [Entity Framework](https://docs.microsoft.com/en-us/ef/)
* [SQL Workbench](https://www.mysql.com/products/workbench/)
* [MVC](https://developer.mozilla.org/en-US/docs/Glossary/MVC)
* [HTML](https://en.wikipedia.org/wiki/HTML)
* [Swagger](https://swagger.io/)
* [Postman](https://learning.postman.com/docs/getting-started/introduction/)


---
## Setup and Installation Requirements
This Setup assumes you have GitBash and MySQL Workbench pre-installed. 
<br><small>If you do not have one or both installed, please begin with that setup below. 
<br>If you _do_ have both installed, move onto "initial setup".</small>

<details>
<summary><strong>GitBash and MySQL Workbench Setup</strong></summary>
<ol>
<li>https://git-scm.com/download/  
<li>Download Git and follow the setup wizard. 
<li>https://dev.mysql.com/downloads/workbench/     
<li>Download MySQL Workbench
<li>Follow the setup wizard & create a localhost server on port 3306.
<li>Keep track of your username and password, this will be used in the connection steps of "**SQL Workbench Configuration**"  
</details>
<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/Josephwjack/TravelApi.Solution
<li>Open a terminal and navigate to your Desktop with <strong>cd</strong> command
<li>Run,   
<strong>$ git clone https://github.com/Josephwjack/TravelApi.Solution</strong>
<li>In the terminal, navigate into the root directory of the cloned project folder "TravelApi.Solution".
<li>Navigate to the projects root directory, "TravelApi".
<li>Move onto "SQL Workbench Configuration" instructions below to build the necessary database.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "TravelApi" directory  
   <pre>TravelApi.Solution
   └── TravelApi
    └── appsetting.json</pre>
<li> Insert the following code: <br>

<pre>{
  "AppSettings": {
    "Secret": "[YOUR-TOKEN-HERE]"
    },
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=travel_api;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*Note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**Note: you must include your username in the code block section labeled "YOUR-USERNAME-HERE".</small><br>
<small>***Note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>

<li>In root directory of project folder "TravelApi", run  
<strong>$ dotnet ef migrations add restoreDatabase</strong>
<li>Then run <strong>$ dotnet ef database update</strong>

<ol> 
  <li>Open SQL Workbench.
  <li>Navigate to "travel_api" schema.
  <li>Click the drop down, select "Tables" drop down.
  <li>Verify the tables, you should see <strong>destinations</strong> and <strong>user</strong>
  
</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>TravelApi.Solution
   └── <strong>TravelApi</strong></pre>

Run ```$ dotnet restore``` in the terminal.<br>
Run ```$ dotnet run``` in the terminal.
</details>
<hr/>

## _To Use Swagger UI_
Add the following to the url of your local host:
`` http://localhost:5000/swagger``
* Keep this programs live server running while using the client side live server to achieve full functionality of the project.
<hr/>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Cross-version performance is neither implied nor guaranteed, your actual mileage may vary.

---

## _Specs_

|Behavior|Input|Output|
|-----|-----|-----|
|User can register an account in Swagger|"username": "test" , "password":  "test"|"api/Authenticate/register"|
|User can log in and generate bearer token on Swagger UI|Username and password from above|"/api/Authenticate/login"|
|User can post, edit, or delete entries once logged in|PUT, POST, or DELETE|"api/Destinations/{id}"|



---
## _Known Bugs_

* _User interface allowing users to log in and log out is only on swagger, not the client side application._
* _Have not established roles in authorization to prevent users from deleting entries that are not theirs._

## _Legal_

_Copyright (c) 