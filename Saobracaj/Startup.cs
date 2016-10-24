using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Saobracaj.Startup))]
namespace Saobracaj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
