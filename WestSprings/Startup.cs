using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WestSprings.Startup))]
namespace WestSprings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
