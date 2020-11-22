using System;
using System.Collections.Generic;

namespace PathsInLabyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());


            var lab = new char[row, col];

            for (int r = 0; r < row; r++)
            {
                string line = Console.ReadLine();
                for (int c = 0; c < line.Length; c++)
                {
                    lab[r, c] = line[c];
                }
            }
            var directions = new List<char>();

            FindAllPaths(lab, 0, 0, directions, '\0');

        }



        private static void FindAllPaths(char[,] lab, int row, int col, List<char> directions, char direction)
        {
            if (IsOutside(lab, row, col) 
                || IsWall(lab, row, col)
                ||IsVisited(lab, row, col))
            {
                return;
            }

            directions.Add(direction);

            if (IsSolution(lab, row, col))
            {
                Console.WriteLine(string.Join("", directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }

            lab[row, col] = 'v';
            
            FindAllPaths(lab, row - 1, col, directions, 'U');
            FindAllPaths(lab, row + 1, col, directions, 'D');
            FindAllPaths(lab, row, col + 1, directions, 'R');
            FindAllPaths(lab, row, col - 1, directions, 'L');

            directions.RemoveAt(directions.Count - 1);
            lab[row, col] = '-';

        }

        private static bool IsSolution(char[,] lab, int row, int col)
        {
            return lab[row, col] == 'e';
        }

        private static bool IsVisited(char[,] lab, int row, int col)
        {
            return lab[row, col] == 'v';
        }

        private static bool IsOutside(char[,] lab, int row, int col)
        {
            return row >= lab.GetLength(0) 
                    || row < 0 
                    || col < 0 
                    || col >= lab.GetLength(1);         
        }

        private static bool IsWall(char[,] lab, int row, int col)
        {
            return lab[row, col] == '*';
        }
        private static char[,] ReadLab(int row, int col)
        {
            var lab = new char[row, col];

            for (int r = 0; r < lab.GetLength(0); r++)
            {
                string line = Console.ReadLine();
                for (int c = 0; c < lab.GetLength(1); c++)
                {
                    lab[r, c] = line[c];
                }
            }

            return lab;
        }
    }
}
