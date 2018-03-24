using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webapi_WebForms.Startup))]
namespace Webapi_WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
