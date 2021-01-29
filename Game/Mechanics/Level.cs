using Game.Character;
using Game.Character.Enemy.Enemies;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using Game.Setup;

namespace Game.Mechanics
{
    public class Level
    {

        public static void LevelUp(Player player)
        {

            player.Level += 1;
            Console.WriteLine($"You have leveled up to level {player.Level}. You feel refreshed and a will to struggle on.");
            Setup.Setup.ContinueAndClear();

            switch (player.Level)
            {
                case 2:
                    player.XpUntilNextLevel = 20;
                    break;
                case 3:

                    Console.WriteLine("You realise with a shock that you now can hear.\n Tears of relief flood your eyes as you take in the audiotory world around you. \n" +
                        "It is mostly a reverberating, ululating howl, haunting in its flatness yet majestic in its unfathomable scale. At least it is something.  \n");
                    Design.Color.FontColor("~[You have acquired the sense of hearing]~\n" +
                     "~[You have acquired the ability to meditate in order better yourself by spending Energy acquired from defeated enemies]~");


                    player.XpUntilNextLevel = 40;
                    Setup.Setup.listOfSavedGames.Add(new SaveGame(player));
                    Setup.Setup.ContinueAndClear();
                    break;
                case 4:
                    player.XpUntilNextLevel = 60;
                    break;
                case 5:

                    Console.WriteLine("Up until now you have been totally blind.\n A searing flash inside your mind, and when the shock subsides, you can dimly make out your surroundings.\n" +
                        "It is dark and shapeless. Not even black, just void of color.\n At an indefinable distance all around you, something smokelike swirls and eddies. You shudder.\n");
                    Design.Color.FontColor("~[You have acquired the sense of seeing. You can now meditate to get better vision level]~\n");
                    player.XpUntilNextLevel = 80;
                    Setup.Setup.listOfSavedGames.Add(new SaveGame(player));
                    Setup.Setup.ContinueAndClear();
                    break;


                case 6:
                    player.XpUntilNextLevel = 90;
                    break;
                case 7:
                    player.Taste = true;
                    Console.WriteLine("You suddenly can taste again!\n It feels wonderful, up until now your tastebuds have felt turned off.\n You think about all the vials" +
                        " you have collected... maybe you would dare to drink one now?\n Your mouth sure is parched, and maybe the content of the vials can remedy your low health?");
                    Design.Color.FontColor("~[You have acquired the sense of taste. You can now dare to drink the contents of vials]~\n");
                    player.XpUntilNextLevel = 110;
                    Setup.Setup.listOfSavedGames.Add(new SaveGame(player));
                    Setup.Setup.ContinueAndClear();
                    break;
                case 8:
                    player.XpUntilNextLevel = 140;
                    break;
                case 9:
                    Console.WriteLine("You feel something bad is going to happen... A deafening quiet descends.");
                    player.XpUntilNextLevel = 170;
                    Setup.Setup.ContinueAndClear();
                    break;
                case 10:
                    player.Smell = true;
                    Console.WriteLine("You feel that you have reached the highest level of being in this Void. You have defeated The Maker Of Nightmares.");
                    Setup.Setup.ContinueAndClear();
                    Console.WriteLine("You are no longer afraid. You slowly realise that you can smell something...");
                    Setup.Setup.ContinueAndClear();
                    Console.WriteLine("You recognize it, but cannot place it. It is a pleasant smell...");
                    Setup.Setup.ContinueAndClear();
                    Console.WriteLine("You stumble towards it. It reminds you of something, someone...");
                    Setup.Setup.ContinueAndClear();
                    Console.WriteLine("You continue walking towards the scent as it gets stronger and stronger...");
                    Setup.Setup.ContinueAndClear();
                    Console.WriteLine("Now you recognize it! It is the scent of your partner's perfume! You start running...");
                    Setup.Setup.ContinueAndClear();
                    Console.WriteLine("Suddenly you hit an invisible wall headfirst! The crash is worldbreaking, and you are jolted awake screaming in your bed!");
                    Setup.Setup.ContinueAndClear();
                    Console.WriteLine("Your partner is awokened by your scream, bewildered and confused, and holds you, asking \"what's wrong honey?\"");
                    Setup.Setup.ContinueAndClear();
                    Console.WriteLine("\"Ahh... I don't know. It was just a bad dream...\"");
                    Console.ReadLine();
                    Console.Clear();
                    Setup.Setup.isRunning = false;
                    break;
            }

        }

