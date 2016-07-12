using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeMain
{
    /// <summary>
    /// Put Question URL: 
    /// </summary>
    public class ProductofArrayExceptSelf238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] p = new int[nums.Length];

            p[0] = 1;

            for(int i=1;i<nums.Length;i++)
            {
                p[i] = p[i - 1] * nums[i - 1];
            }

            long temp = 1;

            for(int i=nums.Length-2;i>=0;i--)
            {
                p[i] = p[i + 1] * nums[i + 1];
            }

            return p;
        }
    }
}
