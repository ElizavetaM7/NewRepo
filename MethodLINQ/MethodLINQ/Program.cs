using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLINQ
{
    internal class Program
    {
        public static int[] SortArray(int[] arr)
        {
            return arr.Where(x => x > 0)
                      .OrderByDescending(x => x.ToString().Length)
                      .ThenBy(x => x)
                      .ToArray();
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -5,18,65,-67};
            int[] sortedArr = SortArray(arr);
            Console.WriteLine(string.Join(", ", sortedArr));

            Console.ReadKey();
        }
    }
}
