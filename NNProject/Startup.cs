using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NNProject.Startup))]
namespace NNProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
