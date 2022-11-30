using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class Person : Participant
    {
        Item[] BackPack { get; set; }

        public Person() : base()
        {
            ParticipantName = "";
            ParticipantHealth = 100;
            ParticipantDmg = 0;
        }
    }
}
