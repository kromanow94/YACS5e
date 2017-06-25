using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{
    public class CharacterClass
    {
        private int _lvl;
        private System.Collections.Generic.Dictionary<string, YACS5e.TraitClassType> _traits;
        private SubClass _subClass;
        private string _className;
        private List<Skill> _skills;

        public CharacterClass(string className)
        {
            throw new System.NotImplementedException();
        }

        public int lvl
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public System.Collections.Generic.Dictionary<string, YACS5e.TraitClassType> traits
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public SubClass subClass
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string className
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public System.Collections.Generic.List<YACS5e.Skill> skills
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

    public class SubClass
    {
        private System.Collections.Generic.Dictionary<string, YACS5e.TraitClassType> _traits;
        private string _pathName;

        private List<Skill> _skills;

        public SubClass(string pathName)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.Dictionary<string, YACS5e.TraitClassType> traits
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string pathName
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public System.Collections.Generic.List<YACS5e.Skill> skills
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

    public class Skill
    {
        private string _name;
        private int _bonus;

        public string name
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int bonus
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