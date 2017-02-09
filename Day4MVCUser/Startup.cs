using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day4MVCUser.Startup))]
namespace Day4MVCUser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
