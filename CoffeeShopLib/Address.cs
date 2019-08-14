using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    [Serializable]
    public struct Address
    {
        public string Street;
        public string City;
        public string Province;
        public string PostalCode;
        public static Address SHOP_ADDRESS = new Address("1 King St", "Toronto", "ON", "M1M 1M1");
        
        static Address() { }

        public Address (string street, string city, string province, string postalCode)
        {
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.PostalCode = postalCode;
        }

        public override string ToString()
        {
            return $"{Street}, {City} - {Province}, {PostalCode}.";
        }
    }
}
