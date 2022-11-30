using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    public class Rucksack
    {
        private List<Item> Inventory = new List<Item>();

        public Rucksack()
        {
            Inventory = new List<Item>();
        }

        public void Add(Item item)
        {
            Inventory.Add(item);
        }

        public void Remove(Item item)
        {
            Inventory.Remove(item);
        }

        public string DisplayInventory()
        {
            string inv = "";

            inv += "Inventory------------------------------------";
            foreach (Item i in Inventory)
            {
                inv += i;
                inv += "---------------------------------------------";
            }

            return inv;
        }
    }
}
