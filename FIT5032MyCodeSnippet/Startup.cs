using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT5032MyCodeSnippet.Startup))]
namespace FIT5032MyCodeSnippet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
