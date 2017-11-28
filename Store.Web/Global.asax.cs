using Store.Data;
using Store.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;

namespace Store.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            System.Data.Entity.Database.SetInitializer(new CreateDatabaseIfNotExists<StoreEntities>());

            // Init database
            System.Data.Entity.Database.SetInitializer(new StoreSeedData());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Autofac and Automapper configurations
            Bootstrapper.Run();
        }
    }
}
