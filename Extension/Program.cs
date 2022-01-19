using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "aaa.frx","bbb.TXT","xyz.dbf","abc.pdf","aaaa.pdf","xyz.frt","abc.xml","ccc.txt","zzz.txt" };

            //Extension:Uzanti
            var GroupAndCounted = arr1.Select(x => Path.GetExtension(x).TrimStart('.').ToLower())
                                        .GroupBy(y=>y,(extension,count)=>new 
                                        { 
                                        Extensionn=extension,
                                        Count=count.Count()
                                        });


            foreach (var item in GroupAndCounted)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
