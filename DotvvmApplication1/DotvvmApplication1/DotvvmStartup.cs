using DotVVM.Framework.Configuration;
using DotVVM.Framework.ResourceManagement;
using DotVVM.Framework.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace DotvvmApplication1
{
    public class DotvvmStartup : IDotvvmStartup, IDotvvmServiceConfigurator
    {
        // For more information about this class, visit https://dotvvm.com/docs/tutorials/basics-project-structure
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            ConfigureRoutes(config, applicationPath);
            ConfigureControls(config, applicationPath);
            ConfigureResources(config, applicationPath);
        }

        private void ConfigureRoutes(DotvvmConfiguration config, string applicationPath)
        {
            config.RouteTable.Add("Default", "", "Views/Default.dothtml");
            config.RouteTable.AutoDiscoverRoutes(new DefaultRouteStrategy(config));    
        }

        private void ConfigureControls(DotvvmConfiguration config, string applicationPath)
        {
            // register code-only controls and markup controls
        }

        private void ConfigureResources(DotvvmConfiguration config, string applicationPath)
        {
            // ATTENSION: NOT WORKING FOR ME :-(. SOLVED IN .dotmaster
            // Note that the 'jquery' resource is registered in DotVVM and points to official jQuery CDN.
            // We have jQuery in our application, so we have to change its URL
            //config.Resources.Register("jquery", new ScriptResource()
            //{
            //    Location = new FileResourceLocation("/wwwroot/Scripts/jquery-3.0.0.min.js")
            //});

            //// register bootstrap
            //config.Resources.Register("bootstrap", new ScriptResource()
            //{
            //    Location = new FileResourceLocation("/wwwroot/Scripts/bootstrap.min.js"),
            //    Dependencies = new[] { "jquery" }
            //});

            //// register raphael
            //config.Resources.Register("raphael", new ScriptResource()
            //{
            //    Location = new FileResourceLocation("/wwwroot/Scripts/raphael-min.js"),
            //    Dependencies = new[] { "jquery" }
            //});

            //// register morris
            //config.Resources.Register("morris", new ScriptResource()
            //{
            //    Location = new FileResourceLocation("/wwwroot/Scripts/morris.min.js"),
            //    Dependencies = new[] { "raphael" }
            //});

            config.Resources.Register("dotvvm-morris", new ScriptResource()
            {
                //Url = "~/Scripts/dotvvm-morris.js",
                Location = new FileResourceLocation("~/wwwroot/Scripts/dotvvm-morris.js"),
                Dependencies = new[] { "dotvvm" }
            });

        }

        public void ConfigureServices(IDotvvmServiceCollection options)
        {
            options.AddDefaultTempStorages("temp");
		}
    }
}
