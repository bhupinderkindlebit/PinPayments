using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PinPayment.Startup))]
namespace PinPayment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
