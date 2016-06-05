using MainLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            NMRegister register = new NMRegister();
            register.MapCapsLockToControlWindows8();

            Console.WriteLine("Write to Register Successfully");
        }
    }
}
