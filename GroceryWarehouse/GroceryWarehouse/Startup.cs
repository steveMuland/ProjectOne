using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroceryWarehouse.Startup))]
namespace GroceryWarehouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
