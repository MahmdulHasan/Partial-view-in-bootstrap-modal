using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PopUp.Startup))]
namespace PopUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
