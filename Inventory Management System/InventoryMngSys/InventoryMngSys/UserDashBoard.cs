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
    public partial class UserDashBoard : Form
    {
        private DataTable Ds {  get; set; }
        private Login Ln { get; set; }

        public UserDashBoard()
        {
            InitializeComponent();
        }

        public UserDashBoard(string name, DataTable ds, Login ln) : this() 
        {
            InitializeComponent();
            Ds = ds;
            Ln = ln;
            this.label1.Text = name;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Show();
            new ManageProducts(this).Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new CustomersInfo(this).Show();
            }
            catch
            {
                return;
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            try
            {

                this.Hide();
                new UpdatePassword(this).Show();
            }
            catch { return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageSupplier(this).Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ln.Show();
        }

        private void UserDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
