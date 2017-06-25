using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{
    public class Character
    {
        private Race race;

        public void SetRace()
        {
            race = new Elf();
            race.BaseAttr.Add(E_Attr.constitution, new Attribute());
            race.BaseStats.BaseSpeed = 1;
            race.Traits.Add("barbarian", new TraitClassType());
            race.SubRace = new HighElf();
            race.SubRace.SubAttr.Add(E_Attr.charisma, new Attribute(10));
        }
    }
}