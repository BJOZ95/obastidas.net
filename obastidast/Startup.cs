using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(obastidast.Startup))]
namespace obastidast
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
