using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeMain
{
    /// <summary>
    /// Question URL: https://leetcode.com/problems/product-of-array-except-self/
    /// </summary>
    public class ProductofArrayExceptSelf238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] p = new int[nums.Length];
            int temp = 1;

            p[0] = 1;

            for(int i=1;i<nums.Length;i++)
            {
                p[i] = p[i - 1] * nums[i - 1];
            }

            temp = 1;

            for(int i=nums.Length-2;i>=0;i--)
            {
                temp *= nums[i + 1];
                p[i] *= temp;
            }

            return p;
        }
    }
}
