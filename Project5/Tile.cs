           /////////////////////////////////////////////////////////////////////////////////////////////////////////
          //                                                                                                     //
         //                                                                                                     //
        // Project: Project5                                                                                   //
       // File Name: Tile                                                                                     //
      // Description: Class dedicated to creating objects for each room the player can explore               //
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
    //Class dedicated to creating objects for each room the player can explore
    public class Tile
    {
        //determines if a tile is where the game starts
        public bool IsBeginning;
        //determines if a tile is where the game starts
        public bool IsExit;
        //determines if a tile contains a weapon
        public bool HasWeapon;
        //determines if a tile contains a monster
        public bool HasMonster;
        //determines if the player is or is not in a tile
        protected bool HasPlayer;
        //random object used for determining if a weapon or monster will be in a tile
        public Random Chance = new Random();

        /// <summary>
        /// default constructor
        /// </summary>
        public Tile()
        {
            IsBeginning = false;
            IsExit = false;
            HasPlayer = false;
            HasWeapon = false;
            HasMonster = false;
            Chance = new Random();
        }

        //parameterized constructor that tells what type of tile to make
        public Tile(string str)
        {
            if (str == "Start")
            {
                IsBeginning = true;
                IsExit = false;
                HasPlayer = true;
                HasWeapon = false;
                HasMonster = false;
            }
            else if (str == "Middle")
            {
                IsBeginning = false;
                IsExit = false;
                HasPlayer = false;

                if (Chance.Next(5) == 1)
                {
                    HasWeapon = true;
                }
                else
                {
                    HasWeapon = false;
                }

                if (Chance.Next(3) == 1)
                {
                    HasMonster = true;
                }
                else
                {
                    HasMonster = false;
                }
            }
            else if (str == "Exit")
            {
                IsBeginning = false;
                IsExit = true;
                HasPlayer = false;

                if (Chance.Next(5) == 1)
                {
                    HasWeapon = true;
                }
                else
                {
                    HasWeapon = false;
                }

                if (Chance.Next(3) == 1)
                {
                    HasMonster = true;
                }
                else
                {
                    HasMonster = false;
                }
            }
        }
        /// <summary>
        /// converts all the information made above into "tiles" to make it easy for the user to read
        /// </summary>
        /// <returns>a string contaning all the tile information</returns>
        public override string ToString()
        {
            string info = "";

            if (HasPlayer == true && HasWeapon == true && HasMonster == true)
            {
                HasMonster = true;
                info += "|P_W_M|  ";
            }
            else if (HasPlayer == true && HasWeapon == true)
            {
                info += "|P_W__|  ";
            }
            else if (HasPlayer == true && HasMonster == true)
            {
                HasMonster = true;
                info += "|P___M|  ";
            }
            else if (HasPlayer == true)
            {
                info += "|P____|  ";
            }
            else if (HasWeapon == true && HasMonster == true)
            {
                info += "|__W_M|  ";
            }
            else if (HasWeapon == true)
            {
                info += "|__W__|  ";
            }
            else if (HasMonster == true)
            {
                info += "|____M|  ";
            }
            else
            {
                info += "|_____|  ";
            }

            return info;
        }
    }
}
