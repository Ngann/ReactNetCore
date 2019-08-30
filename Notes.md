Controllers:
- Every public method in a controller is callable as an HTTP endpoint
```
public IActionResult Index()
{
    return View();
}
```
- controller methods/ also known as action methods, returns an IActionResult(or a class derived from ActionResult)
-The routing format is set in the Configure method in Startup.cs file.
```
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});
```
- /[Controller]/[ActionName]/[Parameters]
- index method is called by default
- MVC model binding system automatically maps the parameters in your methods. Therefore is a method takes an id, it will match the route parameter id

Database Context:

ASP.NET Core is built with dependency injection (DI). Services (such as the EF Core DB context) must be registered with DI during application startup(Startup.Cs). 


The Startup Class:
- includes a ConfigureServices method to configure/register the app's service and consume by across the app via dependency injections or applicationservices
- incldes a configure methos to create the app's reuqest processing pipline
- the ConfigureServices and Confiugure is called by ASP.Net Core at run time whent he app starts.
- Statup class is called when the webhost is built in the Program class

The program class:
- Host provides services that are available to the startup class
- 