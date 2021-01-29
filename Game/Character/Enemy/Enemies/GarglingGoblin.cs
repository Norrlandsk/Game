using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Character.Enemy.Enemies
{
    class GarglingGoblin : Enemy
    {

        //Constructor
        public GarglingGoblin()
        {
            base.Name = "gargling goblin";
            base.Level = 5;

            base.Xp = 40;
            base.Hp = 40;
            base.Energy = 40;
            base.Attack = 15;
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