using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gachMenLongKhanh.Startup))]
namespace gachMenLongKhanh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
