using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{
    public struct Ability
    {
        private int _score;
        private int _mod;
        private int _save;

        public Ability(int score)
        {
            _score = score;
            _mod = -100;
            _save = -100;
        }

        public int score
        {
            get
            {
                return _score;
            }
        }

        public int save
        {
            get
            {
                return _save;
            }
        }

        public int mod
        {
            get
            {
                return _mod;
            }
        }
    }

    public enum E_Abil
    {
        STRENGTH,
        INTELIGENCE,
        DEXTERITY,
        WISDOM,
        CONSTITUTION,
        CHARISMA
    }
}