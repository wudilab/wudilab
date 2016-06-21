using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EventWaitHanlderTest
{
    public class Test
    {
        public EventHandler Event = null;

        public void triger()
        {
            Timer timer = new Timer(5000);
            timer.Elapsed += OnTimedEvent;
            timer.Start();
            Console.Write("timer start ");
            
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (Event != null)
            {
                Event(null, null);
            }
        }
    }
}
