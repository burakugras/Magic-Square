using System;
using System.Collections.Generic;

namespace HRMagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var try1 = new List<List<int>>() { new List<int>() { 5, 3, 4 }, new List<int>() { 1, 5, 8 }, new List<int>() { 6, 4, 2 } };
            var result = formingMagicSquare(try1);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static int formingMagicSquare(List<List<int>> s)
        {
            List<List<List<int>>> collection = new List<List<List<int>>>()
            {
            new List<List<int>>() {new List<int>() {8, 1, 6}, new List<int>() {3, 5, 7}, new List<int>() {4, 9, 2}},
            new List<List<int>>() {new List<int>() {6, 1, 8}, new List<int>() {7, 5, 3}, new List<int>() {2, 9, 4}},
            new List<List<int>>() {new List<int>() {4, 9, 2}, new List<int>() {3, 5, 7}, new List<int>() {8, 1, 6}},
            new List<List<int>>() {new List<int>() {2, 9, 4}, new List<int>() {7, 5, 3}, new List<int>() {6, 1, 8}},
            new List<List<int>>() {new List<int>() {8, 3, 4}, new List<int>() {1, 5, 9}, new List<int>() {6, 7, 2}},
            new List<List<int>>() {new List<int>() {4, 3, 8}, new List<int>() {9, 5, 1}, new List<int>() {2, 7, 6}},
            new List<List<int>>() {new List<int>() {6, 7, 2}, new List<int>() {1, 5, 9}, new List<int>() {8, 3, 4}},
            new List<List<int>>() {new List<int>() {2, 7, 6}, new List<int>() {9, 5, 1}, new List<int>() {4, 3, 8}},
            };

            int minimum = int.MaxValue;
            foreach (var item in collection)
            {
                int temp = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        temp += Math.Abs(s[i][j] - item[i][j]);
                    }
                }
                minimum = Math.Min(minimum, temp);
            }
            return minimum;
        }
    }
}
