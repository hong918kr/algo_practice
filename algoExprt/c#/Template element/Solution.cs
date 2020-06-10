using System;
using System.Collections.Generic;
using System.Text;

namespace Two_Number_Sum
{
    public class Solution
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {

            HashSet<int> nums = new HashSet<int>();
            foreach (int num in array)
            {
                int potentialMatch = targetSum - num;
                if (nums.Contains(potentialMatch))
                {
                    return new int[]{ potentialMatch, num };
                }
                else
                {
                    nums.Add(potentialMatch);
                }
            }

            return new int[0];
        }

    }
}
