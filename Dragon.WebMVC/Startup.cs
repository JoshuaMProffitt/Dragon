using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dragon.WebMVC.Startup))]
namespace Dragon.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
