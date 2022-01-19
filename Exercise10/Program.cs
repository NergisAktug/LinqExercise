using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of members on the List:");
            var number =Convert.ToInt32(Console.ReadLine());
            List<int> arrays=new List<int>();

            for (int i = 1; i <=number; i++)
            {
                Console.Write("Member {0}:", i);
                var nmbr = Convert.ToInt32(Console.ReadLine());
                arrays.Add(nmbr);
            }

            Console.Write("Input the value above you want to display the members of the List:");
            var input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The numbers greater than {0} are:",input);

            var Greater = arrays.Where(x => x > input);
            //var Grater=arrays.FindAll(x=>x>input ? True:False)
            foreach (var item in Greater)
            {
                Console.Write(item+"\n");
            }

            Console.ReadKey();
        }
    }
}
