using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace VB_inventory
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        public class BundleConfig
        {
            public static void RegisterBundles(BundleCollection bundles)
            {
                //BundleTable.EnableOptimizations = true;
                #region "signup"
                bundles.Add(new ScriptBundle("~/signup.js")
                       .Include("~/scripts/jquery-3.4.1.min.js")
                       .Include("~/scripts/popper.min.js")
                       .Include("~/scripts/bootstrap.min.js")
                     );
                #endregion
            }

        }
    }
}
