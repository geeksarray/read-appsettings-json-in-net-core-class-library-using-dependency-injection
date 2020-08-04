# read-appsettings-json-in-net-core-class-library-using-dependency-injection

This blog post explains in .net core class library application how to read configuration settings from the web application's appsettings.json file by injecting dependency of IConfiguration interface.

The class library does not have a configuration file by default. Dependency injection is already part of .Net Core, you will have to register your dependencies in the ConfigureService method of Startup.cs file.


