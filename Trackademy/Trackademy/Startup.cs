using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trackademy.Startup))]
namespace Trackademy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
