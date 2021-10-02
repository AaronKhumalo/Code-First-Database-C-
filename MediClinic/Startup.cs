using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediClinic.Startup))]
namespace MediClinic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
