using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekdays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays = { "Monday", "Tuesday", "Wendesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var days=from x in weekdays select x;
            foreach (var item in days)
            {
                Console.WriteLine(item);
            }

        }
    }
}
