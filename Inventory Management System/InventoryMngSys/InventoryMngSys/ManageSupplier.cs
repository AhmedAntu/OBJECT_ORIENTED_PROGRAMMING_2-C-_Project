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
    public partial class ManageSupplier : Form
    {
        private UserDashBoard Ud {  get; set; }

        private DataAccess Da { get; set; }
        public ManageSupplier()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public ManageSupplier(UserDashBoard ud) : this()
        {
            this.Ud = ud;
        }

       /* private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from EmployeeInfo where FullName like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }*/
        private void PopulateGridView(string sql = "select * from ManageSupplier;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvSInfo.AutoGenerateColumns = false;
            this.dgvSInfo.DataSource = ds.Tables[0];
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

                var query = "select * from ManageSupplier where SId = '" + this.txtSId.Text + "'";
                DataTable dt = this.Da.ExecuteQueryTable(query);
                if (dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update ManageSupplier
                                set SName = '" + this.txtSName.Text + @"',
                                Number = '" + this.txtSNumber.Text + @"',
                                SCategory = '" + this.cmbSCategory.Text + @"',
                                SQuantity = '" + this.txtSQuantity.Text + @"',
                                SAddress = '" + this.txtSAddress.Text + @"',
                                Gender = '" + this.cmbGender.Text + @"',
                                Date = '" + this.dtpSupplingDate.Text + @"',
                                Amount = '" + this.txtSAmount.Text + @"'
                                where SId = '" + this.txtSId.Text + "'; ";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated properly");
                    else
                        MessageBox.Show("Data hasn't been updated properly");
                }
                else
                {
                    //insert
                    var sql = @"insert into ManageSupplier (SId, SName, Number, SCategory, SQuantity, SAddress, Gender, Date, Amount) 
                            values ( '" + this.txtSId.Text + "', '" + this.txtSName.Text + "', '" + this.txtSNumber.Text + @"', 
                            '" + this.cmbSCategory.Text + "','" + this.txtSQuantity.Text + "', '" + this.txtSAddress.Text + @"', 
                            '" + this.cmbGender.Text + "', '" + this.dtpSupplingDate.Text + "', '" + this.txtSAmount.Text + "');";
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
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtSId.Text) || string.IsNullOrEmpty(this.txtSName.Text) ||
                string.IsNullOrEmpty(this.txtSNumber.Text) || string.IsNullOrEmpty(this.cmbSCategory.Text) ||
                string.IsNullOrEmpty(this.txtSQuantity.Text) || string.IsNullOrEmpty(this.txtSAddress.Text) ||
                string.IsNullOrEmpty(this.cmbGender.Text) || string.IsNullOrEmpty(this.dtpSupplingDate.Text) ||
                string.IsNullOrEmpty(this.txtSAmount.Text))
                return false;
            else
                return true;
        }
        private void UpdateSupplierInfo()
        {

            try
            {
                this.txtSId.Text = this.dgvSInfo.CurrentRow.Cells[0].Value.ToString();
                this.txtSName.Text = this.dgvSInfo.CurrentRow.Cells[1].Value.ToString();
                this.txtSNumber.Text = this.dgvSInfo.CurrentRow.Cells[2].Value.ToString();
                this.cmbSCategory.Text = this.dgvSInfo.CurrentRow.Cells[3].Value.ToString();
                this.txtSQuantity.Text = this.dgvSInfo.CurrentRow.Cells[4].Value.ToString();
                this.txtSAddress.Text = this.dgvSInfo.CurrentRow.Cells[5].Value.ToString();
                this.cmbGender.Text = this.dgvSInfo.CurrentRow.Cells[6].Value.ToString();
                this.dtpSupplingDate.Text = this.dgvSInfo.CurrentRow.Cells[7].Value.ToString();
                this.txtSAmount.Text = this.dgvSInfo.CurrentRow.Cells[8].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please check: " + exc.Message);
            }
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateSupplierInfo();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            this.txtSId.Clear();
            this.txtSName.Clear();
            this.txtSNumber.Clear();
            this.cmbSCategory.SelectedIndex = -1;
            this.txtSQuantity.Clear();
            this.txtSAddress.Clear();
            this.cmbGender.SelectedIndex = -1;
            this.dtpSupplingDate.Text = "";
            this.txtSAmount.Clear();

            this.dgvSInfo.ClearSelection();
            this.AutoIdGenerate();
        }
        private void AutoIdGenerate()
        {
            var query = "select max(SId) from ManageSupplier;";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            var num = Convert.ToInt32(temp[1]);
            var newId = "s-" + (++num).ToString("d2");
            this.txtSId.Text = newId;
        }

        private void ManageSupplier_Load_1(object sender, EventArgs e)
        {
            this.dgvSInfo.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvSInfo.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to Remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var id = this.dgvSInfo.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvSInfo.CurrentRow.Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete " + name + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                var sql = "delete from ManageSupplier where SId = '" + id + "';";
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
        private void dgvSInfo_DoubleClick(object sender, EventArgs e)
        {
            UpdateSupplierInfo();
        }
        private void dgvSInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

            var sql = "select * from ManageSupplier where SId = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Ud.Show();
            this.Close();
        }

        private void ManageSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Application.Exit();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
