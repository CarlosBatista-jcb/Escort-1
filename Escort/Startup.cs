using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Escort.Startup))]
namespace Escort
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
