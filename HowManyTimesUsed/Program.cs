using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyTimesUsed
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please, Enter a String:");
            var stringg = Console.ReadLine();

            var frequency = from character in stringg
                        group character by character into groups
                        select groups;
            foreach (var item in frequency)
            {
                Console.WriteLine("{0} ->{1}",item.Key,item.Count());
            }

            Console.ReadKey();

        }
    }
}
