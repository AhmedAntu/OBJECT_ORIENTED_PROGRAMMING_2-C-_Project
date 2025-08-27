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
    public partial class ProductInfo : Form
    {
        private DataAccess Da { get; set; }
        private AdminDashBoard Ad { get; set; }

        public ProductInfo(AdminDashBoard ad) : this()
        {
            this.Ad = ad;
        }
        private void PopulateGridView(string sql = "select * from ManageProduct;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvPInfo.AutoGenerateColumns = false;
            this.dgvPInfo.DataSource = ds.Tables[0];
        }
        public ProductInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            try
            {

                this.Ad.Show();
                this.Hide();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please check: " + exc.Message);
            }
        }
    }
}
