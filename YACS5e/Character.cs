using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{
    public class Character
    {
        private Race _race;
        private CharacterClass _characterClass;
        private Background _background;
        /// <summary>
        /// = init + lvlUp
        /// </summary>
        private System.Collections.Generic.Dictionary<YACS5e.E_Abil, YACS5e.Ability> _abilities;
        private List<string> _proficiencies;
        private List<string> _equipment;
        private List<string> _features;
        private List<string> _racialTraits;
        private string _name;
        private HitPoints _hitPoints;

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

        public CharacterClass characterClass
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Background background
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

        public List<String> racialTraits
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

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

        public void SetRace()
        {
            race = new Race("Elf");
            race.baseAbilities.Add(E_Abil.constitution, new Ability());
            race.baseStats.baseSpeed = 1;
            race.traits.Add("poison resistance", new TraitClassType());
            race.subRace = new Subrace("High Elf");
            race.subRace.subAbilities.Add(E_Abil.charisma, new Ability(10));

            characterClass = new CharacterClass("Paladin");
            characterClass.subClass = new SubClass("Holy");
        }
    }

    public class HitPoints
    {
        private int _maxRaw;
        private int _temporary;
        private int _savingThrowGood;
        private int _savingThrowBad;
        private int _consMod;
        private int _currentRaw;

        /// <summary>
        /// = maxRaw + consMod
        /// </summary>
        public int max
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
        /// = currentRaw + temporary
        /// </summary>
        public int current
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void savingThrow(bool good)
        {
            throw new System.NotImplementedException();
        }

        public void resurrection()
        {
            throw new System.NotImplementedException();
        }

        public void damage(int hp)
        {
            throw new System.NotImplementedException();
        }

        public void heal(int hp)
        {
            throw new System.NotImplementedException();
        }

        public void addTemporaryHp(int hp)
        {
            throw new System.NotImplementedException();
        }

        public void addMaxHp(int hp)
        {
            throw new System.NotImplementedException();
        }

        public void longRest()
        {
            throw new System.NotImplementedException();
        }
    }
}