using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prophets.Startup))]
namespace Prophets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
