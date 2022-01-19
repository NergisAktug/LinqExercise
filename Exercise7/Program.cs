using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] TestData = {5,1,9,2,3,7,4,5,6,8,7,6,3,4,5,2};

            var freguence = from x in TestData
                            group x by x into groups
                            select groups;
            foreach (var item in freguence)
            {
                Console.WriteLine("{0} {1} {2}",item.Key,item.Key*item.Count(),item.Count());
            }

            Console.ReadKey();
        }
    }
}
