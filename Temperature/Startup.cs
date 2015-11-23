using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Temperature.Startup))]
namespace Temperature
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
