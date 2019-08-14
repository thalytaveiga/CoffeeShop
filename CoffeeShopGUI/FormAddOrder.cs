using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopLib;
using MenuItem = CoffeeShopLib.MenuItem;

namespace CoffeeShopGUI

{
    public partial class FormAddOrder : Form
    {
        Order order;
        Customer customer;
  
        public FormAddOrder(Customer customer)
        {
            InitializeComponent();

            this.customer = customer;
            lblCustomerName.Text = customer.Name;

            if (customer.IdNumber == 1)
            {
                order = new Order();
                order = customer.AddOrder(order);
            }
            else
            {
                order = customer.CreatePhoneOrder(customer.Address);
            }

            lblCustomerOrderId.Text = Convert.ToString(order.OrderId);
            if (order.Delivered == true)
            {
                ckbDelivered.Checked = true;
            }
            CreateMenuItem();
            CreateMenuItemAddition();
            lblTtotalCost.Text = order.Cost.ToString();
        }

        private void CreateMenuItemAddition()
        {
            lbxMenuAddition.Items.Add(new Milk());
            lbxMenuAddition.Items.Add(new Suggar());
            lbxMenuAddition.Items.Add(new Sweetener());
            lbxMenuAddition.Items.Add(new Tomato());
            lbxMenuAddition.Items.Add(new Chees());
            lbxMenuAddition.Items.Add(new Lettuce());
            lbxMenuAddition.Items.Add(new Mayo());
        }

        public void CreateMenuItem()
        {
            lbxMenuItem.Items.Add(new Coffee());
            lbxMenuItem.Items.Add(new CoffeeDarkRoast());
            lbxMenuItem.Items.Add(new Tea());
            lbxMenuItem.Items.Add(new SandwichWithBacon());
            lbxMenuItem.Items.Add(new SandwichWithEggSalad());
            lbxMenuItem.Items.Add(new SandwichWithRoastedBeef());
        }

        private void RefreshOrder()
        {
            lbxOrder.Items.Clear();
            foreach (OrderItem orderAdd in order.Items)
            {
                lbxOrder.Items.Add(orderAdd);
            }
            lbxOrder.SelectedIndex = order.Items.Count - 1;
        }

        private void btnAddItemToOrder_Click(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)lbxMenuItem.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("Please, select a menu item.");
            }
            else
            {
                order.AddOrderItem(item);
                lblTtotalCost.Text = order.Cost.ToString();
                RefreshOrder();
            }           
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (lbxOrder.SelectedItem == null)
            {
                MessageBox.Show("Please, select an item to add.");
            }
            else
            {
                OrderItem item = (OrderItem)lbxOrder.SelectedItem;
                IMenuItem menuAdd = (IMenuItem)lbxMenuAddition.SelectedItem;

                //Get type MenuItemAddition
                Type type = menuAdd.GetType();
                //Get object Constructor
                ConstructorInfo ctor = type.GetConstructor(new[] { typeof(MenuItem) });
                //Invoke constructor (MenuItemAdditional) with parameter (MenuItem)
                object instance = ctor.Invoke(new object[] { item.MenuItems });

                order.AddOrderItem((MenuItem)instance);

                order.RemoveOrderItem(item);
                lblTtotalCost.Text = order.Cost.ToString();
                RefreshOrder();             
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            OrderItem menu = (OrderItem) lbxOrder.SelectedItem;
            lbxOrder.Items.Remove(menu);
            order.RemoveOrderItem(menu);
            RefreshOrder();
            lblTtotalCost.Text = order.Cost.ToString();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            Order.number--;
            Close();
        }

        private void btnOkOrder_Click(object sender, EventArgs e)
        {
            if (FormCoffeeShop.custOrder != null)
            {
                ((FormCoffeeShop)Application.OpenForms["FormCoffeeShop"]).ClearOrder();
            }
            if (ckbDelivered.Checked == true)
            {
                order.Deliver();
            }
            FormCoffeeShop.custOrder = order;
            ((FormCoffeeShop)Application.OpenForms["FormCoffeeShop"]).RefreshOrder();
            Close();
        }

    }
}
