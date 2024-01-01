using Assignment5.ViewComponents;
using Microsoft.AspNetCore.Builder;

namespace Assignment5
{
    public class Startup
    {
        public void ConfigureServices (IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<SimpleViewComponent>();

        }
        public void Configure(IApplicationBuilder app)
        {
            /*app.UseMvc(routes => {
                routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
            });*/
        }

    }
}
