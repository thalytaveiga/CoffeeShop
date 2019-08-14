using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    [Serializable]
    public class CustomerRepository : RepositoryBase
    {
        private List<Customer> customers;

        public override List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }

        public CustomerRepository()
        {
            customers = new List<Customer>();
        }
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public static List<Customer> CustomerOrderNotDelivered(List<Customer> customers)
        {
            List<Customer> selectedCustomers = new List<Customer>();
            selectedCustomers = customers.Where(customer => customer.Orders.Any(order => order.Delivered == false)).ToList();
            return selectedCustomers;
        }

        public static List<Customer> OrdersBtwDates(List<Customer> customers, DateTime fromDate, DateTime toDate)
        {
            List<Customer> result = new List<Customer>();
            result = (from customer in customers
                      from order in customer.Orders
                      where order.TimeOrder.Date >= fromDate.Date && order.TimeOrder.Date <= toDate.Date
                      select customer).ToList();
            result = result.Distinct().ToList();
            return result;

        }


    }
}
