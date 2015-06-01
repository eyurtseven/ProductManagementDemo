using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductManagement.Web.Startup))]
namespace ProductManagement.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
