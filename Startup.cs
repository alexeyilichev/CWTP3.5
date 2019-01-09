using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CW.Startup))]
namespace CW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
