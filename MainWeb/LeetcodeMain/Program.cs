using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeMain
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductofArrayExceptSelf238 s = new ProductofArrayExceptSelf238();
            int[] nums = { 1,2,3,4 };

            foreach(int n in s.ProductExceptSelf(nums))
            {
                Console.WriteLine(n+"\t");
            }

            //Console.WriteLine();
            //Console.WriteLine(s.GetSum(0, 0));
        }
    }
}
