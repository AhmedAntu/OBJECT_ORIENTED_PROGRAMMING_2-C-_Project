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
    public partial class SupplierInfo : Form
    {
        private AdminDashBoard Ad {  get; set; }

        private DataAccess Da { get; set; }
        public SupplierInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from ManageSupplier;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvSInfo.AutoGenerateColumns = false;
            this.dgvSInfo.DataSource = ds.Tables[0];
        }

        public SupplierInfo(AdminDashBoard ad) : this()
        {
            this.Ad = ad;

        }


        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var sql = "select * from ManageSupplier where SId = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            this.Ad.Show();
            this.Hide();
        }
    }
}
