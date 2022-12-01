           /////////////////////////////////////////////////////////////////////////////////////////////////////////
          //                                                                                                     //
         //                                                                                                     //
        // Project: Project5                                                                                   //
       // File Name: Participant                                                                              //
      // Description: Class that contains all the basic information for other participants                   //
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
    /// superclass that contains the basic information for all participants
    /// </summary>
    public class Participant
    {
        // Name of the participant
        public string ParticipantName { get; set; }
        // how much health the participant has
        public int ParticipantHealth { get; set; }
        // how much damage the participant does
        public int ParticipantDmg { get; set; }
        //the type of weapon the participant carries
        public string ParticipantWeapon { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Participant()
        {
            ParticipantName = "";
            ParticipantHealth = 0;
            ParticipantDmg = 0;
            ParticipantWeapon = "";
        }

        /// <summary>
        /// ToString returns all the given information as a string
        /// </summary>
        /// <returns>a string containing all the participant's information</returns>
        public override string ToString()
        {
            string info = "";

            info += $"\nName: {ParticipantName}";
            info += $"\nHP: {ParticipantHealth}";
            info += $"\nDMG: {ParticipantDmg}";
            info += $"\nWPN: {ParticipantWeapon}";

            return info;
        }
    }
}
