using System;

namespace PermutationsWithoutRepetition
{
    class Program
    {
        private static string[] elements;
        private static bool[] used;
        private static string[] permutations;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            used = new bool[elements.Length];
            permutations = new string[elements.Length];

            Permutate(0);
        }

        private static void Permutate(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", permutations));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    permutations[index] = elements[i];
                    Permutate(index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
