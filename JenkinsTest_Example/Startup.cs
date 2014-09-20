using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsTest_Example.Startup))]
namespace JenkinsTest_Example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
