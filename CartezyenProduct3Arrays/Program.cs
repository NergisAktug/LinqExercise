using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartezyenProduct3Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charset = { 'X', 'Y', 'Z' };
            int[] array1 = { 1, 2, 3, 4 };
            string[] colourSet = {"Green","Orange"};
            var cartezyen = from x in charset
                            from y in array1
                            from z in colourSet
                            select new { x, y,z };
            foreach (var item in cartezyen)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();


        }
    }
}
