using Microsoft.Owin;
using Owin;
using System.Collections.Generic;
[assembly: OwinStartupAttribute(typeof(PracticeWebApp.Startup))]
namespace PracticeWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
