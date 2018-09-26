using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorMinimalProjectTemplate
{
    public class IndexBase : BlazorComponent
    {
        public string GetTextFromMethodInClass()
        {
            return "The source for this text was external C# code in a .CS file";
        }
    }
}