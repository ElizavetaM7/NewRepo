using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { -172, 91, 158,1, 2, -5, 6, -7, 8, 995, 10,
                -11, 12, 5, 13, -5986, 14, -15, 16, 1596, 17, -18, 19, -20};

            var positive = new List<int>();
            foreach (var number in numbers)
                if (number > 0)
                    positive.Add(number);
           
               
        }
    }
}
