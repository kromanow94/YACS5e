using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{
    public class Character
    {
        private Race _race;
        private List<CharacterClass> _characterClass;
        /// <summary>
        /// = init + lvlUp
        /// </summary>
        private System.Collections.Generic.Dictionary<YACS5e.E_Abil, YACS5e.Ability> _abilities;
        private List<string> _proficiencies;
        private List<string> _equipment;
        private List<string> _features;
        private System.Collections.Generic.List<ClassTraits> _racialTraits;
        private HitPoints _hitPoints;
        private List<string> _languages;

        private List<Skill> _skills;

        public string name { get; }
        public string background { get; }


        /// <summary>
        /// gettery i settery wystarczą
        /// </summary>
        /// <param name="race">merge</param>
        /// <param name="subrace">merge</param>
        public Character(string race, string subrace, string classType, string background, System.Collections.Generic.Dictionary<YACS5e.E_Abil, YACS5e.Ability> abilities, System.Collections.Generic.List<YACS5e.Skill> skills, HitPoints hitPoints, List<string> equipment)
        {
            throw new System.NotImplementedException();
        }

        public Race race
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public System.Collections.Generic.List<YACS5e.CharacterClass> characterClass
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// = sum *ab
        /// </summary>
        public System.Collections.Generic.Dictionary<YACS5e.E_Abil, YACS5e.Ability> abilities
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<String> proficiencies
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<string> equipment
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<String> features
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public System.Collections.Generic.List<YACS5e.ClassTraits> racialTraits
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        

        public HitPoints hitPoints
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<string> languages
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<Skill> skills
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void SetRace()
        {
            race = new Race("Elf");
            race.baseAbilities.Add(E_Abil.CONSTITUTION, new Ability());
            race.baseStats.baseSpeed = 1;
            race.traits.Add("poison resistance", new ClassTraits());

            hitPoints.hitDice[0];
            //hitPoints.hitDice.Add

            //characterClass = new CharacterClass("Paladin");
            //characterClass.subClass = new SubClass("Holy");

            //race.subRace.
        }

        private int _lvl;

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
    }

   
}