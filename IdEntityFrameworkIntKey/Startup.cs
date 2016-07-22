using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdEntityFrameworkIntKey.Startup))]
namespace IdEntityFrameworkIntKey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
