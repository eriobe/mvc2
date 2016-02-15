using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(informator.Startup))]
namespace informator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
