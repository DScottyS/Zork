           /////////////////////////////////////////////////////////////////////////////////////////////////////////
          //                                                                                                     //
         //                                                                                                     //
        // Project: Project5                                                                                   //
       // File Name: Driver                                                                                   //
      // Description:                                                                                        //
     // Course: CSCI 1260 – Introduction to Computer Science II                                             //
    // Author: Scotty Snyder, snyderds@etsu.edu, Department of Computing, East Tennessee State University  //
   // Created: Sunday, November 27, 2022                                                                  //
  // Copyright: Scotty Snyder, 2022                                                                      //
 //                                                                                                     //
/////////////////////////////////////////////////////////////////////////////////////////////////////////

using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Project5
{
    public class Game_Driver
    {
        public static void Main(string[] args)
        {
            Dungeon newDungeon = new Dungeon();
            newDungeon.CreateNewDungeon();
            Console.WriteLine(newDungeon);

            Console.ReadKey();
            newDungeon.MoveEast();
            Console.WriteLine(newDungeon);




            /*Stick();
            playerRucksack.Add(weapon);
            Anduril();
            playerRucksack.Add(weapon);
            Console.WriteLine(playerRucksack.DisplayInventory());*/

        }

        #region Variables
        //creates a new monster participant
        public static Participant monster;
        //creates a new weapon item
        public static Weapon weapon;
        //creates a new rucksack for the player to store their items
        public static Rucksack playerRucksack = new Rucksack();
        //stores the player's name
        public static string getPlayerName;

        #endregion

        #region Methods
        public static void SpawnSkeleton()
        {
            monster = new Participant();

            monster.ParticipantName = "Skeleton";
            monster.ParticipantHealth = 20;
            monster.ParticipantWeapon = "Short Sword";
            monster.ParticipantDmg = 4;
        }

        public static void SpawnOrc()
        {
            monster = new Participant();

            monster.ParticipantName = "Orc";
            monster.ParticipantHealth = 25;
            monster.ParticipantWeapon = "Broadsword";
            monster.ParticipantDmg = 5;
        }

        public static void SpawnTroll()
        {
            monster = new Participant();

            monster.ParticipantName = "Troll";
            monster.ParticipantHealth = 30;
            monster.ParticipantWeapon = "Club";
            monster.ParticipantDmg = 6;
        }

        public static void Anduril()
        {
            weapon = new Weapon();

            weapon.Name = "Anduril";
            weapon.Description = "A mighty sword with runes you can't quite make out etched along the length of the blade";
            weapon.Weight = 1.5;
            weapon.Damage = 7;
        }

        public static void Dagger_of_Westernesse()
        {
            weapon = new Weapon();

            weapon.Name = "Dagger of Westernesse";
            weapon.Description = "An ornate dagger with a leaf-shaped blade and a hilt of gold and red serpents";
            weapon.Weight = 0.5;
            weapon.Damage = 5;
        }

        public static void Stick()
        {
            weapon = new Weapon();

            weapon.Name = "Stick";
            weapon.Description = "It's just a stick";
            weapon.Weight = 0.2;
            weapon.Damage = 3;
        }
        #endregion
    }
}