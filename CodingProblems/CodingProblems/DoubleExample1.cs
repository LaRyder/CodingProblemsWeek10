using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    public class DoubleExample1
    {
        public bool Check(int[] nums)
        {
            {
                for (var i = 0; i < nums.Length; i++)
                {
                    for (var k = 0; k < nums.Length; k++)
                    {
                        if (nums[i] * 2 == nums[k]) return true; 
                    }
                }
                return false;
            }
        }
    }
}
