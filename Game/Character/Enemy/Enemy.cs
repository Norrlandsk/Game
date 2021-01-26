using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Character.Enemy
{
    abstract class Enemy : IEnemy
    {
        private string name;
        private int level;

        private int xp;
        private int hp;
        private int energy;
        private int attack;
        private bool dead;

        public Enemy()
        {

        }

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }

        public int Xp { get => xp; set => xp = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Energy { get => energy; set => energy = value; }
        public int Attack { get => attack; set => attack = value; }
        public bool Dead { get => dead; set => dead = value; }

        public virtual string GetName()
        { return this.name; }

        public virtual int GetLevel()
        {
            return this.level;
        }

        public virtual int GetHP()
        { return this.hp; }

        public virtual int GetXP()
        { return this.xp; }

        public virtual int GetEnergy()
        { return this.energy; }

        public virtual void Message()
        {
            Console.Write($"In the void, suddenly you come upon ");
        }

        public virtual int EnemyAttack(int attack)
        {

            int attackDamage = 1;
            attack *= attackDamage;


            Random randomAttack = new Random();
            int randomAttackDamage = randomAttack.Next(0, 3);

            randomAttackDamage *= attackDamage;

            return attackDamage;
        }

        public virtual void TakeDamage(int dmg)
        {
            this.hp -= dmg;
        }

        public virtual bool IsDead()
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
    }
}
