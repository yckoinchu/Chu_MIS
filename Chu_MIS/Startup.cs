using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chu_MIS.Startup))]
namespace Chu_MIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
