using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveByIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>();
            mylist.Add("m");
            mylist.Add("n");
            mylist.Add("o");
            mylist.Add("p");
            mylist.Add("q");

            var firstResult = from x in mylist select x;
            foreach (var item in firstResult)
            {
                Console.WriteLine("Char :{0}",item);
            }

            //mylist.RemoveAt(3);
            mylist.RemoveRange(1,3);//1.Indexdeki elemandan 3.index'deki(dahil) elemana kadar siler


            var secondResult = from x in mylist select x;
            Console.WriteLine("New Mylist");
            foreach (var item in secondResult)
            {
                Console.WriteLine("Char :{0}", item);
            }

            Console.ReadKey();

        }
    }
}
