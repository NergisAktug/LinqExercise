using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please, Enter A string:");
            string sentece = Console.ReadLine();

            var UpperCase = SearchUpperCase(sentece);

            Console.Write("Character that UpperCase:");
            foreach (var item in UpperCase)
            {
                Console.WriteLine(item+" ");
            }

            Console.ReadKey();

        }

        private static IEnumerable<string> SearchUpperCase(string sentece)
        {
            var myUpper=sentece.Split(' ').Where(x=>String.Equals(x,x.ToUpper()));
            return myUpper;
        }
    }
}
