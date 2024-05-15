using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WIngtip.Startup))]
namespace WIngtip
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
