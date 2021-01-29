using Game.Character;
using Game.Character.Enemy;
using Game.Character.Enemy.Enemies;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Game.Setup;

namespace Game.Mechanics
{
    class Battle
    {


        public static Player player = new Player();



        public static void Roam()
        {
            int randomMessage = Setup.Setup.random.Next(1, 10);

            if (randomMessage < 4)
            {
                Console.WriteLine("You stumble around aimlessly, trying to figure out what is happening");

            }
            else
            {


                Setup.Setup.enemyList=Setup.Setup.SetupEnemyList(player);
                int randomizedEnemy = Setup.Setup.random.Next(Setup.Setup.enemyList.Count);
                StartBattle(Setup.Setup.enemyList[randomizedEnemy]);
            }
        }
        private static void StartBattle(IEnemy enemy)
        {
            enemy.Message();

            while (!enemy.IsDead() || !player.IsDead())
            {

                int enemyDmg = player.PlayerAttack();
                enemy.TakeDamage(enemyDmg);
                Console.WriteLine($"You hit the {enemy.GetName()}, causing {enemyDmg} damage");
                Console.WriteLine($"The enemy has {enemy.GetHP()} hp");
                Console.ReadLine();

                if (enemy.IsDead())
                {
                    player.RecieveXP(enemy.GetXP());
                    player.RecieveEnergy(enemy.GetEnergy());
                    Console.WriteLine($"The {enemy.GetName()} was defeated! You recieve {enemy.GetXP()} XP and {enemy.GetEnergy()} Energy Points!");
                    int getVial=Setup.Setup.random.Next(1, 11);
                    if (getVial >5)
                    {
                        player.Vial += 1;
                        if (player.Level < 7)
                        {
                            Console.WriteLine($"The {enemy.GetName()} dropped a vial with some form of liquid. If only your tastebuds were not totally numb, maybe you would dare taste it, might be useful...");
                        }
                        else
                        {
                            Console.WriteLine($"The {enemy.GetName()} dropped a vial with some form of liquid. You might want to taste it, might do you some good...");
                        }

                    }
                    Console.WriteLine($"Your XP is now {player.Xp} and your Energy is {player.Energy}");



                    player.CheckXP();



                    Setup.Setup.enemyList.Clear();
                    break;
                }

                int enemyAttack = enemy.EnemyAttack();
                player.TakeDamage(enemyAttack);
                Console.WriteLine($"The {enemy.GetName()} strikes you, causing {enemyAttack} damage");

                if (player.IsDead())
                {

                    Console.WriteLine("You have died in this nightmare and are forever bound to roam the Void!");
                    Console.WriteLine("Would you like to restart from your last save point (y), or accept your fate (n)? (y/n)");

                    
                    string choice = Console.ReadLine();
                    if (choice.ToUpper() == "Y")
                    {
                        if (player.Level >= 3 && player.Level <= 4)
                        {
                            player = new Player(Setup.Setup.listOfSavedGames[0]);

                        }
                        else if (player.Level >= 5 && player.Level <=6)
                        {
                            player = new Player(Setup.Setup.listOfSavedGames[1]);
                        }
                        else if (player.Level >=7)
                        {
                            player = new Player(Setup.Setup.listOfSavedGames[2]);
                        }

                    }

                    else if (choice.ToUpper() == "N")
                    {
                    Setup.Setup.isRunning = false;

                    }


                    
                }

                Console.WriteLine($"Your HP is now {player.Hp}");

                Console.ReadLine();
            }
        }



    }
}
