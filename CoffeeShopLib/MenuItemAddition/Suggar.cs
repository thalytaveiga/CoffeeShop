using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Suggar : MenuItemAddition
    {
        public Suggar()
        {
            Description = "Suggar";
            BaseCost = 0.05M;
        }
        public Suggar(MenuItem add) : base(add)
        {
            Description = Menu.Description + ", Suggar";
            BaseCost = Menu.BaseCost + 0.05M;
        }
    }
}
