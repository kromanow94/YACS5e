using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{

    public class Race
    {
        private Subrace _subRace;
        private BaseStatsType _baseStats;
        private System.Collections.Generic.List<String> _languages;
        private Dictionary<String, TraitClassType> _traits;
        private System.Collections.Generic.Dictionary<YACS5e.E_Abil, Ability> _baseAbilities;
        private String _raceName;

        public Race(string raceName)
        {
            throw new System.NotImplementedException();
        }

        public BaseStatsType baseStats
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Collections.Generic.Dictionary<YACS5e.E_Abil, Ability> baseAbilities
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Subrace subRace
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }

        }

        public Dictionary<string, TraitClassType> traits
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public String raceName
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public System.Collections.Generic.List<string> languages
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }

    public class BaseStatsType
    {
        private int _baseSpeed;
        private int _darkvision;

        public int baseSpeed
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int darkvision
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }

    public class Subrace
    {
        private System.Collections.Generic.Dictionary<YACS5e.E_Abil, YACS5e.Ability> _subAbilities;
        private String _subRaceName;

        public Subrace(string subRaceName)
        {
            throw new System.NotImplementedException();
        }

        public Dictionary<E_Abil, Ability> subAbilities
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string subRaceName
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }

    public enum E_Abil
    {
        strength,
        inteligence,
        dexterity,
        wisdom,
        constitution,
        charisma
    }

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
}