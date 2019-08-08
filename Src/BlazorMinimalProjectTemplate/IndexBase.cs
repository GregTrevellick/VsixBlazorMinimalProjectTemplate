using Microsoft.AspNetCore.Components;

namespace BlazorMinimalProjectTemplate
{
    public class IndexBase : ComponentBase
    {
        public string GetTextFromMethodInClass()
        {
            return "The source for this text was external C# code in a .cs file";
        }
    }
}