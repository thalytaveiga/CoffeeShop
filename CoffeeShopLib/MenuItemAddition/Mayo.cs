using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Mayo : MenuItemAddition
    {
        public Mayo ()
        {
            Description = "Mayo";
            BaseCost = 0.00M;
        }
        public Mayo(MenuItem add) : base(add)
        {
            Description = Menu.Description + ", Mayo";
            BaseCost = Menu.BaseCost+ 0.00M;
        }
    }
}
