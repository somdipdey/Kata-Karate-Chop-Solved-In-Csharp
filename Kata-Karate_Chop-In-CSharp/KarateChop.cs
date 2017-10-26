using System;
namespace Kata_Karate_Chop_In_CSharp
{
	public class KarateChop
    {
        public KarateChop()
        {
        }

        // Binary chop function. Returns the index of the element in the array
        // if the element is found or else returns -1.
        public static int chop(int num, int[] array_of_int)
        {
            int length = array_of_int.Length;

            int pivot = array_of_int[length / 2];

            if (num == pivot) return length / 2;

            switch (num < pivot)
            {
                // Two slightly different apporaches are taken in each switch case.
                case true:
                    // Search the element in the first half
                    int thisFirstIndex = 0;
                    foreach (int thisElement in array_of_int)
                    {
                        if (thisFirstIndex >= (length / 2)) return -1;
                        if (thisElement == num) return thisFirstIndex;
                        thisFirstIndex++;
                    }
                    break;

                case false:
                    // Search the element in the second half
                    for (int thisSecondIndex = (length / 2) + 1; thisSecondIndex < length; thisSecondIndex++)
                    {
                        if (array_of_int[thisSecondIndex] == num) return thisSecondIndex;
                    }
                    return -1;
            }

            return -1;
        }
    }
}
