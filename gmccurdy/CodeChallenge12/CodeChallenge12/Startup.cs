using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeChallenge12.Startup))]
namespace CodeChallenge12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
