using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tonyCM.Startup))]
namespace tonyCM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
