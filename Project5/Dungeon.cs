using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class Dungeon : Tiles
    {
        protected Tiles[] DungeonSize;

        protected Random NumberOfTiles = new Random();

        protected Tiles StartingPosition;

        protected int CurrentTile;

        public Dungeon() : base()
        {
            DungeonSize = new Tiles[NumberOfTiles.Next(5, 11)];
            StartingPosition = DungeonSize[0];

            for (int i = 0; i < DungeonSize.Length; i++)
            {
                DungeonSize[i] = new Tiles();
            }

            //DungeonSize[0] = StartingTile();
            //DungeonSize[DungeonSize.Length - 1] = FinalTile();
        }

        public void MoveEast()
        {
            
        }

        public void MoveWest()
        {
            
        }

        public override string ToString()
        {
            string info = "";

            foreach (Tiles t in DungeonSize)
            {
                if (HasPlayer == true && HasWeapon == true && HasMonster == true)
                {
                    info += "|P_W_M|  ";
                }
                else if (HasPlayer == true && HasWeapon == true)
                {
                    info += "|P_W__|  ";
                }
                else if (HasPlayer == true)
                {
                    info += "|P____|  ";
                }
                else if (HasWeapon == true && HasMonster == true)
                {
                    info += "|__W_M|  ";
                }
                else if (HasWeapon == true)
                {
                    info += "|__W__|  ";
                }
                else if (HasMonster == true)
                {
                    info += "|____M|  ";
                }
                else
                {
                    info += "|_____|  ";
                }
            }

            return info;
        }
    }
}
