using Game.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Mechanics
{
   public class SaveGame
    {
        private string savedName;
        private int savedLevel;
        private int savedXp;
        private int savedHp;
        private int savedMaxHp;
        private int savedEnergy;
        private int savedAttack;
        private int savedXpUntilNextLevel;
        private int savedVial;

        private int savedHearing;
        private int savedVision;
        private bool savedTaste;
        private bool savedSmell;

        private bool savedDead;
        private bool savedAwake;

        public SaveGame(Player player)
        {
            this.savedName = player.Name;
            this.savedLevel = player.Level;
            this.savedXp = player.Xp;
            this.savedHp = player.Hp;
            this.savedMaxHp = player.MaxHp;
            this.savedEnergy = player.Energy;
            this.savedAttack = player.Attack;
            this.savedXpUntilNextLevel = player.XpUntilNextLevel;
            this.savedVial = player.Vial;

            this.savedHearing = player.Hearing;
            this.savedVision = player.Vision;
            this.savedTaste = player.Taste;
            this.savedSmell = player.Smell;

            this.savedDead = player.Dead;
            this.savedAwake = player.Awake;
        }

        
        public string SavedName { get => savedName;}
        public int SavedLevel { get => savedLevel;}
        public int SavedXp { get => savedXp; }
        public int SavedHp { get => savedHp; }
        public int SavedMaxHp { get => savedMaxHp; }
        public int SavedEnergy { get => savedEnergy; }
        public int SavedAttack { get => savedAttack; }
        public int SavedXpUntilNextLevel { get => savedXpUntilNextLevel; }
        public int SavedVial { get => savedVial; }

        public int SavedHearing { get => savedHearing; }
        public int SavedVision { get => savedVision; }
        public bool SavedTaste { get => savedTaste; }
        public bool SavedSmell { get => savedSmell; }

        public bool SavedDead { get => savedDead; }
        public bool SavedAwake { get => savedAwake; }

    }








    }

