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


        public static List<IEnemy> enemyList = new List<IEnemy>();



        public void PrintMainMenu(Player player)
        {

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
                            Battle.Roam();
                            break;
                        case 2:
                            Player.ShowInfo(Battle.player);
                            break;
                        case 3:
                            GiveUp();
                            break;

                    }
                }




                else if (player.Level < 7)
                {
                    Console.Write($"[1] Try to awaken "); Design.Color.FontColor("~[Fight your way through this nightmare]~\n");
                    Console.Write("[2] Hold up for a second to get your bearings "); Design.Color.FontColor("~[Get the deets about your predicament]~\n");
                    Console.Write("[3] Meditate on ways to solve all this"); Design.Color.FontColor("~[Better yourself by spending Energy acquired from defeated enemies]~");
                    Console.Write("[4] Give up and accept your fate "); Design.Color.FontColor("~[Quitters never win (and quitters never wake up from this nightmare)]~\n");


                    int userChoice = ConfirmCorrectInput(4);

                    switch (userChoice)
                    {
                        case 1:
                            Battle.Roam();

                            break;
                        case 2:
                            Player.ShowInfo(Battle.player);
                            break;
                        case 3:
                            Level.Upgrade(Battle.player);
                            break;
                        case 4:
                            GiveUp();

                            break;
                    }
                }

                else if (player.Level > 6)
                {
                    Console.Write("[1] Try to awaken "); Design.Color.FontColor("~[Fight your way through this nightmare]~\n");
                    Console.Write("[2] Hold up for a second to get your bearings "); Design.Color.FontColor("~[Get the deets about your predicament]~\n");
                    Console.Write("[3] Meditate on ways to solve all this"); Design.Color.FontColor("~[Better yourself by spending Energy acquired from defeated enemies]~");
                    Console.Write("[4] Try the content of a vial"); Design.Color.FontColor("~[They have to be good for something, right?]~");
                    Console.Write("[5] Give up and accept your fate "); Design.Color.FontColor("~[Quitters never win (and quitters never wake up from this nightmare)]~\n");


                    int userChoice = ConfirmCorrectInput(4);

                    switch (userChoice)
                    {
                        case 1:
                            Battle.Roam();

                            break;
                        case 2:
                            Player.ShowInfo(Battle.player);
                            break;
                        case 3:
                            Level.Upgrade(Battle.player);
                            break;
                        case 4:
                            Level.TryVial(Battle.player);
                            break;
                        case 5:
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
            if (choice.ToUpper() == "Y")
            {
                isRunning = false;
            }
        }
        private int ConfirmCorrectInput(int allowedRange)
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
                enemyList.Add(maliciousGhost);
            }
            if (player.Level >= 5)
            {
                MaliciousGhost maliciousGhost = new MaliciousGhost();
                enemyList.Add(maliciousGhost);
            }
            if (player.Level >= 6)
            {
                MaliciousGhost maliciousGhost = new MaliciousGhost();
                enemyList.Add(maliciousGhost);
            }
            if (player.Level >= 7)
            {
                MaliciousGhost maliciousGhost = new MaliciousGhost();
                enemyList.Add(maliciousGhost);
            }
            if (player.Level >= 8)
            {
                MaliciousGhost maliciousGhost = new MaliciousGhost();
                enemyList.Add(maliciousGhost);
            }
            if (player.Level >= 9)
            {
                MaliciousGhost maliciousGhost = new MaliciousGhost();
                enemyList.Add(maliciousGhost);
            }

            return enemyList;
        }
    }
}
