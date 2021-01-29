using Game.Character;
using Game.Character.Enemy.Enemies;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Game.Mechanics
{
    public class Level
    {

        public static void LevelUp(Player player)
        {

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
                        "It is mostly a reverberating, undulating howl, haunting in its flatness yet majestic in its unfathomable scale. At least it is something.  \n" +
                        "~[You have acquired the sense of hearing]~" +
                        "~[You have acquired the ability to meditate in order better yourself by spending Energy acquired from defeated enemies]~");


                    player.XpUntilNextLevel = 40;
                    Setup.Setup.listOfSavedGames.Add(new SaveGame(player));
                    break;
                case 4:
                    player.XpUntilNextLevel = 60;
                    break;
                case 5:
                    player.Vision += 1;
                    Console.WriteLine("Up until now");

                    player.XpUntilNextLevel = 80;
                    Setup.Setup.listOfSavedGames.Add(new SaveGame(player));
                    break;
                case 6:
                    player.XpUntilNextLevel = 90;
                    break;
                case 7:
                    player.Taste = true;

                    player.XpUntilNextLevel = 110;
                    Setup.Setup.listOfSavedGames.Add(new SaveGame(player));
                    break;
                case 8:
                    player.XpUntilNextLevel = 140;
                    break;
                case 9:
                    player.Smell = true;
                    player.XpUntilNextLevel = 3000;
                    break;
                case 10:
                    player.XpUntilNextLevel = 6000;
                    break;
            }

        }

        public static void Upgrade(Player player)
        {

            Console.WriteLine("You shakily sit down and try to get your breathing under control. It feels good, and you think about what could better your odds of getting through this alive.");
            Design.Color.FontColor($"~[Your Energy level is {player.Energy}. You can spend this Energy to upgrade yourself senses]~ \n\n");

            if (player.Level >= 3)
            {
                Console.Write("[1] Hearing level upgrade (Consumes 50 Energy)"); Design.Color.FontColor("~[Higher hearing level means you get better defensive abilities by listening to the echo of your enemies' movements]~\n");
            }

            if (player.Level >= 5)
            {
                Console.Write("[2] Vision level upgrade (Consumes 50 Energy)"); Design.Color.FontColor("~[Higher vision level means you get better offensive abilities by better seeing your enemies' week spots]~\n");
            }

            if (player.Level >= 7)
            {
                Console.Write("[3] Try drinking the content of a vial"); Design.Color.FontColor("~[It might restore some health? On the other hand, it might kill you!]~\n");
            }

        }

        public static void TryVial(Player player)
        {
            int liquidPoison = Setup.Setup.random.Next(1, 11);

            Console.WriteLine("Are you sure you want to try this? It might kill you, you know... (y/n)");
            string choice = Console.ReadLine();
            while (choice.ToUpper() == "Y")
            {
                
                Console.WriteLine("You uncork the vial. Inside is an oily, clear liquid. You take a sip...");

                if (liquidPoison <= 5)
                {
                    player.Hp = player.MaxHp;
                    Console.Write("It tastes so good it is unreal, and you empty the vial. You feel rejuvenated!"); Design.Color.FontColor("~[Your health is fully restored!]~\n");
                    Console.ReadLine();
                    break;
                }
                else if (liquidPoison > 5)
                {
                    liquidPoison = Setup.Setup.random.Next(1, 11);
                    player.Hp -= 20;
                    Console.Write("It tastes incredibly foul and bitter, and you immediately spit it out. You feel weakened."); Design.Color.FontColor($"~[Your health drops with 20 points, and is now {player.Hp}]~\n");
                    Console.WriteLine("Do you dare try another vial? The next one might be better for you... (y/n)");
                    choice = Console.ReadLine();
                }

            }
            

        }

    }
}
