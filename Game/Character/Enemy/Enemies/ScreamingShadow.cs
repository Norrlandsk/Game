using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Character.Enemy.Enemies
{
    class ScreamingShadow : Enemy
    {

        //Constructor
        public ScreamingShadow()
        {
            base.Name = "screaming shadow";
            base.Level = 1;

            base.Xp = 10;
            base.Hp = 100;
            base.Energy = 10;
            base.Attack = 1;
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
        { return base.GetHP(); }

        public override int GetEnergy()
        { return base.GetEnergy(); }

        public override void Message()
        {
            base.Message();
            Console.Write("a ");
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
