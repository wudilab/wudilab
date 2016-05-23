using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMain.Startup))]
namespace MVCMain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
