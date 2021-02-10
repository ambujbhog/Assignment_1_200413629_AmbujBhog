using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_1_200413629_AmbujBhog.Startup))]
namespace Assignment_1_200413629_AmbujBhog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
