           /////////////////////////////////////////////////////////////////////////////////////////////////////////
          //                                                                                                     //
         //                                                                                                     //
        // Project: Project5                                                                                   //
       // File Name: Dungeon                                                                                  //
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
    public class Dungeon : Tile
    {
        public List<Tile> DungeonSize;

        public Random NumberOfTiles = new Random();

        public Tile tile;

        public int CurrentTile;

        private string Start = "Start";

        private string Middle = "Middle";

        private string Exit = "Exit";

        public Dungeon() : base()
        {
            DungeonSize = new List<Tile>();
            NumberOfTiles.Next(5, 10);
            tile = null;
            CurrentTile = 0;
        }

        public void CreateNewDungeon()
        {
            DungeonSize = new List<Tile>(new Tile[NumberOfTiles.Next(5, 9)]);

            for (int i = 0; i < DungeonSize.Count; i++)
            {
                DungeonSize[i] = new Tile(Middle);
            }

            CurrentTile = 0;
            DungeonSize.Insert(0, new Tile(Start));
            DungeonSize.Add(new Tile(Exit));
        }

        public void MoveEast()
        {
            DungeonSize[CurrentTile].HasPlayer = false;
            CurrentTile++;
            tile = DungeonSize[CurrentTile];
            DungeonSize[CurrentTile].HasPlayer = true;
        }

        public void MoveWest()
        {
            try
            {
                DungeonSize[CurrentTile].HasPlayer = false;
                CurrentTile--;
                tile = DungeonSize[CurrentTile];
                DungeonSize[CurrentTile].HasPlayer = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                CurrentTile++;
                tile = DungeonSize[CurrentTile];
                DungeonSize[CurrentTile].HasPlayer = true;
                Console.WriteLine("I can't go west any further");
            }

        }

        public override string ToString()
        {
            string info = "";

            info += "\n";
            foreach (Tile t in DungeonSize)
            {
                info += t.ToString();
            }
            info += "\n";


            return info;
        }
    }
}
