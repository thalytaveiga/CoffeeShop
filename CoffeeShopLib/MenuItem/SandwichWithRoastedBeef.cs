using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class SandwichWithRoastedBeef: MenuItem
    {
        public SandwichWithRoastedBeef()
        {
            base.Description = "White bread sandwich with roasted beef";
            base.BaseCost = 5.50M;
        }    
    }
}
