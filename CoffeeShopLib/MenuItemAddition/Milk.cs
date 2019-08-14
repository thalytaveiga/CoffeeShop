using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Milk : MenuItemAddition 
    {
        public Milk()
        {
            Description =  "Milk";
            BaseCost = 0.10M;
        }
        public Milk(MenuItem add) : base(add)
        {
            Description = Menu.Description + ", Milk";
            BaseCost = Menu.BaseCost + 0.10M; 
        }
    }
}
