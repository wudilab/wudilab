using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventWaitHanlderTest
{
    public class Example
    {
        public EventWaitHandle clearCount = new  EventWaitHandle(false, EventResetMode.AutoReset);
        public string GetStatus()
        {
            Test t = new Test();
            t.Event += handler;
            t.triger();
            Console.WriteLine(clearCount.WaitOne(1000));
            Console.WriteLine("you will see  me after 5 seconds");
            return "return after 5 seconds";
        }

        private void handler(object sender, EventArgs evetnArgs)
        {
            clearCount.Set();
        }
    }
}
