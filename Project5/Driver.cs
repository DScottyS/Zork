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
            Console.Write("Welcome to game, please leave name: ");
            //playerName = Console.ReadLine();
            playerName = "aaa";
            player = new Person(playerName);

            Console.WriteLine($"Welcome {playerName}! Press any key to start");
            //Console.ReadKey(false);

            newDungeon.CreateNewDungeon();
            Console.WriteLine(newDungeon);


            Console.ReadKey();
            newDungeon.MoveEast();
            
            Console.WriteLine(newDungeon);
            if (newDungeon.tile.HasMonster == true)
            {
                EnemySpawnRate();
                Thread.Sleep(500);
                BattleSystem();
            }

            Console.ReadKey();
            newDungeon.MoveEast();

            Console.WriteLine(newDungeon);
            if (newDungeon.tile.HasMonster == true)
            {
                EnemySpawnRate();
                Thread.Sleep(500);
                BattleSystem();
            }

            Console.ReadKey();
            newDungeon.MoveEast();
            Console.WriteLine(newDungeon);
            if (newDungeon.tile.HasMonster == true)
            {
                EnemySpawnRate();
                Thread.Sleep(500);
                BattleSystem();
            }






            /*Stick();
            playerRucksack.Add(weapon);
            Anduril();
            playerRucksack.Add(weapon);
            Console.WriteLine(playerRucksack.DisplayInventory());*/

        }

        #region Variables
        //
        public static Person player;
        //
        public static Dungeon newDungeon = new Dungeon();
        //creates a new monster participant
        public static Participant monster;
        //creates a new weapon item
        public static Weapon weapon;
        //creates a new rucksack for the player to store their items
        public static Rucksack playerRucksack = new Rucksack();
        //stores the player's name
        public static string getPlayerName;
        //
        public static string playerChoice;
        //
        public static Random chance = new Random();
        //
        public static int probability;
        //
        public static string playerName;

        #endregion

        #region Methods

        public static void Menu()
        {
            



        }

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

        public static void EnemySpawnRate()
        {
            probability = chance.Next(1, 11);

            if (probability <= 6 )
            {
                SpawnSkeleton();
                Console.WriteLine(monster);
            }
            else if (probability <= 9 || probability > 7)
            {
                SpawnOrc();
                Console.WriteLine(monster);

            }
            else if (probability == 10)
            {
                SpawnTroll();
                Console.WriteLine(monster);
            }
        }

        public static void BattleSystem()
        {
            do
            {
                if (chance.Next(1, 11) >= 9)
                {
                    Console.WriteLine($"The {monster.ParticipantName} misses!\n");
                }
                else
                {
                    Console.WriteLine($"The {monster.ParticipantName} strikes!\n");
                    player.ParticipantHealth -= monster.ParticipantDmg;
                    Console.WriteLine($"{player.ParticipantName}\nHP: {player.ParticipantHealth}");
                }
                Thread.Sleep(1000);

                if (chance.Next(1, 11) == 1)
                {
                    Console.WriteLine($"I missed!\n");
                }
                else
                {
                    Console.WriteLine($"I lunge at the enemy!\n");
                    monster.ParticipantHealth -= player.ParticipantDmg;
                    Console.WriteLine($"{monster.ParticipantName}\nHP: {monster.ParticipantHealth}");
                }
                Thread.Sleep(1000);

            } while (monster.ParticipantHealth > 0);

            if (monster.ParticipantHealth < 0)
            {
                Console.WriteLine($"\nThe mighty {monster.ParticipantName} before me has been slain, I think it's safe to move on\n");
            }
            else if (player.ParticipantHealth < 0)
            {
                Console.WriteLine($"\nAnother hero has been brought to ruin by these dank catacombs - GAME OVER");
            }
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

        public static void ItemSpawnRate()
        {
            probability = chance.Next(1, 11);

            if (probability <= 4)
            {
                Stick();
            }
            else if (probability <= 8 && probability > 4)
            {
                Dagger_of_Westernesse();
            }
            else if (probability >= 9)
            {
                Anduril();
            }
        }

        #endregion
    }
}