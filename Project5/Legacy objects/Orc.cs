using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    public class Orc : Participant
    {
        public Orc()
        {
            ParticipantName = "Orc";
            ParticipantHealth = 25;
            ParticipantWeapon = "Broadsword";
            ParticipantDmg = 5;
        }
    }
}
