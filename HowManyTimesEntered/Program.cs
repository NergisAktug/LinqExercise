using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyTimesEntered
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 10,89,54,68,78,98, 10, 89,78, 98, 68, 78, 98,0,1,9, 10, 89, 54, 68, 78, 98 };

            var Times = array.GroupBy(x => x);

            var Times2 = from x in array
                         group x by x into groups //It is kept in one place after being grouped.
                         select groups;
            foreach (var item in Times2)
            {
                Console.WriteLine(item.Key+" "+item.Count());
            }

            foreach (var item in Times)
            {
                Console.WriteLine(item.Key+" Count:"+item.Count());
            }

            Console.ReadLine();
        }
    }
}
