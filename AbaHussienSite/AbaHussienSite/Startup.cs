using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AbaHussienSite.Startup))]
namespace AbaHussienSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
