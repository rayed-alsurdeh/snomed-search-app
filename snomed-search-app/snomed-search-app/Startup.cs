using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(snomed_search_app.Startup))]
namespace snomed_search_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
