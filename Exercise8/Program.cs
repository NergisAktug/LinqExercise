using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = {"ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS" };
            Console.Write("Input starting character for string:");
            var start = Console.ReadLine();
            Console.Write("Input ending character for string:");
            var end = Console.ReadLine();

            var city = from x in cities where x.StartsWith(start) where x.EndsWith(end) select x;

            foreach (var item in city)
            {
                Console.WriteLine("The city starting with {0} and end {1} is:{2}", start, end, item);
            }
          

            Console.ReadKey();

        }
    }
}
