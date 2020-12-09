﻿namespace DFS
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        private static Dictionary<int, List<int>> graph;
        private static HashSet<int> visited;
        static void Main(string[] args)
        {
            graph = new Dictionary<int, List<int>>
            {
                { 1, new List<int> { 19, 21, 14} },
                { 19, new List<int> {7, 12, 31, 21 } },
                { 21, new List<int> { 14 } },
                { 14, new List<int> { 23, 6 } },
                { 7, new List<int> { 1 } },
                { 12, new List<int>() },
                { 31, new List<int> { 21 } },
                { 23, new List<int> { 21 } },
                { 6, new List<int> () }

            };

            visited = new HashSet<int>();

            foreach (var node in graph.Keys)
            {
                DFS(node);
            }
        }

        private static void DFS(int node)
        {
            if (visited.Contains(node))
            {
                return;
            }

            visited.Add(node);

            foreach (var child in graph[node])
            {
               DFS(child);
            }

            Console.WriteLine(node);
        }
    }
}