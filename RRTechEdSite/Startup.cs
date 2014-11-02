using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RRTechEdSite.Startup))]
namespace RRTechEdSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
