using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{
    public class CharacterClass
    {
        private int _lvl;
        private System.Collections.Generic.Dictionary<string, YACS5e.ClassTraits> _traits;
        private string _pathName;
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

        public System.Collections.Generic.Dictionary<string, YACS5e.ClassTraits> traits
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string subClass
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

}