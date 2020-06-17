using System;
using System.Collections.Generic;
using System.Text;

namespace Three_Number_Sum
{
    public class Solution
    {
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {

            Array.Sort(array);


            int start = 0;           
            List<int[]> ret = new List<int[]>();

            while (start < array.Length)
            {
                int left = start + 1;
                int right = array.Length - 1;
                while (left < right)
                {
                    int compared = array[start] + array[left] + array[right];
                    if (compared == targetSum)
                    {
                        ret.Add(new int[] { array[start], array[left], array[right] });
                        ++left;
                        --right;
                        continue;
                    }
                    else if (compared < targetSum)
                    {
                        ++left;
                    }
                    else
                    {
                        --right;
                    }
                }
                ++start;
            }
            return ret;
        }
    }
    
}
