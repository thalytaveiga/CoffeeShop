using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static CoffeeShopLib.Order;

namespace CoffeeShopLib
{
    [Serializable]
    public class Customer
    {
        private uint idNumber;
        public static uint number;
        private string name;
        private Address address;
        private long phone;
        private List<Order> orders;

        public Customer()
        {
            number++;
            idNumber = number;
            orders = new List<Order>();
        }

        public Customer (string Name, long Phone, Address a)
        {
            number++;
            idNumber = number;
            name = Name;
            phone = Phone;
            Address = a;
            orders = new List<Order>();
        }

        public Customer(uint id, string Name, long Phone, Address a)
        {
            idNumber = id;
            name = Name;
            phone = Phone;
            Address = a;
            orders = new List<Order>();
        }

        public uint IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public long Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        [JsonProperty]
        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }

        public Order AddOrder(Order ord)
        {
            ord.Deliver();
            ord.OrderType = OrderTypeEnum.RestaurantOrder; 
            ord.Customer = this;
             
            Orders.Add(ord);
            return ord;
        }

        public Order CreatePhoneOrder(Address address)
        {
            Order order = new Order(address);
            order.DeliveryAddress = address;
            order.Customer = this;
            Orders.Add(order);
            return order;
        }

        public override string ToString()
        {
            string info = $"======= {IdNumber} - {Name} =======\n       Adress: {Address.ToString()}, Phone: {Phone} \n       Orders: \n";
            if (Orders == null)
            {
                return info;
            }
            for (int i = 0; i < Orders.Count; i++)
            {
                if (Orders[i] != null)
                {
                    info += Orders[i].ToString();
                }
            }
            return info;
        }
    }
}
