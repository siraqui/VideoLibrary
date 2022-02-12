using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidlib_v2.Startup))]
namespace Vidlib_v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
