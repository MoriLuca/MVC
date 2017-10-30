using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Autenticazione.Startup))]
namespace Autenticazione
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
