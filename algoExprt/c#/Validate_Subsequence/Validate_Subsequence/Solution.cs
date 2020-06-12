using System;
using System.Collections.Generic;
using System.Text;

namespace Two_Number_Sum
{
    public class Solution
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {


            Dictionary<int, int> check = new Dictionary<int, int>();
            bool isOverlap;
            foreach (int elem in array)
            {
                isOverlap = check.TryAdd(elem, 1);
                if (!isOverlap)
                {
                    check[elem]++;
                }
            }

            foreach (int elem in sequence)
            {
                if (check.ContainsKey(elem))
                {
                    if (check[elem] < 1)
                    {
                        return false;
                    }
                    else
                    {
                        check[elem]--;
                    }
                }
                else
                {
                    return false;
                }

            }
            return true;

        }

    }
}
