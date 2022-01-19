using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinctt
{
    public class Item_Must
    {
        public int ItemID { get; set; }
        public string ItemDes { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Item_Must> item_List = new List<Item_Must>();
            item_List.Add(new Item_Must() { ItemID = 1, ItemDes = "Biscuit " });
            item_List.Add(new Item_Must() { ItemID = 2, ItemDes = "Honey " });
            item_List.Add(new Item_Must() { ItemID = 3, ItemDes="Butter " });
            item_List.Add(new Item_Must() { ItemID = 4, ItemDes = "Brade " });
            item_List.Add(new Item_Must() { ItemID = 5, ItemDes = "Honey " });

            var can = (from x in item_List select x.ItemDes).Distinct().OrderBy(x=>x);


            foreach (var item in can)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            /*Console.WriteLine("How many strings do you want to enter?:");
            int number = Convert.ToInt32(Console.ReadLine());
            string[] myArray = new string[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Please, Enter a input:");
                string input = Console.ReadLine();
                myArray[i] = input;
            }*/
           
            


        }
    }
}
