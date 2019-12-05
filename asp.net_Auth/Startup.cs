using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp.net_Auth.Startup))]
namespace asp.net_Auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
