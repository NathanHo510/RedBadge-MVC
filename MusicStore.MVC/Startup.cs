using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicStore.MVC.Startup))]
namespace MusicStore.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
