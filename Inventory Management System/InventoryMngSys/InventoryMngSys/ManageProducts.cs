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
    public partial class ManageProducts : Form
    {
        private DataAccess Da
        {
            get;
            set;
        } 
        private UserDashBoard Ud { get; set; }
        public ManageProducts()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public ManageProducts(UserDashBoard ud) : this()
        {
            this.Ud = ud;
        }
        private void PopulateGridView(string sql = "select * from ManageProduct;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvProductInfo.AutoGenerateColumns = false;
            this.dgvProductInfo.DataSource = ds.Tables[0];
        }
        private void btnUSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var query = "select * from ManageProduct where Product_Id = '" + this.txtProductId.Text + "'";
                DataTable dt = this.Da.ExecuteQueryTable(query);
                if (dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update ManageProduct
                                set Product_Name = '" + this.txtProductName.Text + @"',
                                Category = '" + this.cmbProductCategory.Text + @"',
                                Quatity = '" + this.txtProductQuantity.Text + @"',
                                Spplier = '" + this.txtProductSupplier.Text + @"',
                                Adding_Date = '" + this.dtProductAdding.Text + @"',
                                Price = '" + this.txtProductPrice.Text + @"'
                                where Product_Id = '" + this.txtProductId.Text + "'; ";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated properly");
                    else
                        MessageBox.Show("Data hasn't been updated properly");
                }
                else
                {
                    //insert
                    var sql = @"insert into ManageProduct (Product_Id, Product_Name, Category, Quatity, Spplier, Adding_Date, Price) 
                            values ( '" + this.txtProductId.Text + "', '" + this.txtProductName.Text + "', '" + this.cmbProductCategory.Text + @"', 
                            '" + this.txtProductQuantity.Text + "','" + this.txtProductSupplier.Text + "', '" + this.dtProductAdding.Text + @"', 
                            '" + this.txtProductPrice.Text + "');";
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
            if (string.IsNullOrEmpty(this.txtProductId.Text) || string.IsNullOrEmpty(this.txtProductName.Text) ||
                string.IsNullOrEmpty(this.cmbProductCategory.Text) || string.IsNullOrEmpty(this.txtProductQuantity.Text) ||
                string.IsNullOrEmpty(this.dtProductAdding.Text) || string.IsNullOrEmpty(this.txtProductSupplier.Text) ||
                string.IsNullOrEmpty(this.txtProductPrice.Text))
                return false;
            else
                return true;
        }
        private void AutoIdGenerate()
        {
            var query = "select max(Product_Id) from ManageProduct;";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            var num = Convert.ToInt32(temp[1]);
            var newId = "p-" + (++num).ToString("d2");
            this.txtProductId.Text = newId;
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            this.dgvProductInfo.ClearSelection();
            this.AutoIdGenerate();
        }

        private void ClearAll()
        {
            this.txtProductId.Clear();
            this.txtProductName.Clear();
            this.cmbProductCategory.Text = "Select";
            this.txtProductQuantity.Clear();
            this.dtProductAdding.Text = "";
            this.txtProductSupplier.Clear();
            this.txtProductPrice.Clear();
            this.txtProductIdSearch.Clear();

            this.dgvProductInfo.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnUClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnURemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProductInfo.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to Remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var id = this.dgvProductInfo.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvProductInfo.CurrentRow.Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete " + name + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                var sql = "delete from ManageProduct where Product_Id = '" + id + "';";
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

        private void btnUSearch_Click(object sender, EventArgs e)
        {
            var sql = "select * from ManageProduct where Product_Id = '" + this.txtProductIdSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            this.dgvProductInfo.ClearSelection();
            this.AutoIdGenerate();
        }
        private void btnUEdit_Click(object sender, EventArgs e)
        {
           UpdateProductInfo();
        }

        private void UpdateProductInfo()
        {
            try
            {
                this.txtProductId.Text = this.dgvProductInfo.CurrentRow.Cells[0].Value.ToString();
                this.txtProductName.Text = this.dgvProductInfo.CurrentRow.Cells[1].Value.ToString();
                this.cmbProductCategory.Text = this.dgvProductInfo.CurrentRow.Cells[2].Value.ToString();
                this.txtProductQuantity.Text = this.dgvProductInfo.CurrentRow.Cells[3].Value.ToString();
                this.txtProductQuantity.Text = this.dgvProductInfo.CurrentRow.Cells[4].Value.ToString();
                this.dtProductAdding.Text = this.dgvProductInfo.CurrentRow.Cells[5].Value.ToString();
                this.txtProductPrice.Text = this.dgvProductInfo.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please check: " + exc.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Ud.Show();
            this.Close();
        }

        private void dgvProductInfo_DoubleClick(object sender, EventArgs e)
        {

           UpdateProductInfo();
        }

        private void ManageProducts_FormClosed(object sender, FormClosedEventArgs e)
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

