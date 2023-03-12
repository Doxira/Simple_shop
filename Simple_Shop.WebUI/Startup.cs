using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Simple_Shop.WebUI.Startup))]
namespace Simple_Shop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
