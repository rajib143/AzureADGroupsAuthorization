using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApplicationRoleBaseAuthentication.Startup))]

namespace WebApplicationRoleBaseAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            // Comment the following line to try out the multi-tenant scenario
            ConfigureAuth(app);

            // Uncomment the following line to try out the multi-tenant scenario
            // ConfigureMultitenantAuth(app);
        }
    }
}
