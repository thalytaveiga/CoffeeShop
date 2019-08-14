using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    [Serializable]
    public class OrderItem
    {
        private IMenuItem menuItems;

        public IMenuItem MenuItems
        {
            get { return menuItems; }
            set { menuItems = value; }
        }

        public OrderItem(IMenuItem menu)
        {
            MenuItems = menu;
        }
        public string GetInfo()
        {
            return $"{MenuItems.Description} - {MenuItems.BaseCost:C2}";
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
