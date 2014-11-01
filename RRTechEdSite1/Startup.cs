using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RRTechEdSite1.Startup))]
namespace RRTechEdSite1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
