using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Task14.Startup))]
namespace Task14
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
          //  ConfigureAuth(app);
        }
    }
}
