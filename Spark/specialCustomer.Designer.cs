namespace Spark
{
    partial class specialCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(specialCustomer));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfParts = new System.Windows.Forms.Label();
            this.partNumBx = new System.Windows.Forms.NumericUpDown();
            this.stocktxt = new System.Windows.Forms.Label();
            this.searchResult5 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.Label();
            this.edituserlbl = new System.Windows.Forms.Label();
            this.editUsericon = new System.Windows.Forms.Label();
            this.checkout1 = new System.Windows.Forms.Label();
            this.logoutlbl1 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.deleteRowlbl = new System.Windows.Forms.Label();
            this.checkoutlbl = new System.Windows.Forms.Label();
            this.cartlbl = new System.Windows.Forms.Label();
            this.parttypetxt = new System.Windows.Forms.Label();
            this.modelnametxt = new System.Windows.Forms.Label();
            this.brandnametxt = new System.Windows.Forms.Label();
            this.searchResult4 = new System.Windows.Forms.Label();
            this.searchResult3 = new System.Windows.Forms.Label();
            this.searchResult2 = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Label();
            this.searchResult1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Label();
            this.parttypeCB = new System.Windows.Forms.ComboBox();
            this.modelnameCB = new System.Windows.Forms.ComboBox();
            this.brandnameCB = new System.Windows.Forms.ComboBox();
            this.partType = new System.Windows.Forms.Label();
            this.modelname = new System.Windows.Forms.Label();
            this.brandname = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.horizontalLine = new System.Windows.Forms.Label();
            this.homeText = new System.Windows.Forms.Label();
            this.homeLogo = new System.Windows.Forms.Label();
            this.secondTitle = new System.Windows.Forms.Label();
            this.mainLogo = new System.Windows.Forms.Label();
            this.discountlbl = new System.Windows.Forms.Label();
            this.discountTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumBx)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5});
            this.dataGrid.Location = new System.Drawing.Point(421, 122);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.Size = new System.Drawing.Size(544, 255);
            this.dataGrid.TabIndex = 142;
            // 
            // col1
            // 
            this.col1.HeaderText = "Brandname";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col2
            // 
            this.col2.HeaderText = "Model Name";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            this.col2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col2.Width = 120;
            // 
            // col3
            // 
            this.col3.HeaderText = "Part Type";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            this.col3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col4
            // 
            this.col4.HeaderText = "Price";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            this.col4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col5
            // 
            this.col5.HeaderText = "Quantity";
            this.col5.Name = "col5";
            this.col5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // noOfParts
            // 
            this.noOfParts.AutoSize = true;
            this.noOfParts.BackColor = System.Drawing.Color.Transparent;
            this.noOfParts.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfParts.Location = new System.Drawing.Point(37, 524);
            this.noOfParts.Name = "noOfParts";
            this.noOfParts.Size = new System.Drawing.Size(0, 18);
            this.noOfParts.TabIndex = 141;
            // 
            // partNumBx
            // 
            this.partNumBx.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumBx.Location = new System.Drawing.Point(177, 524);
            this.partNumBx.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.partNumBx.Name = "partNumBx";
            this.partNumBx.Size = new System.Drawing.Size(60, 25);
            this.partNumBx.TabIndex = 140;
            this.partNumBx.Visible = false;
            // 
            // stocktxt
            // 
            this.stocktxt.AutoSize = true;
            this.stocktxt.BackColor = System.Drawing.Color.Transparent;
            this.stocktxt.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocktxt.Location = new System.Drawing.Point(177, 458);
            this.stocktxt.Name = "stocktxt";
            this.stocktxt.Size = new System.Drawing.Size(0, 18);
            this.stocktxt.TabIndex = 139;
            // 
            // searchResult5
            // 
            this.searchResult5.AutoSize = true;
            this.searchResult5.BackColor = System.Drawing.Color.Transparent;
            this.searchResult5.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResult5.Location = new System.Drawing.Point(37, 458);
            this.searchResult5.Name = "searchResult5";
            this.searchResult5.Size = new System.Drawing.Size(0, 18);
            this.searchResult5.TabIndex = 138;
            // 
            // pricetxt
            // 
            this.pricetxt.AutoSize = true;
            this.pricetxt.BackColor = System.Drawing.Color.Transparent;
            this.pricetxt.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(177, 425);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(0, 18);
            this.pricetxt.TabIndex = 137;
            // 
            // edituserlbl
            // 
            this.edituserlbl.AutoSize = true;
            this.edituserlbl.BackColor = System.Drawing.Color.Gray;
            this.edituserlbl.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edituserlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.edituserlbl.Location = new System.Drawing.Point(853, 36);
            this.edituserlbl.Margin = new System.Windows.Forms.Padding(0);
            this.edituserlbl.Name = "edituserlbl";
            this.edituserlbl.Padding = new System.Windows.Forms.Padding(3);
            this.edituserlbl.Size = new System.Drawing.Size(112, 30);
            this.edituserlbl.TabIndex = 150;
            this.edituserlbl.Text = "Edit Profile";
            this.edituserlbl.Visible = false;
            this.edituserlbl.Click += new System.EventHandler(this.edituserlbl_Click);
            // 
            // editUsericon
            // 
            this.editUsericon.AutoSize = true;
            this.editUsericon.BackColor = System.Drawing.Color.Transparent;
            this.editUsericon.Image = ((System.Drawing.Image)(resources.GetObject("editUsericon.Image")));
            this.editUsericon.Location = new System.Drawing.Point(963, 36);
            this.editUsericon.MinimumSize = new System.Drawing.Size(30, 30);
            this.editUsericon.Name = "editUsericon";
            this.editUsericon.Size = new System.Drawing.Size(30, 30);
            this.editUsericon.TabIndex = 149;
            this.editUsericon.Click += new System.EventHandler(this.editUsericon_Click);
            // 
            // checkout1
            // 
            this.checkout1.AutoSize = true;
            this.checkout1.BackColor = System.Drawing.Color.Transparent;
            this.checkout1.Font = new System.Drawing.Font("Raleway Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkout1.Location = new System.Drawing.Point(822, 455);
            this.checkout1.Name = "checkout1";
            this.checkout1.Size = new System.Drawing.Size(140, 22);
            this.checkout1.TabIndex = 148;
            this.checkout1.Text = "No Item in Cart";
            this.checkout1.Visible = false;
            // 
            // logoutlbl1
            // 
            this.logoutlbl1.AutoSize = true;
            this.logoutlbl1.BackColor = System.Drawing.Color.Gray;
            this.logoutlbl1.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutlbl1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutlbl1.Location = new System.Drawing.Point(871, 4);
            this.logoutlbl1.Margin = new System.Windows.Forms.Padding(0);
            this.logoutlbl1.Name = "logoutlbl1";
            this.logoutlbl1.Padding = new System.Windows.Forms.Padding(3);
            this.logoutlbl1.Size = new System.Drawing.Size(90, 30);
            this.logoutlbl1.TabIndex = 147;
            this.logoutlbl1.Text = "Log Out";
            this.logoutlbl1.Visible = false;
            this.logoutlbl1.Click += new System.EventHandler(this.logoutlbl1_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(962, 4);
            this.logout.MinimumSize = new System.Drawing.Size(30, 30);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(30, 30);
            this.logout.TabIndex = 146;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // deleteRowlbl
            // 
            this.deleteRowlbl.AutoSize = true;
            this.deleteRowlbl.BackColor = System.Drawing.Color.Transparent;
            this.deleteRowlbl.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRowlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteRowlbl.Location = new System.Drawing.Point(828, 382);
            this.deleteRowlbl.Name = "deleteRowlbl";
            this.deleteRowlbl.Size = new System.Drawing.Size(134, 24);
            this.deleteRowlbl.TabIndex = 145;
            this.deleteRowlbl.Text = "Remove Item";
            this.deleteRowlbl.Click += new System.EventHandler(this.deleteRowlbl_Click);
            // 
            // checkoutlbl
            // 
            this.checkoutlbl.AutoSize = true;
            this.checkoutlbl.BackColor = System.Drawing.Color.Transparent;
            this.checkoutlbl.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkoutlbl.Location = new System.Drawing.Point(759, 431);
            this.checkoutlbl.Name = "checkoutlbl";
            this.checkoutlbl.Size = new System.Drawing.Size(206, 24);
            this.checkoutlbl.TabIndex = 144;
            this.checkoutlbl.Text = "Procced to Checkout";
            this.checkoutlbl.Click += new System.EventHandler(this.checkoutlbl_Click);
            // 
            // cartlbl
            // 
            this.cartlbl.AutoSize = true;
            this.cartlbl.BackColor = System.Drawing.Color.Transparent;
            this.cartlbl.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartlbl.Location = new System.Drawing.Point(417, 92);
            this.cartlbl.Name = "cartlbl";
            this.cartlbl.Size = new System.Drawing.Size(48, 24);
            this.cartlbl.TabIndex = 143;
            this.cartlbl.Text = "Cart";
            // 
            // parttypetxt
            // 
            this.parttypetxt.AutoSize = true;
            this.parttypetxt.BackColor = System.Drawing.Color.Transparent;
            this.parttypetxt.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parttypetxt.Location = new System.Drawing.Point(177, 392);
            this.parttypetxt.Name = "parttypetxt";
            this.parttypetxt.Size = new System.Drawing.Size(0, 18);
            this.parttypetxt.TabIndex = 136;
            // 
            // modelnametxt
            // 
            this.modelnametxt.AutoSize = true;
            this.modelnametxt.BackColor = System.Drawing.Color.Transparent;
            this.modelnametxt.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelnametxt.Location = new System.Drawing.Point(177, 359);
            this.modelnametxt.Name = "modelnametxt";
            this.modelnametxt.Size = new System.Drawing.Size(0, 18);
            this.modelnametxt.TabIndex = 135;
            // 
            // brandnametxt
            // 
            this.brandnametxt.AutoSize = true;
            this.brandnametxt.BackColor = System.Drawing.Color.Transparent;
            this.brandnametxt.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandnametxt.Location = new System.Drawing.Point(177, 327);
            this.brandnametxt.Name = "brandnametxt";
            this.brandnametxt.Size = new System.Drawing.Size(0, 18);
            this.brandnametxt.TabIndex = 134;
            // 
            // searchResult4
            // 
            this.searchResult4.AutoSize = true;
            this.searchResult4.BackColor = System.Drawing.Color.Transparent;
            this.searchResult4.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResult4.Location = new System.Drawing.Point(37, 425);
            this.searchResult4.Name = "searchResult4";
            this.searchResult4.Size = new System.Drawing.Size(0, 18);
            this.searchResult4.TabIndex = 133;
            // 
            // searchResult3
            // 
            this.searchResult3.AutoSize = true;
            this.searchResult3.BackColor = System.Drawing.Color.Transparent;
            this.searchResult3.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResult3.Location = new System.Drawing.Point(37, 392);
            this.searchResult3.Name = "searchResult3";
            this.searchResult3.Size = new System.Drawing.Size(0, 18);
            this.searchResult3.TabIndex = 132;
            // 
            // searchResult2
            // 
            this.searchResult2.AutoSize = true;
            this.searchResult2.BackColor = System.Drawing.Color.Transparent;
            this.searchResult2.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResult2.Location = new System.Drawing.Point(37, 359);
            this.searchResult2.Name = "searchResult2";
            this.searchResult2.Size = new System.Drawing.Size(0, 18);
            this.searchResult2.TabIndex = 131;
            // 
            // addToCart
            // 
            this.addToCart.AutoSize = true;
            this.addToCart.BackColor = System.Drawing.Color.Transparent;
            this.addToCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addToCart.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCart.Location = new System.Drawing.Point(38, 575);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(101, 22);
            this.addToCart.TabIndex = 130;
            this.addToCart.Text = "Add to Cart";
            this.addToCart.Visible = false;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // searchResult1
            // 
            this.searchResult1.AutoSize = true;
            this.searchResult1.BackColor = System.Drawing.Color.Transparent;
            this.searchResult1.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResult1.Location = new System.Drawing.Point(37, 327);
            this.searchResult1.Name = "searchResult1";
            this.searchResult1.Size = new System.Drawing.Size(0, 18);
            this.searchResult1.TabIndex = 129;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(237, 269);
            this.search.MinimumSize = new System.Drawing.Size(30, 28);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(30, 28);
            this.search.TabIndex = 128;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // parttypeCB
            // 
            this.parttypeCB.DropDownHeight = 120;
            this.parttypeCB.DropDownWidth = 200;
            this.parttypeCB.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parttypeCB.FormattingEnabled = true;
            this.parttypeCB.IntegralHeight = false;
            this.parttypeCB.Location = new System.Drawing.Point(31, 266);
            this.parttypeCB.Name = "parttypeCB";
            this.parttypeCB.Size = new System.Drawing.Size(200, 32);
            this.parttypeCB.TabIndex = 127;
            // 
            // modelnameCB
            // 
            this.modelnameCB.DropDownHeight = 120;
            this.modelnameCB.DropDownWidth = 200;
            this.modelnameCB.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelnameCB.FormattingEnabled = true;
            this.modelnameCB.IntegralHeight = false;
            this.modelnameCB.Location = new System.Drawing.Point(30, 200);
            this.modelnameCB.Name = "modelnameCB";
            this.modelnameCB.Size = new System.Drawing.Size(200, 32);
            this.modelnameCB.TabIndex = 126;
            // 
            // brandnameCB
            // 
            this.brandnameCB.DropDownHeight = 120;
            this.brandnameCB.DropDownWidth = 200;
            this.brandnameCB.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandnameCB.FormattingEnabled = true;
            this.brandnameCB.IntegralHeight = false;
            this.brandnameCB.Location = new System.Drawing.Point(30, 135);
            this.brandnameCB.Name = "brandnameCB";
            this.brandnameCB.Size = new System.Drawing.Size(200, 32);
            this.brandnameCB.TabIndex = 125;
            this.brandnameCB.SelectedIndexChanged += new System.EventHandler(this.brandnameCB_SelectedIndexChanged);
            // 
            // partType
            // 
            this.partType.AutoSize = true;
            this.partType.BackColor = System.Drawing.Color.Transparent;
            this.partType.Font = new System.Drawing.Font("Raleway Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partType.Location = new System.Drawing.Point(28, 245);
            this.partType.Name = "partType";
            this.partType.Size = new System.Drawing.Size(73, 18);
            this.partType.TabIndex = 124;
            this.partType.Text = "Part Type";
            // 
            // modelname
            // 
            this.modelname.AutoSize = true;
            this.modelname.BackColor = System.Drawing.Color.Transparent;
            this.modelname.Font = new System.Drawing.Font("Raleway Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelname.Location = new System.Drawing.Point(28, 179);
            this.modelname.Name = "modelname";
            this.modelname.Size = new System.Drawing.Size(99, 18);
            this.modelname.TabIndex = 123;
            this.modelname.Text = "Model Name";
            // 
            // brandname
            // 
            this.brandname.AutoSize = true;
            this.brandname.BackColor = System.Drawing.Color.Transparent;
            this.brandname.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandname.Location = new System.Drawing.Point(27, 119);
            this.brandname.Name = "brandname";
            this.brandname.Size = new System.Drawing.Size(96, 18);
            this.brandname.TabIndex = 122;
            this.brandname.Text = "Brand Name";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(839, 63);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 24);
            this.username.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Raleway Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(751, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 120;
            this.label1.Text = "welcome";
            // 
            // horizontalLine
            // 
            this.horizontalLine.AutoSize = true;
            this.horizontalLine.BackColor = System.Drawing.SystemColors.Control;
            this.horizontalLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontalLine.Location = new System.Drawing.Point(245, 74);
            this.horizontalLine.MinimumSize = new System.Drawing.Size(500, 0);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(500, 4);
            this.horizontalLine.TabIndex = 119;
            // 
            // homeText
            // 
            this.homeText.AutoSize = true;
            this.homeText.BackColor = System.Drawing.Color.Transparent;
            this.homeText.Font = new System.Drawing.Font("Raleway Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeText.Location = new System.Drawing.Point(300, 39);
            this.homeText.Name = "homeText";
            this.homeText.Size = new System.Drawing.Size(90, 33);
            this.homeText.TabIndex = 118;
            this.homeText.Text = "home";
            // 
            // homeLogo
            // 
            this.homeLogo.AutoSize = true;
            this.homeLogo.BackColor = System.Drawing.Color.Transparent;
            this.homeLogo.Image = ((System.Drawing.Image)(resources.GetObject("homeLogo.Image")));
            this.homeLogo.Location = new System.Drawing.Point(235, 29);
            this.homeLogo.MinimumSize = new System.Drawing.Size(50, 47);
            this.homeLogo.Name = "homeLogo";
            this.homeLogo.Size = new System.Drawing.Size(50, 47);
            this.homeLogo.TabIndex = 117;
            // 
            // secondTitle
            // 
            this.secondTitle.AutoSize = true;
            this.secondTitle.BackColor = System.Drawing.Color.Transparent;
            this.secondTitle.Font = new System.Drawing.Font("Rage Italic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTitle.Location = new System.Drawing.Point(33, 73);
            this.secondTitle.Name = "secondTitle";
            this.secondTitle.Size = new System.Drawing.Size(96, 21);
            this.secondTitle.TabIndex = 116;
            this.secondTitle.Text = "Get Sparked";
            // 
            // mainLogo
            // 
            this.mainLogo.AutoSize = true;
            this.mainLogo.BackColor = System.Drawing.Color.Transparent;
            this.mainLogo.ForeColor = System.Drawing.Color.Transparent;
            this.mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainLogo.Image")));
            this.mainLogo.Location = new System.Drawing.Point(5, -1);
            this.mainLogo.MinimumSize = new System.Drawing.Size(240, 103);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(240, 103);
            this.mainLogo.TabIndex = 115;
            // 
            // discountlbl
            // 
            this.discountlbl.AutoSize = true;
            this.discountlbl.BackColor = System.Drawing.Color.Transparent;
            this.discountlbl.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountlbl.Location = new System.Drawing.Point(37, 490);
            this.discountlbl.Name = "discountlbl";
            this.discountlbl.Size = new System.Drawing.Size(0, 18);
            this.discountlbl.TabIndex = 151;
            // 
            // discountTxt
            // 
            this.discountTxt.AutoSize = true;
            this.discountTxt.BackColor = System.Drawing.Color.Transparent;
            this.discountTxt.Font = new System.Drawing.Font("Raleway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTxt.Location = new System.Drawing.Point(177, 490);
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(0, 18);
            this.discountTxt.TabIndex = 152;
            // 
            // specialCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 613);
            this.Controls.Add(this.discountTxt);
            this.Controls.Add(this.discountlbl);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.noOfParts);
            this.Controls.Add(this.partNumBx);
            this.Controls.Add(this.stocktxt);
            this.Controls.Add(this.searchResult5);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.edituserlbl);
            this.Controls.Add(this.editUsericon);
            this.Controls.Add(this.checkout1);
            this.Controls.Add(this.logoutlbl1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.deleteRowlbl);
            this.Controls.Add(this.checkoutlbl);
            this.Controls.Add(this.cartlbl);
            this.Controls.Add(this.parttypetxt);
            this.Controls.Add(this.modelnametxt);
            this.Controls.Add(this.brandnametxt);
            this.Controls.Add(this.searchResult4);
            this.Controls.Add(this.searchResult3);
            this.Controls.Add(this.searchResult2);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.searchResult1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.parttypeCB);
            this.Controls.Add(this.modelnameCB);
            this.Controls.Add(this.brandnameCB);
            this.Controls.Add(this.partType);
            this.Controls.Add(this.modelname);
            this.Controls.Add(this.brandname);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.homeText);
            this.Controls.Add(this.homeLogo);
            this.Controls.Add(this.secondTitle);
            this.Controls.Add(this.mainLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "specialCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "specialCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.Label noOfParts;
        private System.Windows.Forms.NumericUpDown partNumBx;
        private System.Windows.Forms.Label stocktxt;
        private System.Windows.Forms.Label searchResult5;
        private System.Windows.Forms.Label pricetxt;
        private System.Windows.Forms.Label edituserlbl;
        private System.Windows.Forms.Label editUsericon;
        private System.Windows.Forms.Label checkout1;
        private System.Windows.Forms.Label logoutlbl1;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label deleteRowlbl;
        private System.Windows.Forms.Label checkoutlbl;
        private System.Windows.Forms.Label cartlbl;
        private System.Windows.Forms.Label parttypetxt;
        private System.Windows.Forms.Label modelnametxt;
        private System.Windows.Forms.Label brandnametxt;
        private System.Windows.Forms.Label searchResult4;
        private System.Windows.Forms.Label searchResult3;
        private System.Windows.Forms.Label searchResult2;
        private System.Windows.Forms.Label addToCart;
        private System.Windows.Forms.Label searchResult1;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.ComboBox parttypeCB;
        private System.Windows.Forms.ComboBox modelnameCB;
        private System.Windows.Forms.ComboBox brandnameCB;
        private System.Windows.Forms.Label partType;
        private System.Windows.Forms.Label modelname;
        private System.Windows.Forms.Label brandname;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label horizontalLine;
        private System.Windows.Forms.Label homeText;
        private System.Windows.Forms.Label homeLogo;
        private System.Windows.Forms.Label secondTitle;
        private System.Windows.Forms.Label mainLogo;
        private System.Windows.Forms.Label discountlbl;
        private System.Windows.Forms.Label discountTxt;
    }
}