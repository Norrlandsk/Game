using Game.Character;
using Game.Character.Enemy;
using Game.Character.Enemy.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Mechanics
{
    class Battle
    {

        
        static Player player = new Player();

        public static void Roam()
        {
            List<IEnemy> operativeEnemyList = Setup.Setup.SetupEnemyList();
            Random rn = new Random();
            int random = rn.Next(0, 11);

            if (random < 4)
            {
                Console.WriteLine("You stumble around aimlessly, trying to figure out what is happening");

            }
            else
            {
                
                Random randomEnemy = new Random();
                int randomizedEnemy = randomEnemy.Next(operativeEnemyList.Count);
                StartBattle(operativeEnemyList[randomizedEnemy]);
            }
        }
        private static void StartBattle(IEnemy enemy)
        {
            enemy.Message();

            while (!enemy.Dead || !player.Dead)
            {
                Console.WriteLine($"The enemy has {enemy.GetHP()} hp");
                int enemyDmg=player.PlayerAttack();
                enemy.TakeDamage(enemyDmg);
                Console.WriteLine($"You hit the {enemy.GetName()}, causing {enemyDmg} damage");
                Console.WriteLine($"The enemy has {enemy.GetHP()} hp");
                Console.ReadLine();
            }
        }
       


    }
}
