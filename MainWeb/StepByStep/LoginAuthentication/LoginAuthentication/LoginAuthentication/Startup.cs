using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginAuthentication.Startup))]
namespace LoginAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
