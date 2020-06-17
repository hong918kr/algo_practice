using System;
using System.Security.Cryptography.X509Certificates;

namespace SmallestDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Start");
            ProgramTest.TestCase1();
            ProgramTest.TestCase2();
            Console.WriteLine("Start");
        }

        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            // 1. Brute-force
            /*
             *  1. Brute force
             *      
             * 
             *  2. Sort and compare two pointer
             *      a. 
             */

            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int ptrOne = 0;
            int ptrTwo = 0;
            int minVal = int.MaxValue;
            int dist;
            
            while (ptrOne < arrayOne.Length || ptrTwo < arrayTwo.Length)
            {
                
                dist = Math.Abs(arrayOne[ptrOne] - arrayTwo[ptrTwo]);
                if (dist < minVal)
                {
                    if (ptrOne == arrayOne.Length - 1)
                    {

                        if (dist > minVal)
                        {
                            minVal = dist;
                        } else
                        {
                            return new int[] { arrayOne[ptrOne], arrayTwo[ptrTwo] };
                        }
                        ++ptrTwo;
                        continue;
                    }

                    minVal = dist;
                }

                if (ptrOne == arrayOne.Length - 1)
                {
                    dist = Math.Abs(arrayOne[ptrOne] - arrayTwo[ptrTwo + 1]);
                    if (dist < minVal)
                    {
                        minVal = dist;
                        ++ptrTwo;
                    } else
                    {
                        return new int[] { arrayOne[ptrOne], arrayTwo[ptrTwo] };
                    }                    
                    continue;
                } else
                {
                    dist = Math.Abs(arrayOne[ptrOne] - arrayTwo[ptrTwo + 1]);
                    if (dist < minVal)
                    {
                        minVal = dist;
                        ++ptrTwo;
                    } else
                    {
                        ++ptrOne;
                    }                    
                }                
            }
            return new int[] { arrayOne[ptrOne], arrayTwo[ptrTwo] };
        }

    }
}
