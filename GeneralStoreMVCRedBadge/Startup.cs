using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeneralStoreMVCRedBadge.Startup))]
namespace GeneralStoreMVCRedBadge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
