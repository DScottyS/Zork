using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    public class Person : Participant
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

        public override string ToString()
        {
            string info = "";

            info += $"Player Name: {PlayerName}";

            return info;
        }
    }
}
