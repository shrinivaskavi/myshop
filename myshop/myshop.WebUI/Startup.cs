using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myshop.WebUI.Startup))]
namespace myshop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
