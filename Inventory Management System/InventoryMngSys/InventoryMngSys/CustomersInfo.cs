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
    public partial class CustomersInfo : Form
    {
        private AdminDashBoard Ad { get; set; }
        private UserDashBoard Udb { get; set; }

        private DataAccess Da { get; set; }
        public CustomersInfo()
        {
            InitializeComponent();
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from CustomerInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvSInfo.AutoGenerateColumns = false;
            this.dgvSInfo.DataSource = ds.Tables[0];
        }
        public CustomersInfo(AdminDashBoard ad) : this()
        {
            this.Ad = ad;
        }public CustomersInfo(UserDashBoard udb) : this()
        {
            this.Udb = udb;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnHome_Click_1(object sender, EventArgs e)
        {
            this.Ad.Show();
            this.Close();
        }
        public CustomersInfo(DataTable ds, UserDashBoard udb) : this()
        {
            this.Udb = udb;
            this.Close();
        }
         
       private void CustomersInfo_FormClosed(object sender, FormClosedEventArgs e)
       {
        Application.Exit();
       }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var sql = "select * from CustomerInfo where id = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }
    }
}
