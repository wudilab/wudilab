using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MVCMain
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            System.Diagnostics.Trace.WriteLine(System.Threading.Thread.CurrentThread.Name + " " +System.DateTime.Now + " " + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType + " " + System.Reflection.MethodBase.GetCurrentMethod().Name + " " +  " " + (new System.Diagnostics.StackFrame(0, true)).GetFileName() + " " + (new System.Diagnostics.StackFrame(0, true)).GetFileLineNumber() + " " + System.Environment.StackTrace + System.Environment.NewLine);
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
