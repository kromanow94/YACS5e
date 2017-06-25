using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{

    public class Elf : Race
    {
        private SubRace _subRace;
        private BaseStatsType _baseStats;
        private System.Collections.Generic.List<String> languages;
        private Dictionary<String, TraitClassType> _traits;
        private System.Collections.Generic.Dictionary<YACS5e.E_Attr, Attribute> _baseAttr;

        BaseStatsType Race.BaseStats
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

        System.Collections.Generic.Dictionary<YACS5e.E_Attr, Attribute> Race.BaseAttr
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

        SubRace Race.SubRace
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

        Dictionary<string, TraitClassType> Race.Traits
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

        List<string> Race.getLanguages()
        {
            throw new NotImplementedException();
        }
    }

    public class HighElf : SubRace
    {
        private System.Collections.Generic.Dictionary<YACS5e.E_Attr, YACS5e.Attribute> _subAttr;

        Dictionary<E_Attr, Attribute> SubRace.SubAttr
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
    }
}