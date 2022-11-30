using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class Tiles
    {
        protected bool IsBeginning;
        protected bool IsExit;
        protected bool HasWeapon;
        protected bool HasMonster;
        protected bool HasPlayer;
        protected Random Chance;


        public Tiles()
        {
            IsBeginning = false;
            IsExit = false;
            HasWeapon = false;
            HasMonster = false;
            HasPlayer = false;
            Chance = new Random();
        }

        public Tiles StartingTile()
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

            return this;
        }

        public Tiles MiddleTile() 
        {
            IsBeginning = false;
            IsExit = false;
            HasPlayer = false;

            if (Chance.Next(5) < 1)
            {
                HasWeapon = true;
            }
            else
            {
                HasWeapon = false;
            }

            if (Chance.Next(3) <= 1)
            {
                HasMonster = true;
            }
            else
            {
                HasMonster = false;
            }

            return this;
        }

        public Tiles FinalTile()
        { 
            IsBeginning = false;
            IsExit = true;
            HasPlayer = false;

            if (Chance.Next(5) < 1)
            {
                HasWeapon = true;
            }
            else
            {
                HasWeapon = false;
            }

            if (Chance.Next(3) <= 1)
            {
                HasMonster = true;
            }
            else
            {
                HasMonster = false;
            }

            return this;
        }
    }
}
