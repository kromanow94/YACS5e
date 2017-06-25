using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{

    public class Race
    {
        private string _subRace;
        private BaseStats _baseStats;
        private System.Collections.Generic.List<String> _languages;
        private Dictionary<String, ClassTraits> _traits;
        private System.Collections.Generic.Dictionary<YACS5e.E_Abil, Ability> _abilities;
        private String _raceName;

        public Race(string raceName)
        {
            throw new System.NotImplementedException();
        }

        public BaseStats baseStats
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

        public string subRace
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

        public Dictionary<string, ClassTraits> traits
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
}