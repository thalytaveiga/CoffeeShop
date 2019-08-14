using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Sweetener : MenuItemAddition
    {
        public Sweetener()
        {
            Description = "Sweetener";
            BaseCost = 0.06M;
        }
        public Sweetener(MenuItem add) : base(add)
        {
            Description = Menu.Description + ", Sweetener";
            BaseCost = Menu.BaseCost + 0.06M;
        }
    }
}
