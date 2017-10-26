using System;
using Kata_Karate_Chop_In_CSharp;

namespace Test_For_Kata_Karate_Chop
{
	public class Test_The_Chop
    {
        public Test_The_Chop()
        {
        }

        public static void assertEqual(int value, int num, int[] array){
            if (KarateChop.chop(num, array) == value) Console.WriteLine("Passed");
            else Console.WriteLine("Failed");
        }
    }
}
