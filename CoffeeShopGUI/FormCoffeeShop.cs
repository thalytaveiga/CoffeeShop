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
    public partial class FormCoffeeShop : Form
    {
        public static CustomerRepository repository = new CustomerRepository();
        public static Order custOrder;


        public FormCoffeeShop()
        {
            InitializeComponent();

            repository.Load("Customers.json");

            RefreshCustomer();
        }

        public void RefreshCustomer()
        {
            lbxCustomers.Items.Clear();
            lbxCustomers.DisplayMember = "Customer.Name";
            foreach (Customer cust in repository.Customers)
            {
                lbxCustomers.Items.Add(cust);
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            repository.Save("Customers.json");
            MessageBox.Show("Customer and order saved.");
            RefreshCustomer();
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            FormAddCustomer formCustomer = new FormAddCustomer(customer);
            DialogResult dr = formCustomer.ShowDialog();
            if (dr == DialogResult.OK)
            {
                repository.Add(customer);
                lbxCustomers.Items.Add(customer);
                MessageBox.Show(customer.Name + " is saved.");
            }
            else if (dr == DialogResult.Cancel)
            {
                Customer.number--;
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (lbxCustomers.SelectedItem == null)
            {
                MessageBox.Show("Please, select a customer to create an order.");
            }
            else
            {
                FormAddOrder formOrder = new FormAddOrder((Customer)lbxCustomers.SelectedItem);
                formOrder.Show();
            }
        }

        private void btnEditCust_Click(object sender, EventArgs e)
        {
            Customer cust = (Customer)lbxCustomers.SelectedItem;
            FormAddCustomer formCustomer = new FormAddCustomer(cust);
            formCustomer.Show();
        }

        public void RefreshOrder()
        {
            lbxLastOrder.Items.Clear();
            foreach (OrderItem ord in custOrder.Items)
            {
                lbxLastOrder.Items.Add(ord.MenuItems);
            }
            lblTotalOrderValue.Text = custOrder.Cost.ToString();
            lblCustomerName.Text = custOrder.Customer.Name;         
        }

        public void ClearOrder()
        {
            lbxLastOrder.Items.Clear();
        }

        private void btnNotDeliveredOrders_Click(object sender, EventArgs e)
        {           
            FormCustomerOrders formCustomerOrder = new FormCustomerOrders();
            formCustomerOrder.RefreshCustomerList();
            formCustomerOrder.Show();
        }

        private void btnListOrdersBtwDates_Click(object sender, EventArgs e)
        {
            FormCustomerOrders formCustomerOrder = new FormCustomerOrders();
            formCustomerOrder.RefreshCustomerListbyDate(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            formCustomerOrder.Show();
        }
    }
}
