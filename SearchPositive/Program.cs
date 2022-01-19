using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {-8,-9,3,9,45,-4,84,14,1,-98 };

            var maks = array.Max();
            var myPositive = from item in array where item > 0 where item <= maks select item;

            foreach (var item in myPositive)
            {
                Console.WriteLine(item);
            }


        }
    }
}
