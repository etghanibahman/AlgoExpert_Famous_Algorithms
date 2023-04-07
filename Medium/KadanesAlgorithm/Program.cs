using System;

namespace KadanesAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1, -5, 4 }; // output = 19
            array = new int[] { -1000, -1000, 2, 4, -5, -6, -7, -8, -2, -100 };
            Console.WriteLine($"The output is : {KadanesAlgorithm(array)}");
        }

        public static int KadanesAlgorithm(int[] array)
        {
            int maxEnding = array[0];
            int maxSum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                maxEnding += array[i];
                maxEnding = Math.Max(maxEnding, array[i]);
                maxSum = Math.Max(maxEnding, maxSum);
            }

            return maxSum;
        }
    }
}
