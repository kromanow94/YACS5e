using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{
    public class Campaign
    {
        private string _plot;
        private User author;
        /// <summary>
        /// sort list?
        /// </summary>
        private List<CampaignCharacter> _characters;
        private string _title;

        public Campaign(string title)
        {
            throw new System.NotImplementedException();
        }

        public string plot
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public System.Collections.Generic.List<YACS5e.CampaignCharacter> characters
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string title
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void addCharacter(string login, string characterName)
        {
            throw new System.NotImplementedException();
        }

        public void removeCharacter(string characterName)
        {
            throw new System.NotImplementedException();
        }
    }

    
}