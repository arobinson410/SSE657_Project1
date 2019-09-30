using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE657_Project1
{
    public class Inventory
    {
        private ObservableCollection<Item> _items = new ObservableCollection<Item>(); //An ObservableCollection must be used instead of a list so that changes are automatically updated in the UI
        private double _money = 0;

        //Using public properties to make databinding easier in the future
        public ObservableCollection<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        public double Money
        {
            get
            {
                return _money;
            }
            set
            {
                _money = value;
            }
        }
        
        public double getCarryWeight()
        {
            double totalWeight = 0;

            foreach(Item item in _items)
            {
                totalWeight += item.Weight;
            }

            return totalWeight;
        }

    }
}
