using System;

namespace ReverseArrayWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split();

            ReverseArray(0, array);

            Console.WriteLine(string.Join(" ", array));

        }

        private static void ReverseArray(int index, string[] array)
        {
            if (index == array.Length / 2)
            {
                return;
            }

            var left = index;
            var right = array.Length - 1 - index;
            Swap(left, right, array);

            ReverseArray(index + 1, array);
        }

        private static void Swap(int left, int right, string[] array)
        {
            var temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
