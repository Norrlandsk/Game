using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Character.Enemy
{
    interface IEnemy
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Xp { get; set; }
        public int Energy { get; set; }
        public int Attack { get; set; }
        public bool Dead { get; set; }

        public string GetName();
        public int GetHP();
        public int GetXP();
        public int GetEnergy();
        public void Message();
        public int EnemyAttack();
        public void TakeDamage(int dmg);
        public bool IsDead();

    }
}
