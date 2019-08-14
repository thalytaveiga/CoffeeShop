using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CoffeeShopLib;


namespace CoffeeShopLib
{
    [Serializable]
    public class MenuItem : IMenuItem
    {
        [JsonProperty]
        protected string description;
        [JsonProperty]
        protected decimal baseCost;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal BaseCost
        {
            get { return baseCost; }
            set { baseCost = value; }
        }

        public MenuItem (string Description, decimal BaseCost)
        {
            description = Description;
            baseCost = BaseCost;
        }

        public MenuItem() { }
        
        public override string ToString()
        {
            string info = $"{Description} - {BaseCost:C2} ";
            return info;
        }
    }
}
