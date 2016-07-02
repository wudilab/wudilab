using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCMain
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            System.Diagnostics.Trace.WriteLine(System.Threading.Thread.CurrentThread.Name + " " +System.DateTime.Now + " " + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType + " " + System.Reflection.MethodBase.GetCurrentMethod().Name + " " +  " " + (new System.Diagnostics.StackFrame(0, true)).GetFileName() + " " + (new System.Diagnostics.StackFrame(0, true)).GetFileLineNumber() + " " + System.Environment.StackTrace + System.Environment.NewLine);
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
