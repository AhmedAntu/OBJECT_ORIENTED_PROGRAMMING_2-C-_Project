namespace InventoryMngSys
{
    partial class ManageProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvProductInfo = new System.Windows.Forms.DataGridView();
            this.Product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adding_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUSearch = new System.Windows.Forms.Button();
            this.txtProductIdSearch = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUEdit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnURemove = new System.Windows.Forms.Button();
            this.dtProductAdding = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inventorydbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventorydbDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnUSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUClear = new System.Windows.Forms.Button();
            this.txtProductSupplier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSetBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btnShowAll);
            this.panel3.Controls.Add(this.dgvProductInfo);
            this.panel3.Controls.Add(this.btnUSearch);
            this.panel3.Controls.Add(this.txtProductIdSearch);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Location = new System.Drawing.Point(306, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 592);
            this.panel3.TabIndex = 25;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.OliveDrab;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnShowAll.Location = new System.Drawing.Point(584, 20);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(92, 30);
            this.btnShowAll.TabIndex = 36;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvProductInfo
            // 
            this.dgvProductInfo.AllowUserToAddRows = false;
            this.dgvProductInfo.AllowUserToDeleteRows = false;
            this.dgvProductInfo.AllowUserToResizeColumns = false;
            this.dgvProductInfo.AllowUserToResizeRows = false;
            this.dgvProductInfo.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvProductInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProductInfo.ColumnHeadersHeight = 25;
            this.dgvProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Id,
            this.Product_Name,
            this.Category,
            this.Quantity,
            this.Supplier,
            this.Adding_Date,
            this.Price});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductInfo.EnableHeadersVisualStyles = false;
            this.dgvProductInfo.GridColor = System.Drawing.SystemColors.Info;
            this.dgvProductInfo.Location = new System.Drawing.Point(0, 67);
            this.dgvProductInfo.Name = "dgvProductInfo";
            this.dgvProductInfo.ReadOnly = true;
            this.dgvProductInfo.RowHeadersWidth = 51;
            this.dgvProductInfo.RowTemplate.Height = 24;
            this.dgvProductInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductInfo.Size = new System.Drawing.Size(704, 525);
            this.dgvProductInfo.TabIndex = 35;
            this.dgvProductInfo.DoubleClick += new System.EventHandler(this.dgvProductInfo_DoubleClick);
            // 
            // Product_Id
            // 
            this.Product_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Product_Id.DataPropertyName = "Product_Id";
            this.Product_Id.HeaderText = "Product Id";
            this.Product_Id.MinimumWidth = 6;
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.ReadOnly = true;
            this.Product_Id.Width = 95;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Product_Name.DataPropertyName = "Product_Name";
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.Width = 121;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Categories";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 101;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.DataPropertyName = "Quatity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 83;
            // 
            // Supplier
            // 
            this.Supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Supplier.DataPropertyName = "Spplier";
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.MinimumWidth = 6;
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.Width = 85;
            // 
            // Adding_Date
            // 
            this.Adding_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adding_Date.DataPropertyName = "Adding_Date";
            this.Adding_Date.HeaderText = "Adding Date";
            this.Adding_Date.MinimumWidth = 6;
            this.Adding_Date.Name = "Adding_Date";
            this.Adding_Date.ReadOnly = true;
            this.Adding_Date.Width = 110;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 66;
            // 
            // btnUSearch
            // 
            this.btnUSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUSearch.Location = new System.Drawing.Point(450, 20);
            this.btnUSearch.Name = "btnUSearch";
            this.btnUSearch.Size = new System.Drawing.Size(109, 30);
            this.btnUSearch.TabIndex = 22;
            this.btnUSearch.Text = "Search";
            this.btnUSearch.UseVisualStyleBackColor = false;
            this.btnUSearch.Click += new System.EventHandler(this.btnUSearch_Click);
            // 
            // txtProductIdSearch
            // 
            this.txtProductIdSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductIdSearch.Location = new System.Drawing.Point(279, 25);
            this.txtProductIdSearch.Name = "txtProductIdSearch";
            this.txtProductIdSearch.Size = new System.Drawing.Size(156, 25);
            this.txtProductIdSearch.TabIndex = 21;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnHome.Location = new System.Drawing.Point(54, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(92, 30);
            this.btnHome.TabIndex = 33;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUEdit
            // 
            this.btnUEdit.BackColor = System.Drawing.Color.Aqua;
            this.btnUEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUEdit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnUEdit.Location = new System.Drawing.Point(168, 481);
            this.btnUEdit.Name = "btnUEdit";
            this.btnUEdit.Size = new System.Drawing.Size(97, 30);
            this.btnUEdit.TabIndex = 34;
            this.btnUEdit.Text = "Update";
            this.btnUEdit.UseVisualStyleBackColor = false;
            this.btnUEdit.Click += new System.EventHandler(this.btnUEdit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Price :";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(130, 426);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(135, 25);
            this.txtProductPrice.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Adding Date :";
            // 
            // btnURemove
            // 
            this.btnURemove.BackColor = System.Drawing.Color.Crimson;
            this.btnURemove.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnURemove.ForeColor = System.Drawing.SystemColors.Info;
            this.btnURemove.Location = new System.Drawing.Point(168, 534);
            this.btnURemove.Name = "btnURemove";
            this.btnURemove.Size = new System.Drawing.Size(97, 30);
            this.btnURemove.TabIndex = 31;
            this.btnURemove.Text = "Remove";
            this.btnURemove.UseVisualStyleBackColor = false;
            this.btnURemove.Click += new System.EventHandler(this.btnURemove_Click);
            // 
            // dtProductAdding
            // 
            this.dtProductAdding.CustomFormat = "yyyy-MM-dd";
            this.dtProductAdding.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtProductAdding.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtProductAdding.Location = new System.Drawing.Point(130, 372);
            this.dtProductAdding.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtProductAdding.Name = "dtProductAdding";
            this.dtProductAdding.Size = new System.Drawing.Size(135, 27);
            this.dtProductAdding.TabIndex = 49;
            this.dtProductAdding.Value = new System.DateTime(2025, 1, 15, 1, 15, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(967, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(398, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(209, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Managment System";
            // 
            // btnUSave
            // 
            this.btnUSave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnUSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSave.Location = new System.Drawing.Point(27, 481);
            this.btnUSave.Name = "btnUSave";
            this.btnUSave.Size = new System.Drawing.Size(103, 30);
            this.btnUSave.TabIndex = 30;
            this.btnUSave.Text = "Save";
            this.btnUSave.UseVisualStyleBackColor = false;
            this.btnUSave.Click += new System.EventHandler(this.btnUSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmbProductCategory);
            this.panel2.Controls.Add(this.btnUEdit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtProductPrice);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnURemove);
            this.panel2.Controls.Add(this.dtProductAdding);
            this.panel2.Controls.Add(this.btnUClear);
            this.panel2.Controls.Add(this.btnUSave);
            this.panel2.Controls.Add(this.txtProductSupplier);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtProductQuantity);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtProductId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 592);
            this.panel2.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Supplier :";
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Items.AddRange(new object[] {
            "Electronics",
            "Clothings",
            "Instruments",
            ""});
            this.cmbProductCategory.Location = new System.Drawing.Point(130, 221);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(135, 24);
            this.cmbProductCategory.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Category :";
            // 
            // btnUClear
            // 
            this.btnUClear.BackColor = System.Drawing.Color.Gray;
            this.btnUClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUClear.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnUClear.Location = new System.Drawing.Point(27, 534);
            this.btnUClear.Name = "btnUClear";
            this.btnUClear.Size = new System.Drawing.Size(103, 30);
            this.btnUClear.TabIndex = 23;
            this.btnUClear.Text = "Clear All";
            this.btnUClear.UseVisualStyleBackColor = false;
            this.btnUClear.Click += new System.EventHandler(this.btnUClear_Click);
            // 
            // txtProductSupplier
            // 
            this.txtProductSupplier.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSupplier.Location = new System.Drawing.Point(130, 319);
            this.txtProductSupplier.Name = "txtProductSupplier";
            this.txtProductSupplier.Size = new System.Drawing.Size(135, 25);
            this.txtProductSupplier.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Quantity :";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductQuantity.Location = new System.Drawing.Point(130, 270);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(135, 25);
            this.txtProductQuantity.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Id :";
            // 
            // txtProductId
            // 
            this.txtProductId.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(130, 121);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(135, 25);
            this.txtProductId.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Name :";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(130, 169);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(135, 25);
            this.txtProductName.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 120);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 713);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageProducts_FormClosed);
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSetBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUSearch;
        private System.Windows.Forms.TextBox txtProductIdSearch;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnURemove;
        private System.Windows.Forms.DateTimePicker dtProductAdding;
        private System.Windows.Forms.Button btnUEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource inventorydbDataSetBindingSource;
        private System.Windows.Forms.BindingSource inventorydbDataSetBindingSource1;
        private System.Windows.Forms.Button btnUSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUClear;
        private System.Windows.Forms.TextBox txtProductSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProductInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adding_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}