using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{
    public class Skill
    {
        public string name { get; }

        private E_SkillProf _prof;
        private E_Advantage _advantage;

        public E_Advantage advantage
        {
            get
            {
                return this._advantage;
            }

            set
            {
                if (value > 0)
                {
                    this._advantage = E_Advantage.ADV;
                }
                else if (value < 0)
                {
                    this._advantage = E_Advantage.DISADV;
                }
                else
                {
                    this._advantage = E_Advantage.NONE;
                }
            }
        }

        public Skill(string name)
        {
            this.name = name;
        }
    }
    public enum E_SkillProf
    {
        NONE,
        PROF,
        EXPERT,
        JACK
    }

    public enum E_Advantage
    {
        DISADV = -1,
        NONE = 0,
        ADV = 1
    }
}