using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    public class Item
    {
        //the item name
        public string Name { get; set; }
        //the item description
        public string Description { get; set; }
        //the item weight
        public double Weight { get; set; }
        public int Damage { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Item()
        {
            Name = "";
            Description = "";
            Weight = 0;
            Damage = 0;
        }

        /// <summary>
        /// parameterized constructor of an item
        /// </summary>
        /// <param name="name">the name of the item</param>
        /// <param name="description">the description of the item</param>
        /// <param name="weight">the weight of the item</param>
        public Item(string name, string description, double weight, int damage)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Damage = damage;
        }

        /// <summary>
        /// returns all information given to it as a string
        /// </summary>
        /// <returns>all input information as a string</returns>
        public override string ToString()
        {
            string info = "";

            info += $"\nItem Name: {Name}";
            info += $"\nItem Description: {Description}";
            info += $"\nItem Weight: {Weight} lbs.";
            info += $"\nThis {Name} deals {Damage} DMG per hit";

            return info;
        }
    }
}