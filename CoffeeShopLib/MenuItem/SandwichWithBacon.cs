using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class SandwichWithBacon: MenuItem
    {
        public SandwichWithBacon()
        {
            base.Description = "White bread sandwich with bacon";
            base.BaseCost = 5M;
        }      
    }
}
