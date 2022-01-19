using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingLastElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> templist = new List<int>();
            templist.Add(15);
            templist.Add(75);
            templist.Add(55);
            templist.Add(79);
            templist.Add(56);


            templist.Sort();
            templist.Reverse();
            foreach (var item in templist.Take(3))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
