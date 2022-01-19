using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByThen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "PARIS", "LONDON", "ZURICH", "NAIROBI","ABU DHABI","AMSTERDAM","NEW DELHI","CALIFORNIA" };


            var FirstCharacterLenghtAndAlfa = cities.OrderBy(x=>x.Length).ThenBy(y => y).ToList();

            foreach (var item in FirstCharacterLenghtAndAlfa)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
