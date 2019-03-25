using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudApplication.Startup))]
namespace CrudApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
