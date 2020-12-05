namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            var coins = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            var sortedCoins = new SortedSet<int>(coins);

            var target = int.Parse(Console.ReadLine());
            var result = 0;

            var sb = new StringBuilder();
            while (target > 0 && sortedCoins.Count > 0)
            {
                var maxCoin = sortedCoins.Max;
                sortedCoins.Remove(maxCoin);

                if (maxCoin > target)
                {
                    continue;
                }

                var coinsCounter = target / maxCoin;
                result += coinsCounter;

                target = target - (maxCoin * coinsCounter);
                sb.AppendLine($"{coinsCounter} coin(s) with value {maxCoin}");
            }

            if (target > 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine($"Number of coins to take: {result}");
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
