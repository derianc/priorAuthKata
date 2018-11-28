# priorAuthKata
Author:
  Derian Conteh-Morgan, 11/28/18
  
The included solution contains 5 projects
  PriorAuth.Web.Api
  PriorAuth.Web.Data
  PriorAuth.Web.Repositories
  PriorAuth.Web.Services
  PriorAuth.Web.Tests


Getting Started:
  Clone GitHub Repository (https://github.com/derianc/priorAuthKata)
  Open Solution (Visual Studio 2017)
  Open Test Project (PriorAuth.Web.Tests)
  Run all tests.
  Set PriorAuth.Web.Api as startup project
  Run Api Project
  Using Swagger as a cheap UI interface
  
The Code:
  Interfaces:
    IUserService - defines the service methods associated with user object
    IUserRepository - defines repository methods associated with user object.  This example is using a cached list as a fake database
    
  Extension Methods:
    UserRepositoryExtensions - extension methods for acting on user object
    
  Test Methods
    GetAllUsers_TestPassed - ensure user repository contains at least 1 user
    GetAllUsersEmptyList_TestPassed - test for empty user list
    GetUserById_TestPassed - ensure user repository contains specified user
