using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoeStash.Startup))]
namespace PoeStash
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
