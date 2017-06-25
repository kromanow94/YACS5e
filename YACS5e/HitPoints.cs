using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{
    public class HitPoints
    {
        private int _maxRaw;
        private int _temporary;
        private List<int> _deathST;
        private int _currentRaw;
        private List<HitDice> _hitDice;

        /// <summary>
        /// = maxRaw + consMod
        /// </summary>
        public int maxRaw
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
        public string current
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public System.Collections.Generic.List<YACS5e.HitDice> hitDice
        {
            get { return this._hitDice; }
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
            this.regainHitDice();
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// checklist
        /// </summary>
        public void regainHitDice()
        {
            throw new System.NotImplementedException();
        }
    }

    public struct HitDice
    {
        public HitDice(int size)
        {
            this.size = size;
            this.used = false;
        }

        public int size { get; }
        public bool used { get; set; }
    }
}