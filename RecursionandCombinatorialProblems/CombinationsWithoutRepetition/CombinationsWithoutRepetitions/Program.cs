using System;

namespace CombinationsWithoutRepetitions
{
    class Program
    {
        private static int[] combinations;
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            combinations = new int[k];

            CombinationsWithRepetitions(0, 1, n);
        }

        private static void CombinationsWithRepetitions(int index, int start, int n)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                combinations[index] = i;
                CombinationsWithRepetitions(index + 1, i + 1, n);
            }
        }
    }
}
