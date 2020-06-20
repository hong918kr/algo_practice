using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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


        public static void CheckPermutation_test()
        {
            string s1_1 = "abcdef";
            string s2_1 = "abc";

            string s1_2 = "aavvd";
            string s2_2 = "avf";

            Debug.Assert(Program.CheckPermutation(s1_1, s2_1));
            Debug.Assert(!Program.CheckPermutation(s1_2, s2_2));

        }

    }
}
