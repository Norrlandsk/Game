using Game.Character.Enemy;
using Game.Mechanics;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Game.Character
{
    public class Player
    {



        private string name;
        private int level = 7;

        private int xp = 0;
        private int hp = 100;
        private int maxHp = 100;
        private int energy = 0;
        private int attack = 1;
        private int xpUntilNextLevel = 10;
        private int vial = 10;

        private int hearing = 1;
        private int vision = 1;
        private bool taste = true;
        private bool smell = true;

        private bool dead = false;
        private bool awake = false;

        public Player()
        {

        }


        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }

        public int Xp { get => xp; set => xp = value; }
        public int Hp { get => hp; set => hp = value; }
        public int MaxHp { get => maxHp; set => maxHp = value; }
        public int Energy { get => energy; set => energy = value; }
        public int Attack { get => attack; set => attack = value; }
        public int XpUntilNextLevel { get => xpUntilNextLevel; set => xpUntilNextLevel = value; }
        public int Vial { get => vial; set => vial = value; }

        public int Hearing { get => hearing; set => hearing = value; }
        public int Vision { get => vision; set => vision = value; }
        public bool Taste { get => taste; set => taste = value; }
        public bool Smell { get => smell; set => smell = value; }

        public bool Dead { get => dead; set => dead = value; }
        public bool Awake { get => awake; set => awake = value; }

        public int PlayerAttack()
        {

            int attackDamage = 0;
            attackDamage += Attack;
            attackDamage += Vision;


            int randomizedAttack = Setup.Setup.random.Next(0, 20);


            attackDamage *= randomizedAttack;
            return attackDamage;
        }

        public void TakeDamage(int dmg)
        {
            hp -= dmg;
        }

        public void RecieveXP(int enemyXP)
        {
            xp += enemyXP;
        }

        public void RecieveEnergy(int enemyEnergy)
        {
            energy += enemyEnergy;
        }

        public bool IsDead()
        {
            if (this.hp <= 0)
            {
                this.dead = true;
            }
            else
            {
                this.dead = false;
            }

            return this.dead;


        }



        public static void ShowInfo(Player player)
        {
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Level: {player.Level}");
            Console.WriteLine($"XP: {player.Xp}");
            Console.WriteLine($"HP: {player.Hp}");
            Console.WriteLine($"Energy: {player.Energy}");
            if (player.Hearing == 0)
            {
                Console.WriteLine("You are deaf");
            }
            else { Console.WriteLine($"Hearing level: {player.Hearing}"); }

            if (player.Vision == 0)
            {
                Console.WriteLine("You are blind");
            }
            else { Console.WriteLine($"Vision level: {player.Vision}"); }

            if (player.Taste == false)
            {
                Console.WriteLine("You have no sense of taste");
            }
            else { Console.WriteLine("You have the sense of taste"); }
            if (player.Smell == false)
            {
                Console.WriteLine("You have no sense of smell");
            }
            else
            {
                Console.WriteLine("You have the sense of smell");
            }
        }

        public void CheckXP()
        {
            if (xp >= xpUntilNextLevel)
            {
                Mechanics.Level.LevelUp(Battle.player);
            }
        }

        public void LoadGame()
        {
            Battle.player.Name = SaveGame.
        }


    }
}
