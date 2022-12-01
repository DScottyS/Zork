           /////////////////////////////////////////////////////////////////////////////////////////////////////////
          //                                                                                                     //
         //                                                                                                     //
        // Project: Project5                                                                                   //
       // File Name: Dungeon                                                                                  //
      // Description: the class where all the tiles are collected and turned into the map for the game       //
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
    /// class where all the tiles are collected and turned into the map for the game
    /// </summary>
    public class Dungeon : Tile
    {
        //list of tiles that determine the dungeons size
        public List<Tile> DungeonSize;
        //random object that determines the length 
        public Random NumberOfTiles = new Random();
        //the actual tile the player is in
        public Tile tile;
        //integer position of where the player currently is in the array of tiles
        public int CurrentTile;
        //uses Tile's parameterized constructor to determine what type of tile it should be
        private string Start = "Start";
        //uses Tile's parameterized constructor to determine what type of tile it should be
        private string Middle = "Middle";
        //uses Tile's parameterized constructor to determine what type of tile it should be
        private string Exit = "Exit";

        /// <summary>
        /// default constructor
        /// </summary>
        public Dungeon() : base()
        {
            DungeonSize = new List<Tile>();
            NumberOfTiles.Next(5, 10);
            tile = null;
            CurrentTile = 0;
        }

        /// <summary>
        /// creates a new dungeon within 5-10 tiles long, fills it with middle tiles, and adds the start and end to the beginning and
        /// end of the list respectively
        /// </summary>
        public void CreateNewDungeon()
        {
            DungeonSize = new List<Tile>(new Tile[NumberOfTiles.Next(3, 8)]);

            for (int i = 0; i < DungeonSize.Count; i++)
            {
                DungeonSize[i] = new Tile(Middle);
            }

            CurrentTile = 0;
            DungeonSize.Insert(0, new Tile(Start));
            DungeonSize.Add(new Tile(Exit));
        }
        /// <summary>
        /// moves the player's character to the right
        /// </summary>
        public void MoveEast()
        {
            try
            {
                DungeonSize[CurrentTile].HasPlayer = false;
                CurrentTile++;
                tile = DungeonSize[CurrentTile];
                DungeonSize[CurrentTile].HasPlayer = true;
            }
            //when the player moves all the way to the right, i.e. the exit tile, tells them they have completed the game and terminates the program
            catch (ArgumentOutOfRangeException)
            {
                CurrentTile--;
                tile = DungeonSize[CurrentTile];
                DungeonSize[CurrentTile].HasPlayer = false;
                Console.WriteLine("Congratulations! You have beaten the Epic Adventure Game! Thank you for playing!");
                Environment.Exit(0);
            }
            
        }
        /// <summary>
        /// moves the player's character to the right
        /// </summary>
        public void MoveWest()
        {
            try
            {
                DungeonSize[CurrentTile].HasPlayer = false;
                CurrentTile--;
                tile = DungeonSize[CurrentTile];
                DungeonSize[CurrentTile].HasPlayer = true;
            }
            //prevents the player from going west past the starting tile at index [0]
            catch (ArgumentOutOfRangeException)
            {
                CurrentTile++;
                tile = DungeonSize[CurrentTile];
                DungeonSize[CurrentTile].HasPlayer = true;
                Console.WriteLine("you cannot go west any further");
            }

        }
        /// <summary>
        /// puts all the tiles together in one row for display purposes
        /// </summary>
        /// <returns>all tiles in a row</returns>
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
