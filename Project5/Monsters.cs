           /////////////////////////////////////////////////////////////////////////////////////////////////////////
          //                                                                                                     //
         //                                                                                                     //
        // Project: Project5                                                                                   //
       // File Name: Monsters                                                                                 //
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
    internal class Monsters
    {
        protected string MonsterName { get; set; }
        protected int MonsterHealth { get; set; }
        protected int MonsterDmg { get; set; }

        public Monsters()
        {
            MonsterName = "";
            MonsterHealth = 0;
            MonsterDmg = 0;
        }

        public Monsters(string monsterName, int monsterHealth, int monsterDmg)
        {
            MonsterName = monsterName;
            MonsterHealth = monsterHealth;
            MonsterDmg = monsterDmg;
        }

        public override string ToString()
        {
            string info = "";

            info += $"\nA {MonsterName} has appeared!";
            info += $"\nHP: {MonsterHealth}";
            info += $"\nDMG: {MonsterDmg}";

            return info;
        }
    }
}
