using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, 98, 65, -9, 58 };
            var square = array.Select(x => x * x);

            var squareAndSelf = from self in array
                                let squaree = self * self
                                where squaree > 10
                                select new { self, squaree };

            foreach (var item in square)
            {
                Console.Write(" {0} ",item);
            }

            Console.WriteLine("");

            foreach (var item in squareAndSelf)
            {
                Console.WriteLine("{0}-{1}",item.self,item.squaree);
            }

            Console.ReadLine();

        }
    }
}
