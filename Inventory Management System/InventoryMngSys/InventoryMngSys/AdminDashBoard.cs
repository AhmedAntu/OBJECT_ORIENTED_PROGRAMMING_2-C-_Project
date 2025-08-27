using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMngSys
{
    public partial class AdminDashBoard : Form
    {
        private Login Ln {  get; set; }
        public AdminDashBoard()
        {
            InitializeComponent();
        }

       public AdminDashBoard(string name, Login ln) : this()
        {
            this.Ln = ln;
            this.lblAdmin.Text = name;
        }
     
        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageUsers(this).Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductInfo(this).Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SupplierInfo(this).Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomersInfo(this).Show();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new UpdatePassword(this).Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please check: " + exc.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ln.Show();
        }

        private void AdminDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblAdminDashBoard_Click(object sender, EventArgs e)
        {

        }
    }
}
