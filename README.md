# bookstore
experimental app using asp.net core 2.0's web api

**Demo on Azure**
- http://bookstore20180625092530.azurewebsites.net/index.html

**Backend**
- ASP.NET Core 2.0 Web API Template
- MySQL with Entity Framework
- Basic RESTful API for doing CRUD operations


**Frontend**
- AngularJS 1.5 with Angular Material UI
- LESS CSS framework
- npm, bower for package mangement
- grunt for task runner


**Unit Test**
- 5 XUnit tests written in C#, .NET: provided by VS2017
- If time is given, I would concentrate writing more unit tests on the controller files for doing CRUD tets.
- Also work on having the tests run automatically when new version is available for deployment (Continuous Integration)


**DevOps**
- Did not have time to work on this but if I did: 
- I would simply just install Jenkins on Aznure VM,
- listen for this github repo master branch 
- build the .net code with MSBuild
- move the built files to appropriate directories with batch scripts
- and little bit of configuration management suits the hosted server 

