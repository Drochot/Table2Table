using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Table2Table.Startup))]
namespace Table2Table
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
