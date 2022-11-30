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

using static System.Net.Mime.MediaTypeNames;

using System.Xml.Linq;

namespace Project5
{
    public class Game_Driver
    {
        public static void Main(string[] args)
        {
            Dungeon newDungeon = new Dungeon();
            Console.WriteLine(newDungeon.MiddleTile());
        }

        #region Variables
        //
        public static Participant Monster;
        //
        public static Item Weapon;

        #endregion

        #region Methods
        public static void SpawnSkeleton()
        {
            Monster = new Participant();

            Monster.ParticipantName = "Skeleton";
            Monster.ParticipantHealth = 20;
            Monster.ParticipantWeapon = "Short Sword";
            Monster.ParticipantDmg = 4;
        }

        public static void SpawnOrc()
        {
            Monster = new Participant();

            Monster.ParticipantName = "Orc";
            Monster.ParticipantHealth = 25;
            Monster.ParticipantWeapon = "Broadsword";
            Monster.ParticipantDmg = 5;
        }

        public static void SpawnTroll()
        {
            Monster = new Participant();

            Monster.ParticipantName = "Troll";
            Monster.ParticipantHealth = 30;
            Monster.ParticipantWeapon = "Club";
            Monster.ParticipantDmg = 6;
        }

        public static void Anduril() 
        {
            Weapon = new Item();

            Weapon.Name = "Anduril";
            Weapon.Description = "A mighty sword with runes you can't quite make out etched along the length of the blade";
            Weapon.Weight = 1.5;
            Weapon.Damage = 7;
        }

        public static void Dagger_of_Westernesse()
        {
            Weapon = new Item();

            Weapon.Name = "Dagger of Westernesse";
            Weapon.Description = "An ornate dagger with a leaf-shaped blade and a hilt of gold and red serpents";
            Weapon.Weight = 0.5;
            Weapon.Damage = 5;
        }

        public static void Stick()
        {
            Weapon = new Item();

            Weapon.Name = "Stick";
            Weapon.Description = "It's just a stick";
            Weapon.Weight = 0.2;
            Weapon.Damage = 3;
        }
        #endregion
    }
}