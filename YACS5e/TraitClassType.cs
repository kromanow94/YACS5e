using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{
    public class TraitClassType
    {
        private String flavour_text;
        private Bonus bonus;
    }

    internal class Bonus
    {
        private int mod;
        private int usesMax;
        private int usesLeft;
        private bool abilityScore;
        private bool skill;
        private bool st;
    }
}