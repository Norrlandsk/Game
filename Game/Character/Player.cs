using Game.Character.Enemy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Character
{
    public class Player
    {

        private string name;
        private int level = 1;

        private int xp = 0;
        private int hp = 100;
        private int energy = 0;
        private int attack=1;

        private int hearing = 0;
        private int vision = 1;
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

            int attackDamage=1;

            
            
            Random randomAttack = new Random();
            int randomizedAttack = randomAttack.Next();

            randomizedAttack += attackDamage;
            return attackDamage;
        }

        public void TakeDamage(int dmg)
        {
            hp -= dmg;
        }
    }
}
