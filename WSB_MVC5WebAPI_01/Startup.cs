using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WSB_MVC5WebAPI_01.Startup))]
namespace WSB_MVC5WebAPI_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
