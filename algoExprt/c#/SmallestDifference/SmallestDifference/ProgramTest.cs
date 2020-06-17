using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SmallestDifference
{
    public class ProgramTest
    {

        public static void TestCase1()
        {
            int[] inputOne_1 = new int[] { -1, 5, 10, 20, 28, 3 };
            int[] inputTwo_1 = new int[] { 26, 134, 135, 15, 17 };
            int[] output_1 = new int[] { 28, 26 };
           
            Debug.Assert(Program.SmallestDifference(inputOne_1, inputTwo_1) == output_1);
            Console.WriteLine("TestCase1 Pass");
        }

        public static void TestCase2()
        {
            Console.WriteLine("TestCase2");
        }



    }
}
