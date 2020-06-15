using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Three_Number_Sum
{
    public static class ProgramTest
    {
        public static bool compare(List<int[]> triplets1, List<int[]> triplets2)
        {
            if (triplets1.Count != triplets2.Count) return false;
            for (int i = 0; i < triplets1.Count; i++)
            {
                if (!Enumerable.SequenceEqual(triplets1[i], triplets2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static void TestCase1()
        {
            List<int[]> expected = new List<int[]>();
            expected.Add(new int[] { -8, 2, 6 });
            expected.Add(new int[] { -8, 3, 5 });
            expected.Add(new int[] { -6, 1, 5 });
            List<int[]> output =
              Solution.ThreeNumberSum(new int[] { 12, 3, 1, 2, -6, 5, -8, 6 }, 0);

            Debug.Assert(ProgramTest.compare(output, expected));
        }
    }
}


