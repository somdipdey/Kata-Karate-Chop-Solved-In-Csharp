using System;

namespace Kata_Karate_Chop_In_CSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 7, 13, 19, 21, 39, 40 };

            var result = KarateChop.chop(13, array); // Prints out 4

            Console.WriteLine(result);

            var result2 = KarateChop.chop(19, array); // Prints out 5

            Console.WriteLine(result2);

            var result3 = KarateChop.chop(2, array); // Prints out 1

            Console.WriteLine(result3);

            var result4 = KarateChop.chop(40, array); // Prints out 8

            Console.WriteLine(result4);

            var result5 = KarateChop.chop(0, array); // Prints out -1

            Console.WriteLine(result5);

            var result6 = KarateChop.chop(50, array); // Prints out -1

            Console.WriteLine(result6);

            Console.ReadLine();
        }
    }
}
