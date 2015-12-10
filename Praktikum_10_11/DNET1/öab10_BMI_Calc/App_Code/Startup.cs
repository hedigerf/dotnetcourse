using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(öab10_BMI_Calc.Startup))]
namespace öab10_BMI_Calc
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
