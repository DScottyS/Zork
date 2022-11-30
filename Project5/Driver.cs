           /////////////////////////////////////////////////////////////////////////////////////////////////////////
          //                                                                                                     //
         //                                                                                                     //
        // Project: Project5                                                                                   //
       // File Name: Project5                                                                                 //
      // Description:                                                                                        //
     // Course: CSCI 1260 – Introduction to Computer Science II                                             //
    // Author: Scotty Snyder, snyderds@etsu.edu, Department of Computing, East Tennessee State University  //
   // Created: Sunday, November 27, 2022                                                                  //
  // Copyright: Scotty Snyder, 2022                                                                      //
 //                                                                                                     //
/////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project5
{
    public class Game_Driver
    {
        public static void Main(string[] args)
        {
            Dungeon newDungeon = new Dungeon();
            Console.WriteLine(newDungeon.MiddleTile());
        }
    }
}