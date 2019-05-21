using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kasp_1.Backend.Startup))]
namespace Kasp_1.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
