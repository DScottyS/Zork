           /////////////////////////////////////////////////////////////////////////////////////////////////////////
          //                                                                                                     //
         //                                                                                                     //
        // Project: Project5                                                                                   //
       // File Name: Weapon                                                                                   //
      // Description: Weapon class                                                                           //
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
    //containts the basic parameters for weapons
    public class Weapon
    {
        //weapon name
        public string Name { get; set; }
        //weapon description
        public string Description { get; set; }
        //weapon weight
        public double Weight { get; set; }
        //weapon damage
        public int Damage { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Weapon()
        {
            Name = "";
            Description = "";
            Weight = 0;
            Damage = 0;
        }

        /// <summary>
        /// parameterized constructor of an weapon
        /// </summary>
        /// <param name="name">the name of the weapon</param>
        /// <param name="description">the description of the weapon</param>
        /// <param name="weight">the weight of the weapon</param>
        /// <param name="damage">how much damage the weapon does</param>
        public Weapon(string name, string description, double weight, int damage)
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

            info += $"\nWeapon Name: {Name}";
            info += $"\nWeapon Description: {Description}";
            info += $"\nWeapon Weight: {Weight} lbs.";
            info += $"\n{Damage} DMG per hit\n";

            return info;
        }
    }
}