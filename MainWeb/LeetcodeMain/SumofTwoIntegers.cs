using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeMain
{
    public class SumofTwoIntegers
    {
        public int GetSum(int a, int b)
        {
            int sum = a;
            int carry = b;

            while (carry != 0)
            {
                int tmps = sum;

                sum = tmps ^ carry;
                carry = (tmps & carry) << 1;
            }

            return sum;
        }
    }
}
