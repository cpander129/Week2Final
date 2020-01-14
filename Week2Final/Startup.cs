using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week2Final.Startup))]
namespace Week2Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
