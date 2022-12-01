           /////////////////////////////////////////////////////////////////////////////////////////////////////////
          //                                                                                                     //
         //                                                                                                     //
        // Project: Project5                                                                                   //
       // File Name: Rucksack                                                                                 //
      // Description: allows players to hold on to the items they have                                       //
     // Course: CSCI 1260 – Introduction to Computer Science II                                             //
    // Author: Scotty Snyder, snyderds@etsu.edu, Department of Computing, East Tennessee State University  //
   // Created: Sunday, November 27, 2022                                                                  //
  // Copyright: Scotty Snyder, 2022                                                                      //
 //                                                                                                     //
/////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    /// <summary>
    /// allows players to hold on to the items they have
    /// </summary>
    public class Rucksack
    {
        //list of objects of type weapon, which is what the player will be holding
        private List<Weapon> Inventory = new List<Weapon>();

        /// <summary>
        /// default constructor
        /// </summary>
        public Rucksack()
        {
            Inventory = new List<Weapon>();
        }

        /// <summary>
        /// adds a weapon to the rucksack
        /// </summary>
        /// <param name="item">weapon object</param>
        public void Add(Weapon item)
        {
            Inventory.Add(item);
        }

        /// <summary>
        /// removes a weapon from the rucksack
        /// </summary>
        /// <param name="item">weapon object</param>
        public void Remove(Weapon item)
        {
            Inventory.Remove(item);
        }
        /// <summary>
        /// displays everything in the user's rucksack
        /// </summary>
        /// <returns>a string containing all the weapons the player has</returns>
        public string DisplayInventory()
        {
            string inv = "";

            inv += "Inventory------------------------------------\n";
            foreach (Weapon i in Inventory)
            {
                inv += i;
                inv += "\n---------------------------------------------";
            }

            return inv;
        }
    }
}
