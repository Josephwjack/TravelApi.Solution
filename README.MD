# TravelApi.Solution

#### By _**Joseph Jack** && **Matt Wilkinson**_  

#### _Pierre's Sweet and Savory is an application that allows the user to browse treats and flavors on Pierre's site. However users must register and login to have any create or editing ability._

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

## To Use Swagger UI
Add the following to the url of your local host:
`` http://localhost:5000/swagger``
<hr/>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Cross-version performance is neither implied nor guaranteed, your actual mileage may vary.

---
## Known Bugs

* _No known issues_

## Legal

_Copyright (c) 