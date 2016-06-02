using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jenkins_sonar_csharp.Startup))]
namespace jenkins_sonar_csharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
