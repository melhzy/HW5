using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HW5_WCFService.Startup))]
namespace HW5_WCFService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
