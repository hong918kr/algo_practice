using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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

        public static bool IsValidSubsequence_sol_1(List<int> array, List<int> sequence)
        {
            int arrIdx = 0;
            int seqIdx = 0;
            while (arrIdx < array.Count && seqIdx < sequence.Count)
            {
                if (array[arrIdx] == sequence[seqIdx])
                {
                    seqIdx++;
                }
                arrIdx++;
            }
            return seqIdx == sequence.Count;


        }

        public static bool IsValidSubsequence_sol_2(List<int> array, List<int> sequence)
        {
            int seqIdx = 0;
            foreach (var val in array)
            {
                if (seqIdx == sequence.Count)
                {
                    break;
                }
                if (sequence[seqIdx] == val)
                {
                    seqIdx++;
                }
            }
            return seqIdx == sequence.Count;



        }
    }
}
