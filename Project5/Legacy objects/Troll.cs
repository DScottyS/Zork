using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    public class Troll : Participant
    {
        public Troll()
        {
            ParticipantName = "Troll";
            ParticipantHealth = 30;
            ParticipantWeapon = "Club";
            ParticipantDmg = 6;
        }
    }
}
