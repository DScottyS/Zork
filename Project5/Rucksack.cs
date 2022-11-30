using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    public class Rucksack
    {
        private List<Weapon> Inventory = new List<Weapon>();

        public Rucksack()
        {
            Inventory = new List<Weapon>();
        }

        public void Add(Weapon item)
        {
            Inventory.Add(item);
        }

        public void Remove(Weapon item)
        {
            Inventory.Remove(item);
        }

        public string DisplayInventory()
        {
            string inv = "";

            inv += "Inventory------------------------------------";
            foreach (Weapon i in Inventory)
            {
                inv += i;
                inv += "---------------------------------------------";

            }

            return inv;
        }
    }
}
