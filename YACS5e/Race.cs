using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{

    public interface Race
    {
        BaseStatsType BaseStats { get; set; }
        SubRace SubRace { get; set; }
        System.Collections.Generic.Dictionary<E_Attr, Attribute> BaseAttr { get; set; }
        Dictionary<String, TraitClassType> Traits { get; set; }
        System.Collections.Generic.List<string> getLanguages();
    }

    public class BaseStatsType
    {
        private int _baseSpeed;
        private int _darkvision;

        public int BaseSpeed
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int Darkvision
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

    public interface SubRace
    {
        System.Collections.Generic.Dictionary<YACS5e.E_Attr, Attribute> SubAttr { get; set; }
    }

    public enum E_Attr
    {
        strength,
        inteligence,
        dexterity,
        wisdom,
        constitution,
        charisma
    }

    public struct Attribute
    {
        private int _score;
        private int _mod;
        private int _save;

        public Attribute(int score)
        {
            _score = score;
            _mod = -100;
            _save = -100;
        }

        public int Score
        {
            get
            {
                return _score;
            }
        }

        public int Save
        {
            get
            {
                return _save;
            }
        }

        public int Mod
        {
            get
            {
                return _mod;
            }
        }
    }
}