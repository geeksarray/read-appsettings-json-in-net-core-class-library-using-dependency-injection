# read-appsettings-json-in-net-core-class-library-using-dependency-injection

This blog post explains in .net core class library application how to read configuration settings from the web application's appsettings.json file by injecting dependency of IConfiguration interface.

The class library does not have a configuration file by default. Dependency injection is already part of .Net Core, you will have to register your dependencies in the ConfigureService method of Startup.cs file.

1. **GeeksApp** - is ASP.NET MVC application having required application settings stored in appsettings.json.
1. **GeeksConfiguration** - is a C# dot net core class library application used like DAL. This reads appsettings using dependency injection stored in MVC application.

 For more details [click here](https://geeksarray.com/blog/read-appsettings-json-in-net-core-class-library-using-dependency-injection)
