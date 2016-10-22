using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demo.folly.io.Startup))]
namespace demo.folly.io
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
