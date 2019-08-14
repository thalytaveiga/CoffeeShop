using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Tea : MenuItem
    {
        public Tea()
        {
            base.Description = "Tea";
            base.BaseCost = 1.80M;
        }
    }
}
