using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Character.Enemy.Enemies
{
    class EliteOompaLoompa : Enemy
    {

        //Constructor
        public EliteOompaLoompa()
        {
            base.Name = "elite oompa loompa";
            base.Level = 8;

            base.Xp = 70;
            base.Hp = 70;
            base.Energy = 70;
            base.Attack = 30;
            base.Dead = false;
        }

        //Methods
        public override string GetName()
        { return base.GetName(); }

        public override int GetLevel()
        {
            return base.GetLevel();
        }

        public override int GetHP()
        { return base.GetHP(); }

        public override int GetXP()
        { return base.GetXP(); }

        public override int GetEnergy()
        { return base.GetEnergy(); }

        public override void Message()
        {
            base.Message();
            Console.Write("an ");
            Console.Write(base.GetName());
        }

        public override int EnemyAttack()
        {
            return base.EnemyAttack();
        }

        public override void TakeDamage(int dmg)
        {
            base.TakeDamage(dmg);
        }

        public override bool IsDead()
        {
            return base.IsDead();
        }

    }
}
