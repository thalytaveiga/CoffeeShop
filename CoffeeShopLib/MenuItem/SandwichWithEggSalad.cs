using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class SandwichWithEggSalad: MenuItem
    {
        public SandwichWithEggSalad()
        {
            base.Description = "White bread sandwich with egg salad";
            base.BaseCost = 4M;
        }     
    }
}
