using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split();

           ReverseArray(array);

            Console.WriteLine(string.Join(" ", array));
        }

        private static void ReverseArray(string[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                var left = i;
                var right = array.Length - 1 - i;
                Swap(left, right, array);
            }
        }

        private static void Swap(int left, int right, string[] array)
        {
            var temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
