using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolTeams
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = Console.ReadLine().Split(", ");
            var boys = Console.ReadLine().Split(", ");


            var girlCombs = new string[3];
            var girlsList = new List<string[]>();
            Combs(0, 0, girlCombs, girls, girlsList);

            var boysCombs = new string[2];
            var boysList = new List<string[]>();
            Combs(0, 0, boysCombs, boys, boysList);

            foreach (var currentGirlComb in girlsList)
            {
                foreach (var currentBoyComb in boysList)
                {
                    Console.WriteLine($"{string.Join(", ", currentGirlComb)}, {string.Join(", ", currentBoyComb)}");
                }
            }
        }

        private static void Combs(int cellIdx, int elementIdx, string[] combs, string[] elements, List<string[]> result)
        {
            if (cellIdx >= combs.Length)
            {
                result.Add(combs.ToArray());
                return; 
            }

            for (int i = elementIdx; i < elements.Length; i++)
            {
                combs[cellIdx] = elements[i];
                Combs(cellIdx + 1, i + 1, combs, elements, result);
            }
        }
    }
}
