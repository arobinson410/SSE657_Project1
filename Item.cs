using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SSE657_Project1
{
    public class Item
    {
        public enum RarityEnum //Using an enum to help make the rarity variable more meaningful
        {
            Common = 0,
            Uncommon,
            Rare,
            VeryRare,
            Legendary
        }

        private string _name = "Default Name";
        private string _description = "Description Here";
        private RarityEnum _rarity = RarityEnum.Common;
        private double _weight = 1.0; //weight in pounds
        private int _charges = 0;

        //Using public properties to make databinding easier in the future
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public RarityEnum Rarity
        {
            get
            {
                return _rarity;
            }
            set
            {
                _rarity = value;
            }
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public int Charges
        {
            get
            {
                return _charges;
            }
            set
            {
                _charges = value;
            }
        }
    }
}
