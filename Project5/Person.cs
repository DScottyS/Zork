           /////////////////////////////////////////////////////////////////////////////////////////////////////////
          //                                                                                                     //
         //                                                                                                     //
        // Project: Project5                                                                                   //
       // File Name: Person                                                                                   //
      // Description: Subclass of participant for the player character                                       //
     // Course: CSCI 1260 – Introduction to Computer Science II                                             //
    // Author: Scotty Snyder, snyderds@etsu.edu, Department of Computing, East Tennessee State University  //
   // Created: Sunday, November 27, 2022                                                                  //
  // Copyright: Scotty Snyder, 2022                                                                      //
 //                                                                                                     //
/////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    /// <summary>
    /// person class inherits from participant and creates an entity for the player to control
    /// </summary>
    public class Person : Participant
    {
        /// <summary>
        /// the players name
        /// </summary>
        protected string PlayerName;

        /// <summary>
        /// defaut constructor
        /// </summary>
        public Person() : base()
        {
            ParticipantName = "";
            ParticipantHealth = 100;
            ParticipantDmg = 3;
            ParticipantWeapon = "Fists";
        }

        /// <summary>
        /// paramaterized constructor that allows for the player to have a unique name
        /// </summary>
        /// <param name="playerName">the name the player input</param>
        public Person(string playerName)
        {
            ParticipantName = playerName;
            ParticipantHealth = 100;
            ParticipantDmg = 3;
            ParticipantWeapon = "Fists";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>a string containing all the information about the player</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
