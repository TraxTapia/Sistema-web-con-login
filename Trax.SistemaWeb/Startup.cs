using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trax.SistemaWeb.Startup))]
namespace Trax.SistemaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
