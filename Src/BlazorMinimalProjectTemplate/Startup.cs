using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorMinimalProjectTemplate
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
        }

        public void Configure(IComponentsApplicationBuilder componentsApplicationBuilder)
        {
            componentsApplicationBuilder.AddComponent<MyApp>("myApp");
        }
    }
}
