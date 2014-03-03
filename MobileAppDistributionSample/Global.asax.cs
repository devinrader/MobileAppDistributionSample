using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.WebPages;

namespace MobileAppDistributionSample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("iPhone")
            {
                ContextCondition = (context => context.GetOverriddenUserAgent().IndexOf
                    ("iPhone", StringComparison.OrdinalIgnoreCase) >= 0)
            });

            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("Android")
            {
                ContextCondition = (context => context.GetOverriddenUserAgent().IndexOf
                    ("Android", StringComparison.OrdinalIgnoreCase) >= 0)
            });

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            BundleMobileConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
