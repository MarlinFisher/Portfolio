using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Portfolio.UI.Startup))]
namespace Portfolio.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
