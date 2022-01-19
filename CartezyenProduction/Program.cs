using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartezyenProduction
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charset = {'X','Y','Z' };
            int[] array1 = {1,2,3,4 };

            var cartezyen = from x in charset
                            from y in array1
                            select new { x, y };
            foreach (var item in cartezyen)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
