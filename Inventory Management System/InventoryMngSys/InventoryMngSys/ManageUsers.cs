using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using SuperShopManagementSystem;

namespace InventoryMngSys
{
    public partial class ManageUsers : Form
    {
        private DataAccess Da { get; set; }

        private AdminDashBoard Ad { get; set; }

        public ManageUsers()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        public ManageUsers( AdminDashBoard ad) : this()
            {
                this.Ad = ad;
            }
        private void PopulateGridView(string sql = "select * from ManageUsers;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvUsersInfo.AutoGenerateColumns = false;
            this.dgvUsersInfo.DataSource = ds.Tables[0];
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUserName.Text) || string.IsNullOrEmpty(this.txtUserId.Text) ||
                string.IsNullOrEmpty(this.txtUserId.Text) ||
                string.IsNullOrEmpty(this.txtUserNumber.Text) || string.IsNullOrEmpty(this.cmbGender.Text) || 
                string.IsNullOrEmpty(this.dtpJoiningDate.Text) || string.IsNullOrEmpty(this.txtUsalary.Text))
                return false;
            else
                return true;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var query = "select * from ManageUsers where User_Id = '" + this.txtUserId.Text + "'";
                DataTable dt = this.Da.ExecuteQueryTable(query);
                if (dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update ManageUsers
                                set User_Name = '" + this.txtUserName.Text + @"',
                                User_Password = '" + this.txtUserPassword.Text + @"',
                                User_Number = '" + this.txtUserNumber.Text + @"',
                                Gender = '" + this.cmbGender.Text + @"',
                                Joining_Date = '" + this.dtpJoiningDate.Text + @"',
                                Salary = '" + this.txtUsalary.Text + @"'
                                where User_Id = '" + this.txtUserId.Text + "'; ";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated properly");
                    else
                        MessageBox.Show("Data hasn't been updated properly");
                }
                else
                {
                    //insert
                    var sql = @"insert into ManageUsers (User_Id, User_Name, User_Password, User_Number, Gender, Joining_Date, Salary) 
                            values ( '" + this.txtUserId.Text + "', '" + this.txtUserName.Text + "', '" + this.txtUserPassword.Text + @"', 
                            '" + this.txtUserNumber.Text + "','" + this.cmbGender.Text + "', '" + this.dtpJoiningDate.Text + @"', 
                            '" + this.txtUsalary.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added properly");
                    else
                        MessageBox.Show("Data hasn't been added properly");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please check: " + exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateUsers();

        }

        private void UpdateUsers()
        {
            try
            {
                this.txtUserId.Text = this.dgvUsersInfo.CurrentRow.Cells[0].Value.ToString();
                this.txtUserName.Text = this.dgvUsersInfo.CurrentRow.Cells[1].Value.ToString();
                this.txtUserPassword.Text = this.dgvUsersInfo.CurrentRow.Cells[2].Value.ToString();
                this.txtUserNumber.Text = this.dgvUsersInfo.CurrentRow.Cells[3].Value.ToString();
                this.cmbGender.Text = this.dgvUsersInfo.CurrentRow.Cells[4].Value.ToString();
                this.dtpJoiningDate.Text = this.dgvUsersInfo.CurrentRow.Cells[5].Value.ToString();
                this.txtUsalary.Text = this.dgvUsersInfo.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please check: " + exc.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUsersInfo.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to Remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var id = this.dgvUsersInfo.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvUsersInfo.CurrentRow.Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete " + name + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                var sql = "delete from ManageUsers where User_Id = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Data hasn't been removed properly");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please check: " + exc.Message);
            }
        }

        private void ClearAll()
        {
            this.txtUserId.Clear();
            this.txtUserName.Clear();
            this.txtUserPassword.Clear();
            this.txtUserNumber.Clear();
            this.cmbGender.SelectedIndex = -1;
            this.dtpJoiningDate.Text = "";
            this.txtUsalary.Clear();

            this.dgvUsersInfo.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var sql = "select * from ManageUsers where User_Id = '" + this.txtUserSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void AutoIdGenerate()
        {
            var query = "select max(User_Id) from ManageUsers;";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            var num = Convert.ToInt32(temp[1]);
            var newId = "u-" + (++num).ToString("d2");
            this.txtUserId.Text = newId;
        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {

            this.dgvUsersInfo.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Ad.Show();
            this.Hide();
        }

        private void ManageUsers_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvUsersInfo_DoubleClick(object sender, EventArgs e)
        {
            UpdateUsers();
        }
    }
}
