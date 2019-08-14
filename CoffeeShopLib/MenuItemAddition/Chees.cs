using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Chees : MenuItemAddition
    {
        public Chees()
        {
            Description = "Cheese";
            BaseCost = 0.40M;
        }
        public Chees(MenuItem add) : base(add)
        {
            Description = Menu.Description + ", Cheese";
            BaseCost = Menu.BaseCost + 0.40M;
        }
    }
}
