using Game.Character;
using Game.Character.Enemy;
using Game.Character.Enemy.Enemies;
using Game.Mechanics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Setup
{
    class Setup
    {

        bool isRunning = true;
        
        

        public void PrintMainMenu()
        {
           
            while (isRunning)
            {
                Console.WriteLine("[1] Try to awaken");
                Console.WriteLine("[2] Contemplate about situation");
                Console.WriteLine("[3] Meditate on ways to solve all this");
                Console.WriteLine("[4] Give up and accept your fate");

                int userChoice = ConfirmCorrectInput(4);

                switch (userChoice)
                {
                    case 1:
                        Battle.Roam();
                       
                        break;
                    case 2:
                        Level.ShowInfo();
                        break;
                    case 3:
                        Level.Upgrade();
                        break;
                    case 4:
                        GiveUp();
                        
                        break;
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

        public static List<IEnemy> SetupEnemyList()
        {

            List<IEnemy> enemyList = new List<IEnemy>();
            ScreamingShadow screamingShadow = new ScreamingShadow();
            ManWithoutFace manWithoutFace = new ManWithoutFace();
            enemyList.Add(screamingShadow);
            enemyList.Add(manWithoutFace);

            return enemyList;
        }


    }
}
