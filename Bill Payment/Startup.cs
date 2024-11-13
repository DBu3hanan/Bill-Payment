using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bill_Payment.Startup))]
namespace Bill_Payment
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
