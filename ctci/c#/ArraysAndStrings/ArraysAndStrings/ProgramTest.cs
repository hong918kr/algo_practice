using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ArraysAndStrings
{
    class ProgramTest
    {
        public static void IsUnique_test()
        {
            string input1 = "abc";
            string input2 = "accvd";
            


            Debug.Assert(Program.IsUnique(input1));
            Debug.Assert(!Program.IsUnique(input2));

            Debug.Assert(Program.IsUnique_book1(input1));
            Debug.Assert(!Program.IsUnique_book1(input2));

            Debug.Assert(Program.IsUnique_book2(input1));
            Debug.Assert(!Program.IsUnique_book2(input2));

        }

    }
}
