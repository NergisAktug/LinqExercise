using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationFileSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] direcfiles=Directory.GetFiles(@"C:\");

            foreach (var item in direcfiles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********");
            var obje = direcfiles.Select(x => new FileInfo(x));
            foreach (var item in obje)
            {
                Console.WriteLine(item);
            }


            var avgFsize = direcfiles.Select(x =>new FileInfo(x).Length).Average();
            avgFsize = Math.Round(avgFsize/10,1);

            Console.WriteLine(avgFsize);

            Console.ReadKey();

        }
    }
}
