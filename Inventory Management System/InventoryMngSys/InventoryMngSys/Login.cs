using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopManagementSystem;

namespace InventoryMngSys
{
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserId.Clear();
            this.Password.Clear();
        }

        private void ckbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Password.UseSystemPasswordChar = false;
            }
            else
            {
                this.Password.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.Password.Text))
                {
                    MessageBox.Show("Please fill User Id and Password to continue");
                    return;
                }

                string sql = "select * from ManageUsers where User_Id = '" + this.txtUserId.Text + "' and User_Password = '" + this.Password.Text + "';";
                var ds = Da.ExecuteQueryTable(sql);

                if (ds.Rows.Count == 1)
                {
                    var name = ds.Rows[0][1].ToString();
                    MessageBox.Show("Welcome! You have successfully logged in.", "Login Successful");
                    this.Hide();
                    if (ds.Rows[0][1].ToString().Equals("Admin"))
                        new AdminDashBoard(name, this).Show();
                     else if (ds.Rows[0][1].ToString().Equals("User"))
                         new UserDashBoard(name,ds, this).Show();
                }
                else
                {
                    MessageBox.Show("Invalid ID or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured:" + exc.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Password.PasswordChar = '\0';
            }
            else
            {
                this.Password.PasswordChar = '*'; 
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