        public static void Upgrade(Player player)
        {

            Console.WriteLine("You shakily sit down and try to get your breathing under control. It feels good, and you think about what could better your odds of getting through this alive.");
            Design.Color.FontColor($"~[Your Energy level is {player.Energy}. You can spend this Energy to upgrade yourself senses]~ \n\n");

            if (player.Level >= 3 && player.Level < 5)
            {
                Console.Write("[1] Hearing level upgrade (Consumes 50 Energy)"); Design.Color.FontColor("~[Higher hearing level means you get better defensive abilities by listening to the echo of your enemies' movements]~\n");
                Console.WriteLine("[2] Get up and get back to roaming");
                int upgradeChoice = Setup.Setup.ConfirmCorrectInput(2);
                switch (upgradeChoice)
                {
                    case 1:
                        if (player.Energy >= 50)
                        {
                            player.Hearing++;
                            player.Energy -= 50;
                            Console.WriteLine($"Your hearing level increased, and is now {player.Hearing}. You consumed 50 Energy.");
                            Setup.Setup.ContinueAndClear();
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough Energy for this!");
                            Setup.Setup.ContinueAndClear();
                        }
                        break;
                    case 2:
                        break;

                }
            }

            else if (player.Level >= 5)
            {
                Console.Write("[1] Hearing level upgrade (Consumes 50 Energy)"); Design.Color.FontColor("~[Higher hearing level means you get better defensive abilities by listening to the echo of your enemies' movements]~\n");
                Console.Write("[2] Vision level upgrade (Consumes 50 Energy)"); Design.Color.FontColor("~[Higher vision level means you get better offensive abilities by better seeing your enemies' week spots]~\n");
                Console.WriteLine("[3] Get up and get back to roaming");
                int upgradeChoice = Setup.Setup.ConfirmCorrectInput(3);
                switch (upgradeChoice)
                {
                    case 1:
                        if (player.Energy >= 50)
                        {
                            player.Hearing++;
                            player.Energy -= 50;
                            Console.WriteLine($"Your hearing level increased, and is now {player.Hearing}. You consumed 50 Energy.");
                            Setup.Setup.ContinueAndClear();
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough Energy for this!");
                            Setup.Setup.ContinueAndClear();
                        }
                        break;
                    case 2:
                        if (player.Energy >= 50)
                        {
                            player.Vision++;
                            player.Energy -= 50;
                            Console.WriteLine($"Your vision level increased, and is now {player.Vision}. You consumed 50 Energy.");
                            Setup.Setup.ContinueAndClear();
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough Energy for this!");
                            Setup.Setup.ContinueAndClear();
                        }
                        break;
                    case 3:
                        break;

                }

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
                    Setup.Setup.ContinueAndClear();
                    break;
                }
                else if (liquidPoison > 5)
                {
                    liquidPoison = Setup.Setup.random.Next(1, 11);
                    player.Hp -= 20;
                    Console.Write("It tastes incredibly foul and bitter, and you immediately spit it out. You feel weakened."); Design.Color.FontColor($"~[Your health drops with 20 points, and is now {player.Hp}]~\n");
                    Console.WriteLine("Do you dare try another vial? The next one might be better for you... (y/n)");
                    choice = Console.ReadLine();
                    Console.Clear();
                }

            }


        }

    }
}
