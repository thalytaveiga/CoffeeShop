using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Tomato : MenuItemAddition
    {
        public Tomato()
        {
            Description = "Tomato";
            BaseCost = 0.35M;
        }
        public Tomato(MenuItem add) : base(add)
        {
            Description = Menu.Description + ", Tomato";
            BaseCost =Menu.BaseCost + 0.35M;
        }
    }
}
