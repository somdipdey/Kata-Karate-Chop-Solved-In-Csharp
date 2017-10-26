using System;

namespace Test_For_Kata_Karate_Chop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define an array for testing pruposes-->
            int[] array = { 1, 2, 5, 7, 13, 19, 21, 39, 40 };


            // Tests whether the 
            Test_The_Chop.assertEqual(2, 5, array);// Passed

            Test_The_Chop.assertEqual(-1, 3, array);// Passed

            Test_The_Chop.assertEqual(-1, 49, array);// Passed

            Test_The_Chop.assertEqual(5, 19, array);// Passed
        }
    }
}
