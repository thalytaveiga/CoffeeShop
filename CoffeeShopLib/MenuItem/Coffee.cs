using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Coffee : MenuItem
    {
        public Coffee()
        {
            base.Description = "Original Blend Coffee";
            base.BaseCost = 2M;
        }
    }
}
