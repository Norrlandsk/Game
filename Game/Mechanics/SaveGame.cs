using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Mechanics
{
   public class SaveGame
    {
        private string savedName;
        private int savedLevel;


        public string SavedGame { get => Battle.player.Name; set => savedName = value; }
        public int SavedLevel { get => Battle.player.Level; set => savedLevel = value; }


        /*int savedXp = xp;
        int savedHp = Hp;
        int savedMaxHp = maxHp;
        int savedEnergy = energy;
        int savedAttack = attack;
        int savedXpUntilNextLevel = xpUntilNextLevel;
        int savedVial = vial;

        int savedHearing = hearing;
        int savedVision = vision;
        bool savedTaste = taste;
        bool savedSmell = smell;

        bool savedDead = dead;
        bool savedAwake = awake;*/





        
    }
}
