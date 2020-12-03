using System;

namespace CombinationsWithoutRepetition
{
    class Program
    {
        private static string[] elements;
        private static string[] combinations;
        private static int k;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            k = int.Parse(Console.ReadLine());
            combinations = new string[k];

            Combinations(0, 0);
        }

        private static void Combinations(int index, int start)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = start; i < elements.Length; i++)
            {
                combinations[index] = elements[i];
                Combinations(index + 1, i + 1);
            }
        }
    }
}
