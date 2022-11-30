using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class Person : Participant
    {
        protected string PlayerName;

        public Person() : base()
        {
            ParticipantName = "";
            ParticipantHealth = 100;
            ParticipantDmg = 2;
            ParticipantWeapon = "Fists";
        }

        public Person(string playerName)
        {
            ParticipantName = playerName;
            ParticipantHealth = 100;
            ParticipantDmg = 2;
            ParticipantWeapon = "Fists";
        }
    }
}
