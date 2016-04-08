using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeCampOnGit.Startup))]
namespace CodeCampOnGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
