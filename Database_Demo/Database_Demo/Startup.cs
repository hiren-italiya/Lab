using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Database_Demo.Startup))]
namespace Database_Demo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
