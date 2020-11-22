using System;

namespace Generate01Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var vector = new int[n];

            Generate01Vectors(vector, 0);
        }

        private static void Generate01Vectors(int[] vector, int index)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join("", vector));
                return;
            }

            for (int number = 0; number <= 1; number++)
            {
                vector[index] = number;
                Generate01Vectors(vector, index + 1);
            }
        }
    }
}
