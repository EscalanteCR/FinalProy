using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalProy.Startup))]
namespace FinalProy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
