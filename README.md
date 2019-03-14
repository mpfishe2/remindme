# remindme
  
Notes on Build Process
  
## Set-Up for Build
  
1. Check https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-2.2&tabs=visual-studio-code#prerequisites to ensure that all the requirements are met
2. Open command prompt
3. Run `dotnet new -i Microsoft.DotNet.Web.ProjectTemplates.1.x::1.0.0-*` to get the templates for the mvc 
4. Run dotnet new mvc -o remindme
5. code -r remindme
  
## In the Files
  
### Adding a Page to the MVC
  
1. Go to Controllers\HomeController.cs
2. Add a new IActionResult method like below:
```csharp
        public IActionResult Tasks()
        {
            return View();
        }
```
3. Then go to Views\Home and add a new CSHTML file
4. Go to Views\Shared and add a Navigation Bar Link to the new page with the following code:
```html
<li class="nav-item">
    <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Tasks">My Tasks</a>
</li>
```
- Make sure the asp-action lines up with the name of the method we established in HomeController.cs in Step 2
