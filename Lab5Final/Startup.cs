using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab5Final.Startup))]
namespace Lab5Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
