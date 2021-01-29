using Game.Character;
using Game.Character.Enemy;
using Game.Character.Enemy.Enemies;
using Game.Design;
using Game.Mechanics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Setup
{
    class Setup
    {

        public static bool isRunning = true;
        public static Random random = new Random();
        public static List<SaveGame> listOfSavedGames = new List<SaveGame>();


        public static List<IEnemy> enemyList = new List<IEnemy>();



        public void PrintMainMenu(Player player)
        {
            Console.WriteLine("You are suddenly aware. You do not know where you are. You cannot see nor hear anything.\n You feel an immense dread that will not let go...");
            ContinueAndClear();
            Console.WriteLine("You think to yourself, \"where am I? Surely this must be a nightmare? WHO am I? \"");
            ContinueAndClear();

            Design.Color.FontColor("~[What is your name?]~\n");
            string givenName = Console.ReadLine();
            player.Name = givenName;
            Console.Clear();
            while (isRunning)
            {

                if (player.Level < 3)
                {
                    Console.Write($"[1] Try to awaken "); Design.Color.FontColor("~[Fight your way through this nightmare]~\n");
                    Console.Write("[2] Hold up for a second to get your bearings "); Design.Color.FontColor("~[Get the deets about your predicament]~\n");
                    Console.Write("[3] Give up and accept your fate "); Design.Color.FontColor("~[Quitters never win (and quitters never wake up from this nightmare)]~\n");

                    int userChoice = ConfirmCorrectInput(3);

                    switch (userChoice)
                    {
                        case 1:
                            Console.Clear();
                            Battle.Roam();
                            break;
                        case 2:
                            Console.Clear();
                            Player.ShowInfo(Battle.player);
                            break;
                        case 3:
                            Console.Clear();
                            GiveUp();
                            break;


                    }
                }




                else if (player.Level >=3 && player.Level <7)
                {
                    Console.Write($"[1] Try to awaken "); Design.Color.FontColor("~[Fight your way through this nightmare]~\n");
                    Console.Write("[2] Hold up for a second to get your bearings "); Design.Color.FontColor("~[Get the deets about your predicament]~\n");
                    Console.Write("[3] Meditate on ways to solve all this"); Design.Color.FontColor("~[Better yourself by spending Energy acquired from defeated enemies]~\n");
                    Console.Write("[4] Give up and accept your fate "); Design.Color.FontColor("~[Quitters never win (and quitters never wake up from this nightmare)]~\n");


                    int userChoice = ConfirmCorrectInput(4);

                    switch (userChoice)
                    {
                        case 1:
                            Console.Clear();
                            Battle.Roam();
                            break;
                        case 2:
                            Console.Clear();
                            Player.ShowInfo(Battle.player);
                            break;
                        case 3:
                            Console.Clear();
                            Level.Upgrade(Battle.player);
                            break;
                        case 4:
                            Console.Clear();
                            GiveUp();
                            break;

                    }
                }

                else if (player.Level >= 7)
                {
                    Console.Write("[1] Try to awaken "); Design.Color.FontColor("~[Fight your way through this nightmare]~\n");
                    Console.Write("[2] Hold up for a second to get your bearings "); Design.Color.FontColor("~[Get the deets about your predicament]~\n");
                    Console.Write("[3] Meditate on ways to solve all this"); Design.Color.FontColor("~[Better yourself by spending Energy acquired from defeated enemies]~\n");
                    Console.Write("[4] Try the content of a vial"); Design.Color.FontColor("~[They have to be good for something, right?]~\n");
                    Console.Write("[5] Give up and accept your fate "); Design.Color.FontColor("~[Quitters never win (and quitters never wake up from this nightmare)]~\n");


                    int userChoice = ConfirmCorrectInput(5);

                    switch (userChoice)
                    {
                        case 1:
                            Console.Clear();
                            Battle.Roam();
                            
                            break;
                        case 2:
                            Console.Clear();
                            Player.ShowInfo(Battle.player);
                            break;
                        case 3:
                            Console.Clear();
                            Level.Upgrade(Battle.player);
                            break;
                        case 4:
                            Console.Clear();
                            Level.TryVial(Battle.player);
                            break;
                        case 5:
                            Console.Clear();
                            GiveUp();
                            break;

                    }
                }
                






            }
        }
        private void GiveUp()
        {
            Console.WriteLine("Are you sure you just going to give up? y/n");
            string choice = Console.ReadLine();
            Console.Clear();
            if (choice.ToUpper() == "Y")
            {
                Console.WriteLine("Alas! You have chosen to forever roam this Void!");
                isRunning = false;
            }
        }
        public static int ConfirmCorrectInput(int allowedRange)
        {

            int confirmedChoice;
            do
            {
                //User prompt
                string menuChoiceString = Console.ReadLine();


                bool successfulConversion = Int32.TryParse(menuChoiceString, out confirmedChoice);

                //IF TryParse() successfully parses menuChoiceString, AND the variable is within allowed range of the menu in question: break out of DO WHILE loop and RETURN confirmedChoice
                if (successfulConversion && confirmedChoice <= allowedRange)
                {


                    break;
                }

                //ELSE IF user previously pressed Enter (in the case of changing screens with EraseAndContinue() method). This ensures that ELSE case is not entered unwanted
                else if (menuChoiceString == "")
                {

                    break;
                }

                //ELSE if user input is either out of range of menu or not a number, continue DO WHILE loop 
                else
                {

                    Console.Write("Get your shit together and try another option!");

                }


            } while (true);
            return confirmedChoice;
        }

        public static List<IEnemy> SetupEnemyList(Player player)
        {
            if (player.Level >= 1)
            {
                ScreamingShadow screamingShadow = new ScreamingShadow();
                ManWithoutFace manWithoutFace = new ManWithoutFace();
                enemyList.Add(screamingShadow);
                enemyList.Add(manWithoutFace);
            }

            if (player.Level >= 2)
            {
                AManWithAHorseFace aManWithAHorseFace = new AManWithAHorseFace();
                GrinningToothlessHag grinningToothlessHag = new GrinningToothlessHag();
                enemyList.Add(grinningToothlessHag);
                enemyList.Add(aManWithAHorseFace);
            }

            if (player.Level >= 3)
            {
                AbominableCreature abominableCreature = new AbominableCreature();
                ANameLessHorror aNameLessHorror = new ANameLessHorror();
                enemyList.Add(aNameLessHorror);
                enemyList.Add(abominableCreature);
            }

            if (player.Level >= 4)
            {
                MaliciousGhost maliciousGhost = new MaliciousGhost();
                SnelHest snelHest = new SnelHest();
                enemyList.Add(maliciousGhost);
                enemyList.Add(snelHest);
            }
            if (player.Level >= 5)
            {
                OompaLoompa oompaLoompa = new OompaLoompa();
                GarglingGoblin garglingGoblin = new GarglingGoblin();
                enemyList.Add(oompaLoompa);
                enemyList.Add(garglingGoblin);
            }
            if (player.Level >= 6)
            {
                EliteManWithoutFace eliteManWithoutFace = new EliteManWithoutFace();
                EliteScreamingShadow eliteScreamingShadow = new EliteScreamingShadow();
                enemyList.Add(eliteManWithoutFace);
                enemyList.Add(eliteScreamingShadow);

            }
            if (player.Level >= 7)
            {
                EliteAManWithAHorseFace eliteAManWithAHorseFace = new EliteAManWithAHorseFace();
                EliteGrinningToothlessHag eliteGrinningToothlessHag = new EliteGrinningToothlessHag();
                enemyList.Add(eliteAManWithAHorseFace);
                enemyList.Add(eliteGrinningToothlessHag);

            }
            if (player.Level >= 8)
            {
                EliteGarglingGoblin eliteGarglingGoblin = new EliteGarglingGoblin();
                EliteOompaLoompa eliteOompaLoompa = new EliteOompaLoompa();
                enemyList.Add(eliteGarglingGoblin);
                enemyList.Add(eliteOompaLoompa);

            }



            return enemyList;
        }
        public static void ContinueAndClear()
        {
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        
    }

}
