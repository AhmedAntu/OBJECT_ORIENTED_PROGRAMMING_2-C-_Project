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
    public partial class UpdatePassword : Form
    {
        private DataTable Ds { get; set; }
        private DataAccess Da { get; set; }
        private AdminDashBoard Ad { get; set; }
        private  UserDashBoard Ud { get; set; }
        
        public UpdatePassword()
        {
            InitializeComponent();
        }
        public UpdatePassword(AdminDashBoard ad) : this()
        {

            this.Ad = ad;
        }public UpdatePassword(UserDashBoard ud) : this()
        {

            this.Ud = ud;
        }
        private void btnUpdatePass_Click(object sender, EventArgs e)
        {

            try
            {
                var dbOldPass = Ds.Rows[0][10].ToString();
                var txtOldPass = this.txtOldPass.Text.ToString();
                var txtNewPass = this.txtNewPass.Text.ToString();
                var txtConfirm = this.txtConfirmPass.Text.ToString();

                //MessageBox.Show("Old Password:" + dbOldPass);
                //bool result = String.Equals(this.txtOldPassword, oldPass);
                //MessageBox.Show("Old Password:" + txtOldPass.GetType());

                if (!String.Equals(txtOldPass, dbOldPass))
                {
                    MessageBox.Show("Old Password is not correct", "Incorrect Old Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //MessageBox.Show("All Correct 1");
                    if (!String.Equals(txtNewPass, txtConfirm))
                    {
                        MessageBox.Show("New Password and Comfirm Password does not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        //MessageBox.Show("All Correct 2: " + Ds.Rows[0][0]);
                        string sql = "update EmployeeInfo set Password = '" + this.txtNewPass.Text + "' where User_Id = 'u-01';";
                        int count = this.Da.ExecuteDMLQuery(sql);

                        if (count == 1)
                            MessageBox.Show("Password has been updated properly");
                        else
                            MessageBox.Show("Password hasn't been updated properly");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong. Please try again." + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {

                this.Ad.Show();
                this.Ud.Show();
                this.Hide();
            }
            catch (Exception exc) {return;}
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
