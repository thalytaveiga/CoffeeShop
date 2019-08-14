using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopLib;

namespace CoffeeShopGUI
{
    public partial class FormCustomerOrders : Form
    {
        public FormCustomerOrders()
        {
            InitializeComponent();
            lbxCustomers.DisplayMember = "Customer.Name";
        }

        public void RefreshCustomerList()
        {
            foreach (Customer cust in CustomerRepository.CustomerOrderNotDelivered(
                FormCoffeeShop.repository.Customers))
            {
                lbxCustomers.Items.Add(cust);
            }

            lblCustomerOrders.Text = "Customers with not delivered orders";
            if (lbxCustomers.Items.Count > 0)
            {
                lbxCustomers.SelectedIndex = 0;
            }
        }

        public void RefreshCustomerListbyDate(DateTime fromDate, DateTime toDate)
        {
            foreach (Customer cust in CustomerRepository.OrdersBtwDates(FormCoffeeShop.repository.Customers, fromDate, toDate))
            {
                lbxCustomers.Items.Add(cust);
            }

            lblCustomerOrders.Text = "Customers selected by date";
            if (lbxCustomers.Items.Count > 0)
            {
                lbxCustomers.SelectedIndex = 0; 
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOrders.Clear();
            Customer customer = (Customer) lbxCustomers.SelectedItem;
            foreach (Order order in customer.Orders)
            {
                txtOrders.AppendText(order.ToString());
            }
        }
    }
}
