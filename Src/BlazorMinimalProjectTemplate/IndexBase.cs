using Microsoft.AspNetCore.Blazor.Components;

namespace $safeprojectname$
{
    public class IndexBase : BlazorComponent
    {
        public string GetTextFromMethodInClass()
        {
            return "This text came from a .cs file.";
        }
    }
}