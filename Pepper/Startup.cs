using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pepper.Startup))]
namespace Pepper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
