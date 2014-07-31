using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FuelTrackerWebUI.Startup))]
namespace FuelTrackerWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
