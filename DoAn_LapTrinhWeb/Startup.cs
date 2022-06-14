using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DoAn_LapTrinhWeb.App_Start.Startup))]
namespace DoAn_LapTrinhWeb.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
