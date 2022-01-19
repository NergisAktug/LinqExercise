using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveChar
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> myList = new List<string>();
            myList.Add("m");
            myList.Add("n");
            myList.Add("o");
            myList.Add("p");
            myList.Add("q");
            var firstResult = from x in myList select x;


            foreach (var item in firstResult)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            myList.RemoveAll(x => x=="p");

            var secondResult = from x in myList select x;
            Console.WriteLine("New my list");
            foreach (var item in secondResult)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();



        }
    }
}
