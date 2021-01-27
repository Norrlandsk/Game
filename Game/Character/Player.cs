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
        Random randomAttack = new Random();


        private string name;
        private int level = 1;

        private int xp = 0;
        private int hp = 100;
        private int energy = 0;
        private int attack = 1;

        private int hearing = 0;
        private int vision = 0;
        private bool taste = false;
        private bool smell = false;

        private bool dead = false;
        private bool awake = false;

        public Player()
        {

        }


        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }

        public int Xp { get => xp; set => xp = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Energy { get => energy; set => energy = value; }
        public int Attack { get => attack; set => attack = value; }

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


            int randomizedAttack = randomAttack.Next(0, 3);


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
                Console.WriteLine("You are deathe");
            }
            else { Console.WriteLine($"Hearing: {player.Hearing}");}

            if (player.Vision==0)
            {
                Console.WriteLine("You are blind");
            }
            else { Console.WriteLine($"Vision: {player.Vision}");}
            
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

    }
}
