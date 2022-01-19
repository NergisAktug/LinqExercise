using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoin
{
    public class Item_mast
    {
        public int Id { get; set; }
        public string ItemDes { get; set; }

    }

    public class Purchase
    {
        public int Invno { get; set; }
        public int ItemId { get; set; }
        public int PurQty { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Item_mast> item_Masts = new List<Item_mast>
            {
                new Item_mast{Id=1,ItemDes="Biscuit"},
                new Item_mast{Id=2,ItemDes="Chocolate"},
                new Item_mast{Id=3,ItemDes="Butter  "},
                new Item_mast{Id=4,ItemDes="Brade   "},
                new Item_mast{Id=5,ItemDes="Honey"}
            };

            List<Purchase> purchases = new List<Purchase>
            {
                new Purchase{Invno=100,ItemId=3,PurQty=800},
                new Purchase{Invno=101,ItemId=2,PurQty=650},
                new Purchase{Invno=102,ItemId=3,PurQty=900},
                new Purchase{Invno=103,ItemId=4,PurQty=700},
                new Purchase{Invno=104,ItemId=3,PurQty=900},
                new Purchase{Invno=105,ItemId=4,PurQty=650}
            };

            var joindb = from e in item_Masts
                        join d in purchases on e.Id equals d.ItemId
                        select new
                        {
                            Id=e.Id,
                            ItemDesc=e.ItemDes,
                            PurQty=d.PurQty,

                        };

            foreach (var item in joindb)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
