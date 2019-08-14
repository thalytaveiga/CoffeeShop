using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class CoffeeDarkRoast: MenuItem
    {
        public CoffeeDarkRoast ()
        {
            base.Description = "Dark roast coffee";
            base.BaseCost = 2M;
        }
    }
}
