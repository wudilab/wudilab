using System.Web;
using System.Web.Mvc;

namespace MVCMain
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            System.Diagnostics.Trace.WriteLine(System.Threading.Thread.CurrentThread.Name + " " +System.DateTime.Now + " " + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType + " " + System.Reflection.MethodBase.GetCurrentMethod().Name + " " +  " " + (new System.Diagnostics.StackFrame(0, true)).GetFileName() + " " + (new System.Diagnostics.StackFrame(0, true)).GetFileLineNumber() + " " + System.Environment.StackTrace + System.Environment.NewLine);
            filters.Add(new HandleErrorAttribute());
        }
    }
}
