using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    [Serializable]
    public class MenuItemAddition : MenuItem
    {
        [JsonProperty]
        protected MenuItem menu;

        [JsonIgnore]
        public MenuItem Menu
        {
            get { return menu; }
            set { menu = value; }
        }

        public MenuItemAddition(MenuItem menu)
        {
            Menu = menu;
        }

        public MenuItemAddition() { }
    }
}
