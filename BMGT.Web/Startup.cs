using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BMGT.Web.Startup))]
namespace BMGT.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
