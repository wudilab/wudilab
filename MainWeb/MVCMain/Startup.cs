using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMain.Startup))]
namespace MVCMain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            System.Diagnostics.Trace.WriteLine(System.Threading.Thread.CurrentThread.Name + " " +System.DateTime.Now + " " + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType + " " + System.Reflection.MethodBase.GetCurrentMethod().Name + " " +  " " + (new System.Diagnostics.StackFrame(0, true)).GetFileName() + " " + (new System.Diagnostics.StackFrame(0, true)).GetFileLineNumber() + " " + System.Environment.StackTrace + System.Environment.NewLine);
            ConfigureAuth(app);
        }
    }
}
