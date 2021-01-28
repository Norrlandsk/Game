using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Character.Enemy.Enemies
{
    class MaliciousGhost : Enemy
    {

        //Constructor
        public MaliciousGhost()
        {
            base.Name = "nameless horror";
            base.Level = 4;

            base.Xp = 30;
            base.Hp = 30;
            base.Energy = 30;
            base.Attack = 10;
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