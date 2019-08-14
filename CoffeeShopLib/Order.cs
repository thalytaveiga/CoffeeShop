using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{

    [Serializable]
    public class Order
    {
        private uint orderID;
        public static uint number;
        private Customer customer;
        private bool customerExist;
        private DateTime timeOrder;
        private DateTime deliveryTime;
        private bool delivered;
        private Address deliveryAddress;
        private decimal cost;
        public enum OrderTypeEnum { PhoneOrder, RestaurantOrder };
        private OrderTypeEnum orderType;
        private List<OrderItem> items;

        public Order(Address add)
        {
            deliveryAddress = add;
            items = new List<OrderItem>();
            number++;
            orderID = number;
            OrderType =  OrderTypeEnum.PhoneOrder;
            timeOrder = DateTime.Now;
        }

        public Order()
        {
            items = new List<OrderItem>();
            number++;
            orderID = number;
            timeOrder = DateTime.Now;
        }

        [JsonIgnore]
        public Customer Customer
        {
            get { return customer; }
            set
            {
                if (customer == null)
                {
                    customer = value;
                }
                else
                {
                    if (customerExist == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("  Something went wrong! Customer cannot be changed once assigned.");
                        Console.WriteLine();
                        customerExist = true;
                    }                 
                }
            }
        }

        public bool CustomerExist
        {
            get { return customerExist; }
            set { customerExist = value; }
        }
        public uint OrderId
        {
            get { return orderID; }
            set { orderID = value; }
        }

        //public uint Number
        //{
        //    get { return number; }
        //    set { number = value; }
        //}

        public Address DeliveryAddress
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }
        [JsonProperty]
        public List<OrderItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        public DateTime TimeOrder
        {
            get { return timeOrder; }
            set { timeOrder = value; }
        }

        public DateTime DeliveryTime
        {
            get { return deliveryTime; }
            set { deliveryTime = value; }
        }

        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public OrderTypeEnum OrderType
        {
            get { return orderType; }
            set { orderType = value; }
        }

        public void AddOrderItem(IMenuItem menuItem)
        {
            items.Add(new OrderItem(menuItem));
            Cost += menuItem.BaseCost;
        }

        public void RemoveOrderItem(OrderItem menuItem)
        {
            items.Remove(menuItem);
            Cost -= menuItem.MenuItems.BaseCost;
        }

        public bool Delivered
        {
            get { return delivered; }
            set { delivered = value; }
        }

        public OrderTypeEnum RestaurantOrder { get; set; }

        public OrderTypeEnum PhoneOrder { get; set; }

        public void Deliver ()
        {
            delivered = true;
            deliveryTime = DateTime.Now;   
        }

        public override string ToString()
        {
            string info = $"\r\n +++ Order ID: {OrderId} +++       \r\nCustomer: {Customer.Name}\r\nTime Order: {TimeOrder}\r\nOrder Type: {OrderType}\r\nDelivery Address: {DeliveryAddress.ToString()}";
            if (delivered == true)
            {
                info += $"\r\nDelivery Time: {DeliveryTime}\r\nItems: \r\n";
            }
            else
            {
                info += "\r\nNot delivered\r\nItems: \r\n";
            }
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i] != null)
                {
                    info += "   " + Items[i].GetInfo()+"\r\n";
                }
            }
            info += $"\r\nTotal Cost: {Cost:C}\r\n\n" + "\r\n++++++++++++++++++++++++++++++++++++\r\n";
            return info;
        }
    }
}
