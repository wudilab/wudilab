using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winrtTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Example e = new Example();

            Console.WriteLine("Start ...");

            Console.WriteLine(e.GetStatus(""));

        }
    }
}
