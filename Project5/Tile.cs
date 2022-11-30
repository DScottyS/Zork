           /////////////////////////////////////////////////////////////////////////////////////////////////////////
          //                                                                                                     //
         //                                                                                                     //
        // Project: Project5                                                                                   //
       // File Name: Tile                                                                                    //
      // Description:                                                                                        //
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
    public class Tile
    {
        public bool IsBeginning;
        public bool IsExit;
        public bool HasWeapon;
        public bool HasMonster;
        public bool HasPlayer;
        public Random Chance = new Random();


        public Tile()
        {
            IsBeginning = false;
            IsExit = false;
            HasPlayer = false;
            HasWeapon = false;
            HasMonster = false;
            Chance = new Random();
        }

        public Tile(string str)
        {
            if (str == "Start")
            {
                IsBeginning = true;
                IsExit = false;
                HasPlayer = true;

                if (Chance.Next(5) < 1)
                {
                    HasWeapon = true;
                }
                else
                {
                    HasWeapon = false;
                }

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

        /*public Tile StartingTile()
        {
            IsBeginning = true;
            IsExit = false;
            HasPlayer = true;

            if (probability.Next(5) < 1)
            {
                HasWeapon = true; 
            }
            else 
            {
                HasWeapon = false;
            }

            HasMonster = false;

            return this;
        }


        public Tile FinalTile()
        { 
            IsBeginning = false;
            IsExit = true;
            HasPlayer = false;

            if (probability.Next(5) < 1)
            {
                HasWeapon = true;
            }
            else
            {
                HasWeapon = false;
            }

            if (probability.Next(3) <= 1)
            {
                HasMonster = true;
            }
            else
            {
                HasMonster = false;
            }

            return this;
        }*/

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
