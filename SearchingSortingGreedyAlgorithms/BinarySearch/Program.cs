using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var element = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch(elements, element));
                
        }

        private static int BinarySearch(int[] elements, int element)
        {
            var startIdx = 0;
            var endIdx = elements.Length - 1;

            while (startIdx <= endIdx)
            {
                var midIdx = (startIdx + endIdx) / 2;

                if (elements[midIdx] == element)
                {
                    return midIdx;
                }

                if (elements[midIdx] > element)
                {
                    endIdx = midIdx - 1;
                }
                else
                {
                    startIdx = midIdx + 1;
                }
            }

            return -1;
        }
    }
}
