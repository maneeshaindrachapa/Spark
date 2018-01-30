namespace Spark
{
    partial class supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier));
            this.editUsericon = new System.Windows.Forms.Label();
            this.loadDatalbl = new System.Windows.Forms.Label();
            this.supplierDetailsPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.supplierDetailsPrint = new System.Drawing.Printing.PrintDocument();
            this.print = new System.Windows.Forms.Label();
            this.buyPartslbl = new System.Windows.Forms.Label();
            this.addIteNE = new System.Windows.Forms.Label();
            this.priceNUD = new System.Windows.Forms.NumericUpDown();
            this.edituserlbl = new System.Windows.Forms.Label();
            this.transactionDG = new System.Windows.Forms.DataGridView();
            this.modelnameCB = new System.Windows.Forms.ComboBox();
            this.addItemLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityNUD = new System.Windows.Forms.NumericUpDown();
            this.parttypeCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.brandnameCB = new System.Windows.Forms.ComboBox();
            this.brandnamelbl = new System.Windows.Forms.Label();
            this.adItemlbl = new System.Windows.Forms.Label();
            this.logoutlbl1 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.horizontalLine = new System.Windows.Forms.Label();
            this.homeText = new System.Windows.Forms.Label();
            this.homeLogo = new System.Windows.Forms.Label();
            this.secondTitle = new System.Windows.Forms.Label();
            this.mainLogo = new System.Windows.Forms.Label();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // editUsericon
            // 
            this.editUsericon.AutoSize = true;
            this.editUsericon.BackColor = System.Drawing.Color.Transparent;
            this.editUsericon.Image = ((System.Drawing.Image)(resources.GetObject("editUsericon.Image")));
            this.editUsericon.Location = new System.Drawing.Point(945, 37);
            this.editUsericon.MinimumSize = new System.Drawing.Size(30, 30);
            this.editUsericon.Name = "editUsericon";
            this.editUsericon.Size = new System.Drawing.Size(30, 30);
            this.editUsericon.TabIndex = 103;
            this.editUsericon.Click += new System.EventHandler(this.editUsericon_Click);
            // 
            // loadDatalbl
            // 
            this.loadDatalbl.AutoSize = true;
            this.loadDatalbl.BackColor = System.Drawing.Color.White;
            this.loadDatalbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadDatalbl.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDatalbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadDatalbl.Location = new System.Drawing.Point(802, 473);
            this.loadDatalbl.MinimumSize = new System.Drawing.Size(165, 2);
            this.loadDatalbl.Name = "loadDatalbl";
            this.loadDatalbl.Size = new System.Drawing.Size(165, 26);
            this.loadDatalbl.TabIndex = 102;
            this.loadDatalbl.Text = "Load Data";
            this.loadDatalbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loadDatalbl.Click += new System.EventHandler(this.loadDatalbl_Click);
            // 
            // supplierDetailsPreviewDialog
            // 
            this.supplierDetailsPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.supplierDetailsPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.supplierDetailsPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.supplierDetailsPreviewDialog.Enabled = true;
            this.supplierDetailsPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("supplierDetailsPreviewDialog.Icon")));
            this.supplierDetailsPreviewDialog.Name = "supplierDetailsPreviewDialog";
            this.supplierDetailsPreviewDialog.Visible = false;
            // 
            // supplierDetailsPrint
            // 
            this.supplierDetailsPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.supplierDetailsPrint_PrintPage);
            // 
            // print
            // 
            this.print.AutoSize = true;
            this.print.BackColor = System.Drawing.Color.White;
            this.print.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.print.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.print.Location = new System.Drawing.Point(801, 515);
            this.print.MinimumSize = new System.Drawing.Size(165, 2);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(165, 26);
            this.print.TabIndex = 101;
            this.print.Text = "Print";
            this.print.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // buyPartslbl
            // 
            this.buyPartslbl.AutoSize = true;
            this.buyPartslbl.BackColor = System.Drawing.Color.White;
            this.buyPartslbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buyPartslbl.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPartslbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buyPartslbl.Location = new System.Drawing.Point(34, 528);
            this.buyPartslbl.MinimumSize = new System.Drawing.Size(165, 2);
            this.buyPartslbl.Name = "buyPartslbl";
            this.buyPartslbl.Size = new System.Drawing.Size(165, 26);
            this.buyPartslbl.TabIndex = 100;
            this.buyPartslbl.Text = "Buy Parts";
            this.buyPartslbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buyPartslbl.Click += new System.EventHandler(this.buyPartslbl_Click);
            // 
            // addIteNE
            // 
            this.addIteNE.AutoSize = true;
            this.addIteNE.BackColor = System.Drawing.Color.LightGray;
            this.addIteNE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addIteNE.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIteNE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addIteNE.Location = new System.Drawing.Point(34, 473);
            this.addIteNE.MinimumSize = new System.Drawing.Size(165, 2);
            this.addIteNE.Name = "addIteNE";
            this.addIteNE.Size = new System.Drawing.Size(165, 26);
            this.addIteNE.TabIndex = 99;
            this.addIteNE.Text = "Add Items";
            this.addIteNE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // priceNUD
            // 
            this.priceNUD.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNUD.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.priceNUD.Location = new System.Drawing.Point(34, 426);
            this.priceNUD.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.priceNUD.Name = "priceNUD";
            this.priceNUD.Size = new System.Drawing.Size(160, 31);
            this.priceNUD.TabIndex = 98;
            // 
            // edituserlbl
            // 
            this.edituserlbl.AutoSize = true;
            this.edituserlbl.BackColor = System.Drawing.Color.Gray;
            this.edituserlbl.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edituserlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.edituserlbl.Location = new System.Drawing.Point(835, 37);
            this.edituserlbl.Margin = new System.Windows.Forms.Padding(0);
            this.edituserlbl.Name = "edituserlbl";
            this.edituserlbl.Padding = new System.Windows.Forms.Padding(3);
            this.edituserlbl.Size = new System.Drawing.Size(112, 30);
            this.edituserlbl.TabIndex = 104;
            this.edituserlbl.Text = "Edit Profile";
            this.edituserlbl.Visible = false;
            this.edituserlbl.Click += new System.EventHandler(this.edituserlbl_Click);
            // 
            // transactionDG
            // 
            this.transactionDG.AllowUserToAddRows = false;
            this.transactionDG.AllowUserToDeleteRows = false;
            this.transactionDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6,
            this.col7,
            this.balance});
            this.transactionDG.Location = new System.Drawing.Point(243, 122);
            this.transactionDG.MultiSelect = false;
            this.transactionDG.Name = "transactionDG";
            this.transactionDG.ReadOnly = true;
            this.transactionDG.RowTemplate.Height = 24;
            this.transactionDG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.transactionDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionDG.Size = new System.Drawing.Size(724, 335);
            this.transactionDG.TabIndex = 97;
            // 
            // modelnameCB
            // 
            this.modelnameCB.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelnameCB.FormattingEnabled = true;
            this.modelnameCB.Location = new System.Drawing.Point(33, 237);
            this.modelnameCB.Name = "modelnameCB";
            this.modelnameCB.Size = new System.Drawing.Size(160, 32);
            this.modelnameCB.TabIndex = 96;
            this.modelnameCB.SelectedIndexChanged += new System.EventHandler(this.modelnameCB_SelectedIndexChanged);
            // 
            // addItemLbl
            // 
            this.addItemLbl.AutoSize = true;
            this.addItemLbl.BackColor = System.Drawing.Color.White;
            this.addItemLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addItemLbl.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addItemLbl.Location = new System.Drawing.Point(34, 473);
            this.addItemLbl.MinimumSize = new System.Drawing.Size(165, 2);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(165, 26);
            this.addItemLbl.TabIndex = 95;
            this.addItemLbl.Text = "Add Items";
            this.addItemLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addItemLbl.Visible = false;
            this.addItemLbl.Click += new System.EventHandler(this.addItemLbl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 121);
            this.label6.MinimumSize = new System.Drawing.Size(2, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 400);
            this.label6.TabIndex = 94;
            // 
            // quantityNUD
            // 
            this.quantityNUD.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNUD.Location = new System.Drawing.Point(35, 361);
            this.quantityNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantityNUD.Name = "quantityNUD";
            this.quantityNUD.Size = new System.Drawing.Size(160, 31);
            this.quantityNUD.TabIndex = 93;
            // 
            // parttypeCB
            // 
            this.parttypeCB.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parttypeCB.FormattingEnabled = true;
            this.parttypeCB.Location = new System.Drawing.Point(34, 297);
            this.parttypeCB.Name = "parttypeCB";
            this.parttypeCB.Size = new System.Drawing.Size(160, 32);
            this.parttypeCB.TabIndex = 92;
            this.parttypeCB.SelectedIndexChanged += new System.EventHandler(this.parttypeCB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 91;
            this.label5.Text = "Price / Part";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 90;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 89;
            this.label3.Text = "Part Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 88;
            this.label2.Text = "Model Name";
            // 
            // brandnameCB
            // 
            this.brandnameCB.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandnameCB.FormattingEnabled = true;
            this.brandnameCB.Location = new System.Drawing.Point(34, 176);
            this.brandnameCB.Name = "brandnameCB";
            this.brandnameCB.Size = new System.Drawing.Size(160, 32);
            this.brandnameCB.TabIndex = 87;
            this.brandnameCB.SelectedIndexChanged += new System.EventHandler(this.brandnameCB_SelectedIndexChanged);
            // 
            // brandnamelbl
            // 
            this.brandnamelbl.AutoSize = true;
            this.brandnamelbl.BackColor = System.Drawing.Color.Transparent;
            this.brandnamelbl.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandnamelbl.Location = new System.Drawing.Point(31, 158);
            this.brandnamelbl.Name = "brandnamelbl";
            this.brandnamelbl.Size = new System.Drawing.Size(91, 16);
            this.brandnamelbl.TabIndex = 86;
            this.brandnamelbl.Text = "Brand Name";
            // 
            // adItemlbl
            // 
            this.adItemlbl.AutoSize = true;
            this.adItemlbl.BackColor = System.Drawing.Color.Transparent;
            this.adItemlbl.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adItemlbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adItemlbl.Location = new System.Drawing.Point(30, 121);
            this.adItemlbl.Name = "adItemlbl";
            this.adItemlbl.Size = new System.Drawing.Size(104, 24);
            this.adItemlbl.TabIndex = 85;
            this.adItemlbl.Text = "Add Items";
            // 
            // logoutlbl1
            // 
            this.logoutlbl1.AutoSize = true;
            this.logoutlbl1.BackColor = System.Drawing.Color.Gray;
            this.logoutlbl1.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutlbl1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutlbl1.Location = new System.Drawing.Point(854, 4);
            this.logoutlbl1.Margin = new System.Windows.Forms.Padding(0);
            this.logoutlbl1.Name = "logoutlbl1";
            this.logoutlbl1.Padding = new System.Windows.Forms.Padding(3);
            this.logoutlbl1.Size = new System.Drawing.Size(90, 30);
            this.logoutlbl1.TabIndex = 84;
            this.logoutlbl1.Text = "Log Out";
            this.logoutlbl1.Visible = false;
            this.logoutlbl1.Click += new System.EventHandler(this.logoutlbl1_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(945, 4);
            this.logout.MinimumSize = new System.Drawing.Size(30, 30);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(30, 30);
            this.logout.TabIndex = 83;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(826, 61);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 24);
            this.username.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Raleway Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(748, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = "welcome";
            // 
            // horizontalLine
            // 
            this.horizontalLine.AutoSize = true;
            this.horizontalLine.BackColor = System.Drawing.SystemColors.Control;
            this.horizontalLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontalLine.Location = new System.Drawing.Point(242, 72);
            this.horizontalLine.MinimumSize = new System.Drawing.Size(500, 0);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(500, 4);
            this.horizontalLine.TabIndex = 80;
            // 
            // homeText
            // 
            this.homeText.AutoSize = true;
            this.homeText.BackColor = System.Drawing.Color.Transparent;
            this.homeText.Font = new System.Drawing.Font("Raleway Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeText.Location = new System.Drawing.Point(297, 37);
            this.homeText.Name = "homeText";
            this.homeText.Size = new System.Drawing.Size(213, 33);
            this.homeText.TabIndex = 79;
            this.homeText.Text = "Supplier Details";
            // 
            // homeLogo
            // 
            this.homeLogo.AutoSize = true;
            this.homeLogo.BackColor = System.Drawing.Color.Transparent;
            this.homeLogo.Image = ((System.Drawing.Image)(resources.GetObject("homeLogo.Image")));
            this.homeLogo.Location = new System.Drawing.Point(240, 29);
            this.homeLogo.MinimumSize = new System.Drawing.Size(50, 47);
            this.homeLogo.Name = "homeLogo";
            this.homeLogo.Size = new System.Drawing.Size(50, 47);
            this.homeLogo.TabIndex = 78;
            // 
            // secondTitle
            // 
            this.secondTitle.AutoSize = true;
            this.secondTitle.BackColor = System.Drawing.Color.Transparent;
            this.secondTitle.Font = new System.Drawing.Font("Rage Italic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTitle.Location = new System.Drawing.Point(30, 71);
            this.secondTitle.Name = "secondTitle";
            this.secondTitle.Size = new System.Drawing.Size(96, 21);
            this.secondTitle.TabIndex = 77;
            this.secondTitle.Text = "Get Sparked";
            // 
            // mainLogo
            // 
            this.mainLogo.AutoSize = true;
            this.mainLogo.BackColor = System.Drawing.Color.Transparent;
            this.mainLogo.ForeColor = System.Drawing.Color.Transparent;
            this.mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainLogo.Image")));
            this.mainLogo.Location = new System.Drawing.Point(2, -3);
            this.mainLogo.MinimumSize = new System.Drawing.Size(240, 103);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(240, 103);
            this.mainLogo.TabIndex = 76;
            // 
            // col1
            // 
            this.col1.HeaderText = "Brandname";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col1.Width = 90;
            // 
            // col2
            // 
            this.col2.HeaderText = "Model Name";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            this.col2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col3
            // 
            this.col3.HeaderText = "Part Name";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            this.col3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col3.Width = 80;
            // 
            // col4
            // 
            this.col4.HeaderText = "Quantity";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            this.col4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col4.Width = 50;
            // 
            // col5
            // 
            this.col5.HeaderText = "Date Added";
            this.col5.Name = "col5";
            this.col5.ReadOnly = true;
            this.col5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col6
            // 
            this.col6.HeaderText = "Price For Part";
            this.col6.Name = "col6";
            this.col6.ReadOnly = true;
            this.col6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col7
            // 
            this.col7.HeaderText = "Paid Value";
            this.col7.Name = "col7";
            this.col7.ReadOnly = true;
            this.col7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // balance
            // 
            this.balance.HeaderText = "Balance";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            // 
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(976, 566);
            this.Controls.Add(this.editUsericon);
            this.Controls.Add(this.loadDatalbl);
            this.Controls.Add(this.print);
            this.Controls.Add(this.buyPartslbl);
            this.Controls.Add(this.addIteNE);
            this.Controls.Add(this.priceNUD);
            this.Controls.Add(this.edituserlbl);
            this.Controls.Add(this.transactionDG);
            this.Controls.Add(this.modelnameCB);
            this.Controls.Add(this.addItemLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantityNUD);
            this.Controls.Add(this.parttypeCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brandnameCB);
            this.Controls.Add(this.brandnamelbl);
            this.Controls.Add(this.adItemlbl);
            this.Controls.Add(this.logoutlbl1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.homeText);
            this.Controls.Add(this.homeLogo);
            this.Controls.Add(this.secondTitle);
            this.Controls.Add(this.mainLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "supplier";
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editUsericon;
        private System.Windows.Forms.Label loadDatalbl;
        private System.Windows.Forms.PrintPreviewDialog supplierDetailsPreviewDialog;
        private System.Drawing.Printing.PrintDocument supplierDetailsPrint;
        private System.Windows.Forms.Label print;
        private System.Windows.Forms.Label buyPartslbl;
        private System.Windows.Forms.Label addIteNE;
        private System.Windows.Forms.NumericUpDown priceNUD;
        private System.Windows.Forms.Label edituserlbl;
        private System.Windows.Forms.DataGridView transactionDG;
        private System.Windows.Forms.ComboBox modelnameCB;
        private System.Windows.Forms.Label addItemLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown quantityNUD;
        private System.Windows.Forms.ComboBox parttypeCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox brandnameCB;
        private System.Windows.Forms.Label brandnamelbl;
        private System.Windows.Forms.Label adItemlbl;
        private System.Windows.Forms.Label logoutlbl1;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label horizontalLine;
        private System.Windows.Forms.Label homeText;
        private System.Windows.Forms.Label homeLogo;
        private System.Windows.Forms.Label secondTitle;
        private System.Windows.Forms.Label mainLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
    }
}