using Game.Character;
using Game.Mechanics;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Setup.Setup newGame = new Setup.Setup();
            newGame.PrintMainMenu(Battle.player);
        }
    }
}
