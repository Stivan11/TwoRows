using System;
using System.Linq;
using System.Collections.Generic;

namespace TwoRows
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .ToList();

            var second = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .ToList();

            var sorted = new List<int>(first);

            for (int i = 0; i < second.Count; i++)
            {
                sorted.Add(second[i]);
            }

            sorted.Sort();

            var queue = new Queue<int>(sorted);

            Console.WriteLine(string.Join(", ", sorted));

            
        }
    }
}
