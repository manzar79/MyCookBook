using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyCookbook.Startup))]
namespace MyCookbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
