using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByMinimumNumberOfCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1;
            Console.Write("How many elements should my array consist of?:");
            int n=Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Element[{0}]:",i+1);
                arr1[i] = Console.ReadLine();
            }

            Console.Write("Please, Enter Minimum Number Of Character:");
            int ctr = Convert.ToInt32(Console.ReadLine());


            var can = from x in arr1 where x.Length >= ctr orderby x select x;
            foreach (var item in can)
            {
                Console.WriteLine("Item: {0}",item);
               // Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
