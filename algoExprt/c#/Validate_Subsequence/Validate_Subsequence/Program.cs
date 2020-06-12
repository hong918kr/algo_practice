using System;
using System.Collections.Generic;
using System.Diagnostics;
using Two_Number_Sum;

namespace Validate_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> array19 = new List<int>
            {
                5, 1, 22, 25, 6, -1, 8, 10
            };
            List<int> sequence19 = new List<int>
            {
                5, 1, 25, 22, 6, -1, 8, 10
            };

            Debug.Assert(!Solution.IsValidSubsequence(array19, sequence19));
            Console.WriteLine("Pass test case 19");


            List<int> array21 = new List<int>
            {
                1, 1, 6, 1
            };
            List<int> sequence21 = new List<int>
            {
                1, 1, 1, 6
            };

            Debug.Assert(!Solution.IsValidSubsequence(array21, sequence21));
            Console.WriteLine("Pass test case 21");

            Console.WriteLine("Done");

        }
    }
}
