using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(coffeeshoppe.Startup))]
namespace coffeeshoppe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
