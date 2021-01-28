using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Design
{
    class Color
    {
        public static void FontColor(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(value);
            Console.ResetColor();
        }
    }
}
