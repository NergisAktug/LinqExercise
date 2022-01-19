using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
             IEnumerable<int> array =Enumerable.Range(1, 10).Where(x=>x%2==0);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
