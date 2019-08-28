# ReactNetCore


## Template Setup Instructions: Visual Studio 2019 Mac

## Create React Project from Template 
1. Select File > New Solution
2. Select .NET Core > App > React.js > Next
3. Target Framework of .NET Core 2.2 > Next
4. Name the project (ex. MovieApp), and then select Create.

## Add NUnit for Unit Testing
1. In project, MovieApp(master), locate the Dependancies folder
2. Right click on Dependancies folder, select Add Packages
3. Search for Nunit and add the package

## Create Testing Project
1. Right Click on MovieApp(master) -> Select -> Add New Project
2. Select .NET Core > Tests > NUnit Test Project C# > Next.
3. Target Framework of .NET Core 2.2 > Next
4.  Name the project (ex. MovieAppTest), and then select Create.

## Link Test Project to Main Project
1. In project (ex. MovieAppTests) -> Right click on Dependancies folder -> Select -> Edit references
2. Click on Projects tab -> Select project(MovieApp) ->  click Ok.

## Create a Unit Test
- WIP

## Add Typscript to project:
[Blog To Reference ](https://jonhilton.net/new-aspnet-core-react-project/)

The lastest version of reacts-scripts will support typescript
1. In the Client App folder, verify react-scripts verision by running `npm list react-scripts`
2. Upgrade react scripts to 2.x.x version which supports typscripts, `npm update react-scripts -latest`
3. While at it, do an `npm update` of packages used in the project.
3. Remove node_modules, package-lock.json
4. Remove all eslint references in package.json
5. In terminal `npm install`
6. Restart the project to troubleshoot any issues.
7. Add Typscript to projext, run `npm add typescript @types/node @types/react @types/react-dom @types/jest`
8. change App.js to App.tsx , you should get a reference error
9. Run `npm add @types/react-router` to resolve error

## Add Postgres Database:
- In the main project directory (MovieApp), install postgres, run `dotnet add package Microsoft.EntityFrameworkCore.Npgsql`
- Create a DBcontext file (ex. MvcMovieContext.cs) and Add below code:
    ```
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Database=my_database;Host=localhost;Port=5432");
    ```
- Add below code`Startup.cs`
    ```
        services.AddEntityFrameworkNpgsql()
        .AddDbContext<MvcMovieContext>()
        .BuildServiceProvider();

    ```
- 

## Tutorial References
- [Create a web app with ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-3.0)
- [NUnit](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit)
- [Postgres/Npgsql](http://www.npgsql.org/efcore/index.html)
- [Typescript for React](https://jonhilton.net/new-aspnet-core-react-project/)
- [Entity Framework]()
