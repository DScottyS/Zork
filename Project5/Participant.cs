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
    public class Participant
    {
        protected string ParticipantName { get; set; }
        protected int ParticipantHealth { get; set; }
        protected int ParticipantDmg { get; set; }
        protected string ParticipantWeapon { get; set; }

        public Participant()
        {
            ParticipantName = "";
            ParticipantHealth = 0;
            ParticipantDmg = 0;
            ParticipantWeapon = "";
        }

        public Participant(string participantName, int participantHealth, int participantDmg, string participantWeapon)
        {
            ParticipantName = participantName;
            ParticipantHealth = participantHealth;
            ParticipantDmg = participantDmg;
            ParticipantWeapon = participantWeapon;
        }

        public override string ToString()
        {
            string info = "";

            info += $"\nA {ParticipantName} has appeared!";
            info += $"\nHP: {ParticipantHealth}";
            info += $"\nDMG: {ParticipantDmg}";
            info += $"\nWPN: {ParticipantWeapon}";

            return info;
        }
    }
}
