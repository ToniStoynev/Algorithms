using System;

namespace NestedLoopsToRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var arr = new int[n];

            Comb(0, arr);
        }

        private static void Comb(int index, int[] arr)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int i = 1; i <= arr.Length; i++)
            {
                arr[index] = i;
                Comb(index + 1, arr);

            }
        }
    }
}
