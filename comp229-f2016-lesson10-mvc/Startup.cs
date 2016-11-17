using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comp229_f2016_lesson10_mvc.Startup))]
namespace comp229_f2016_lesson10_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
