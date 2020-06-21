using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {            
            ProgramTest.IsUnique_test();
            Console.WriteLine("IsUnique test Pass");

            ProgramTest.CheckPermutation_test();
            Console.WriteLine("CheckPermutation test Pass");

            ProgramTest.URLify_test();
            Console.WriteLine("URLify test Pass");

        }

        public static bool IsUnique(string s)
        {
            /*
             * Implement an algorithms to determine if a string has all unique characters.
             * What if you cannot use additional data structures?
             */
            HashSet<char> mySet = new HashSet<char>();
            foreach (char elem in s)
            {
                if (mySet.Contains(elem))
                {
                    return false;
                }
                else
                {
                    mySet.Add(elem);
                }
            }
            return true;
        }

        public static bool IsUnique_book1(string s)
        {
            if (s.Length > 128) return false;
            bool[] char_set = new bool[128];
            for (int i = 0; i < s.Length; i++)
            {
                int val = s[i];
                if (char_set[val])
                {
                    return false;
                }
                char_set[val] = true;
            }

            return true;
        }

        public static bool IsUnique_book2(string s)
        {
            int checker = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int val = s[i] - 'a';
                if((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }
            return true;
        }

        public static bool CheckPermutation(string s1, string s2)
        {
            /*
             * Given two strings, write a method to decide if one is a permutation of the other.
             */
            
            if (s1.Length < s2.Length)
            {
                string temp = s1;
                s1 = s2;
                s2 = temp;
            } // s1 is always longer than s2

            char[] s1charArr = s1.ToCharArray();
            Array.Sort(s1charArr);
            char[] s2charArr = s2.ToCharArray();
            Array.Sort(s2charArr);

            int s1Ptr = 0;
            int s2Ptr = 0;


            while (s1Ptr < s1charArr.Length)
            {
                if (s2Ptr == s2charArr.Length)
                {
                    return true;
                }

                if (s1charArr[s1Ptr] == s2charArr[s2Ptr])
                {                    
                    ++s1Ptr;
                    ++s2Ptr;                    
                } else
                {
                    ++s1Ptr;
                }
            }

            if (s2Ptr < s2charArr.Length)
            {
                return false;
            } else
            {
                return true;
            }
           
        }

        public String Sort(String s)
        {
            char[] content = s.ToCharArray();
            Array.Sort(content);
            return new string(content);
        }

        bool CheckPermutation_book1(String s, String t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            return Sort(s).Equals(Sort(t));
        }
        
        bool CheckPermutation_book2(String s, String t)
        {   // Check if the two strings have identical character counts.
            if (s.Length != t.Length)
            {
                return false;
            }
            int[] letters = new int[128]; // Assumption

            char[] s_array = s.ToCharArray();
            foreach (char c in s_array)
            {   // Count number of each char in s.
                ++letters[c];
            }

            for (int i = 0; i < t.Length; i++)
            {
                int c = (int)t[i];
                --letters[c];
                if (letters[c] < 0)
                {
                    return false;
                }
            }
            return true;           
        }

        public static string URLify(String s, int l)
        {
            /*
             * Write a method to replace all spaces in a string with '%20'. You may assume that the string
             * has sufficient space at the end to hold the additional charaters, and that you are given the 'true'
             * length of the string. (Note: If implementing in Java, please use a character array so that you can
             * perform this operation in place.)
             * 
             * Input: "Mr John Smith         ", 13
             * Ouput: "Mr%20John%20Smith"
             */

            char[] s_array = s.ToCharArray();
            char[] ret = new char[3 * l];
            foreach (char c in s_array)
            {
                if (c == ' ')
                {
                    ret.Append('%');
                    ret.Append('2');
                    ret.Append('0');
                }

                ret.Append(c);
            }
            string ret_string = ret.ToString().Trim();

            return ret_string;

            
        }

        public void URLify_book(char[] str, int length)
        {
            int spaceCount = 0;
            int newLength;
            int i;

            for (i = 0; i < length; i++)
            {
                if (str[i] == ' ')
                {
                    spaceCount++;
                }
            }
            newLength = length + spaceCount * 2;
            str[newLength] = '\0';
            for (i = length - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    str[newLength - 1] = '0';
                    str[newLength - 2] = '2';
                    str[newLength - 3] = '%';
                    newLength = newLength - 3;
                }
                else
                {
                    str[newLength - 1] = str[i];
                    newLength = newLength - 1;
                }
            }
        }


        public static bool palindromePermutation()
        {
            /*
             * Given a string, write a function to check if it is a permutation of a palindrome.
             * A palindrome is a word or phrase that is the same forwards and backwards.
             * A permutation is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words.
             *           
             * Input: Tact Coa
             * Output: True (Permutations: "taco cat", "atco cta", etc)
             *           
             */
            return true;
        }

        public static bool IsOneWay(string input1, string input2)
        {
            /*
             * There are three types of edits that can be performed on strings: intert a character, remove a character, or
             * replace a character. Given two strings, write a function to check if they are one edit (or zero edits) away.
             * 
             * pale, ple -> true
             * pales, pale -> true
             * pale, bale -> true
             * pale, bake -> false
             */
            return true;
        }

        public static string CompressString(string input)
        {
            /*
             * Implement a method to perform basic string compression using the counts of repeated characters.
             * For example, the string aabcccccaaa would become a2b1c5a3. If the "compressed" string would not become
             * smaller that the original string, your method should return the original string.
             * You can assume the string has only uppercase and lowercase letters (a-z).
             */
            return "";
        }

        public static int[,] RotateMatrix(int[,] NxNarr)
        {
            /*
             * Given an image represented by an N x N matrix, where each pixel in the image is 4 bytes, 
             * write a method to rotate the image by 90 degrees. Can you do this in place?
             */
            return new int[0, 0]; 
        }

        public static int[,] ZeroMatrix(int[,] MxNarr)
        {
            /*
             * Write an algorithm such that if an element in an M x N matrix is 0, its entire row and column are set to 0.
             */
            return new int[0, 0];
        }

        public static string RotateString(string input)
        {
            /*
             * Assume you have a method isSubstring which checks if one word is a substring of another. 
             * Given two strings, s1 and s1, write code to check if s2 is a rotation of s1 using only one call to isSubstring
             * (e.g. "waterbottle" is a rotation of "erbottlewat" ).
             */
            return "";
        }

        public static bool IsSubstring(string input)
        {
            /*
             */
            return true;
        }



    }
}
