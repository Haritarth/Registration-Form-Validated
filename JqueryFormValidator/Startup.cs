using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JqueryFormValidator.Startup))]
namespace JqueryFormValidator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
