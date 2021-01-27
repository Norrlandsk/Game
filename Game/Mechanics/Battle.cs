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

        
        public static Player player = new Player();

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

            while (!enemy.IsDead() || !player.IsDead())
            {
             
                int enemyDmg=player.PlayerAttack();
                enemy.TakeDamage(enemyDmg);
                Console.WriteLine($"You hit the {enemy.GetName()}, causing {enemyDmg} damage");
                Console.WriteLine($"The enemy has {enemy.GetHP()} hp");
                Console.ReadLine();

                if (enemy.IsDead())
                {
                    player.RecieveXP(enemy.GetXP());
                    player.RecieveEnergy(enemy.GetEnergy());
                    Console.WriteLine($"The {enemy.GetName()} was defeated! You recieve {enemy.GetXP()} XP and {enemy.GetEnergy()} Energy Points!");
                    
                    Console.WriteLine($"Your XP is now {player.Xp} and your Energy is {player.Energy}");
                    break;
                }

                int enemyAttack= enemy.EnemyAttack();
                player.TakeDamage(enemyAttack);
                Console.WriteLine($"The {enemy.GetName()} strikes you, causing {enemyAttack} damage");

                if (player.IsDead())
                {
                    Console.WriteLine("You have died in this nightmare and are forever bound to roam the Void!");
                    Setup.Setup.isRunning = false;
                    break;
                }

                Console.WriteLine($"Your HP is now {player.Hp}");

                Console.ReadLine();
            }
        }
       


    }
}
