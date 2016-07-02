using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeMain
{
    public class MissingNumber268
    {
        public int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                    return i;
            }
            return nums.Length;
        }
    }
}
