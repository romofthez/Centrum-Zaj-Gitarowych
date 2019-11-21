using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentrumZajęćGitarowych.Startup))]
namespace CentrumZajęćGitarowych
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
