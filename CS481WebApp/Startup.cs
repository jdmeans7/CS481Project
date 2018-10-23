using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS481WebApp.Startup))]
namespace CS481WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
