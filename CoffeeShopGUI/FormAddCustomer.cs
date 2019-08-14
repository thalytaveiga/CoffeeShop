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
    public partial class FormAddCustomer : Form
    {
        Customer cust;
        //private bool isNewCustomer;
        
        public FormAddCustomer(Customer c)
        {
            cust = c;
            InitializeComponent();
            lblIdNumber.Text = c.IdNumber.ToString();
            txtCustomerName.Text = c.Name;
            txtCustomerStreet.Text = c.Address.Street;
            txtCity.Text = c.Address.City;
            txtProvince.Text = c.Address.Province;
            txtPostalCode.Text = c.Address.PostalCode;
            txtCustomerPhone.Text = c.Phone.ToString();              
        }


        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            cust.Name = txtCustomerName.Text;
            cust.Phone = long.Parse(txtCustomerPhone.Text);

            Address adr = new Address();
            adr.Street = txtCustomerStreet.Text;
            adr.City = txtCity.Text;
            adr.Province = txtProvince.Text;
            adr.PostalCode = txtPostalCode.Text;

            cust.Address = adr;
            DialogResult = DialogResult.OK;
            Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
