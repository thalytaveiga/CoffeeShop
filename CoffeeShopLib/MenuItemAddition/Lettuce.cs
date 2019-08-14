using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Lettuce : MenuItemAddition
    {
        public Lettuce()
        {
            Description = "Lettuce";
            BaseCost = 0.30M;
        }
        public Lettuce(MenuItem add) : base(add)
        {
            Description =  Menu.Description + ", Lettuce";
            BaseCost = Menu.BaseCost + 0.30M;
        }
    }
}
