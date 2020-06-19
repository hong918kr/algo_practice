using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MoveElementToEnd
{
    class ProgramTest
    {
        public static void TestCase1()
        {
            List<int> array1 = new List<int>()
            {
                2, 1, 2, 2, 2, 3, 4, 2
            };
            int toMove1 = 2;
            List<int> expectedStart1 = new List<int>()
            {
                1, 3, 4
            };
            List<int> expectedEnd1 = new List<int>()
            {
                2, 2, 2, 2, 2
            };
            List<int> output = Program.MoveElementToEnd(array1, toMove1);
            List<int> outputStart = output.GetRange(0, 3);
            outputStart.Sort();
            List<int> outputEnd = output.GetRange(3, output.Count - 3);
            

            return;
        }

        public static void TestCase2()
        {
            return;
        }

    }
}
