using Game.Character;
using Game.Character.Enemy.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Mechanics
{
    public class Level
    {
        
        public static void LevelUp(Player player)
        {
            player.Hp = player.MaxHp;
            player.Level += 1;
            Console.WriteLine($"You have leveled up and is now level {player.Level}. You feel refreshed and a will to struggle on.");
            Console.WriteLine($"Your health is restored to {player.Hp} HP");

            switch (player.Level)
            {
                case 2:
                    player.XpUntilNextLevel = 20;
                    break;
                case 3:
                    player.Hearing += 1;
                    Console.WriteLine("You realise with a shock that you now can hear. Tears of relief flood your eyes as you take in the audiotory world around you. \n" +
                        "It is mostly a reverberating, undulating howl, haunting in its flatness yet majestic in its unfathomable scale. At least it is something.");
                    player.XpUntilNextLevel = 40;
                    break;
                case 4:
                    player.XpUntilNextLevel = 60;
                    break;
                case 5:
                    player.XpUntilNextLevel = 80;
                    break;
                case 6:
                    player.XpUntilNextLevel = 900;
                    break;
                case 7:
                    player.XpUntilNextLevel = 1500;
                    break;
                case 8:
                    player.XpUntilNextLevel = 2000;
                    break;
                case 9:
                    player.XpUntilNextLevel = 3000;
                    break;
                case 10:
                    player.XpUntilNextLevel = 6000;
                    break;
            }
            
        }

        public static void Upgrade()
        {
        }
    }
}
