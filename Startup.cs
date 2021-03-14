using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidly_mvc.Startup))]
namespace vidly_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
