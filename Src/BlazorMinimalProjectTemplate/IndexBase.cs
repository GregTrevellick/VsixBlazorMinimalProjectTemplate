using Microsoft.AspNetCore.Blazor.Components;

namespace $safeprojectname$
{
    public class IndexBase : BlazorComponent
    {
        public string GetTextFromMethodInClass()
        {
            return "This text came from a .cs file. You can also use C# files in other assemblies, and Blazor supports much Razor syntax, routing and more - see the blazor.net website for more details.";
        }
    }
}