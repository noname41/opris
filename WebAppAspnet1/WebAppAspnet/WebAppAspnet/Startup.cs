using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAspnet.Startup))]
namespace WebAppAspnet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
