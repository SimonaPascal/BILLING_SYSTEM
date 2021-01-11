
namespace BILLING_SYSTEM
{
    partial class salesAndPurchaseFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salesAndPurchaseFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFooter = new System.Windows.Forms.Label();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.dealerCustomerCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.searchCustomerTextBox = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.contactLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.searchLael = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.dateTimePickerBillDate = new System.Windows.Forms.DateTimePicker();
            this.productPanel = new System.Windows.Forms.Panel();
            this.addProdButton = new System.Windows.Forms.Button();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.productNametextBox = new System.Windows.Forms.TextBox();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.productDetailsLbl = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPrdLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addedProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.vatTextBox = new System.Windows.Forms.TextBox();
            this.gradTotalTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.invoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customerPanel.SuspendLayout();
            this.productPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addedProductsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            this.panelFooter.Controls.Add(this.pictureBox1);
            this.panelFooter.Controls.Add(this.labelFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFooter.Location = new System.Drawing.Point(0, 0);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1469, 42);
            this.panelFooter.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1420, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelFooter
            // 
            this.labelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFooter.AutoSize = true;
            this.labelFooter.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter.ForeColor = System.Drawing.Color.White;
            this.labelFooter.Location = new System.Drawing.Point(587, 9);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(208, 26);
            this.labelFooter.TabIndex = 0;
            this.labelFooter.Text = "PURCHASE AND SALES";
            // 
            // customerPanel
            // 
            this.customerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerPanel.Controls.Add(this.dealerCustomerCombo);
            this.customerPanel.Controls.Add(this.button1);
            this.customerPanel.Controls.Add(this.nameTextBox);
            this.customerPanel.Controls.Add(this.contactTextBox);
            this.customerPanel.Controls.Add(this.addressTextBox);
            this.customerPanel.Controls.Add(this.emailTextBox);
            this.customerPanel.Controls.Add(this.searchCustomerTextBox);
            this.customerPanel.Controls.Add(this.addressLbl);
            this.customerPanel.Controls.Add(this.contactLbl);
            this.customerPanel.Controls.Add(this.emailLbl);
            this.customerPanel.Controls.Add(this.nameLbl);
            this.customerPanel.Controls.Add(this.searchLael);
            this.customerPanel.Controls.Add(this.CustomerLabel);
            this.customerPanel.Location = new System.Drawing.Point(12, 118);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(1444, 130);
            this.customerPanel.TabIndex = 2;
            // 
            // dealerCustomerCombo
            // 
            this.dealerCustomerCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.dealerCustomerCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dealerCustomerCombo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerCustomerCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.dealerCustomerCombo.FormattingEnabled = true;
            this.dealerCustomerCombo.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.dealerCustomerCombo.Location = new System.Drawing.Point(250, 14);
            this.dealerCustomerCombo.Name = "dealerCustomerCombo";
            this.dealerCustomerCombo.Size = new System.Drawing.Size(265, 26);
            this.dealerCustomerCombo.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(137)))), ((int)(((byte)(47)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.button1.Location = new System.Drawing.Point(1070, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "ADD NEW CUSTOMER/DEALER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.nameTextBox.Location = new System.Drawing.Point(73, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(275, 26);
            this.nameTextBox.TabIndex = 12;
            // 
            // contactTextBox
            // 
            this.contactTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.contactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.contactTextBox.Location = new System.Drawing.Point(431, 85);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(275, 26);
            this.contactTextBox.TabIndex = 11;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.addressTextBox.Location = new System.Drawing.Point(776, 46);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(275, 65);
            this.addressTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.emailTextBox.Location = new System.Drawing.Point(431, 46);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(275, 26);
            this.emailTextBox.TabIndex = 8;
            // 
            // searchCustomerTextBox
            // 
            this.searchCustomerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.searchCustomerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchCustomerTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.searchCustomerTextBox.Location = new System.Drawing.Point(73, 46);
            this.searchCustomerTextBox.Name = "searchCustomerTextBox";
            this.searchCustomerTextBox.Size = new System.Drawing.Size(275, 26);
            this.searchCustomerTextBox.TabIndex = 7;
            this.searchCustomerTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.addressLbl.Location = new System.Drawing.Point(712, 48);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(58, 18);
            this.addressLbl.TabIndex = 5;
            this.addressLbl.Text = "Address";
            // 
            // contactLbl
            // 
            this.contactLbl.AutoSize = true;
            this.contactLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.contactLbl.Location = new System.Drawing.Point(363, 85);
            this.contactLbl.Name = "contactLbl";
            this.contactLbl.Size = new System.Drawing.Size(55, 18);
            this.contactLbl.TabIndex = 4;
            this.contactLbl.Text = "Contact";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.emailLbl.Location = new System.Drawing.Point(363, 48);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 18);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "Email";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.nameLbl.Location = new System.Drawing.Point(18, 85);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(45, 18);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name";
            // 
            // searchLael
            // 
            this.searchLael.AutoSize = true;
            this.searchLael.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLael.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.searchLael.Location = new System.Drawing.Point(18, 48);
            this.searchLael.Name = "searchLael";
            this.searchLael.Size = new System.Drawing.Size(49, 18);
            this.searchLael.TabIndex = 1;
            this.searchLael.Text = "Search";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.CustomerLabel.Location = new System.Drawing.Point(17, 16);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(202, 19);
            this.CustomerLabel.TabIndex = 0;
            this.CustomerLabel.Text = "Dealer and Customer Details";
            // 
            // dateTimePickerBillDate
            // 
            this.dateTimePickerBillDate.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBillDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.dateTimePickerBillDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.dateTimePickerBillDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.dateTimePickerBillDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.dateTimePickerBillDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.dateTimePickerBillDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBillDate.Location = new System.Drawing.Point(1137, 70);
            this.dateTimePickerBillDate.Name = "dateTimePickerBillDate";
            this.dateTimePickerBillDate.Size = new System.Drawing.Size(266, 26);
            this.dateTimePickerBillDate.TabIndex = 13;
            // 
            // productPanel
            // 
            this.productPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPanel.Controls.Add(this.addProdButton);
            this.productPanel.Controls.Add(this.qtyTextBox);
            this.productPanel.Controls.Add(this.rateTextBox);
            this.productPanel.Controls.Add(this.productNametextBox);
            this.productPanel.Controls.Add(this.productSearchTextBox);
            this.productPanel.Controls.Add(this.productDetailsLbl);
            this.productPanel.Controls.Add(this.rateLabel);
            this.productPanel.Controls.Add(this.qtyLabel);
            this.productPanel.Controls.Add(this.label1);
            this.productPanel.Controls.Add(this.searchPrdLbl);
            this.productPanel.Location = new System.Drawing.Point(13, 268);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1444, 109);
            this.productPanel.TabIndex = 3;
            // 
            // addProdButton
            // 
            this.addProdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(137)))), ((int)(((byte)(47)))));
            this.addProdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addProdButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.addProdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProdButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProdButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.addProdButton.Location = new System.Drawing.Point(1236, 28);
            this.addProdButton.Name = "addProdButton";
            this.addProdButton.Size = new System.Drawing.Size(173, 56);
            this.addProdButton.TabIndex = 19;
            this.addProdButton.Text = "ADD";
            this.addProdButton.UseVisualStyleBackColor = false;
            this.addProdButton.Click += new System.EventHandler(this.addProdButton_Click);
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.qtyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtyTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.qtyTextBox.Location = new System.Drawing.Point(1014, 45);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(156, 26);
            this.qtyTextBox.TabIndex = 18;
            this.qtyTextBox.Text = "0.00";
            // 
            // rateTextBox
            // 
            this.rateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.rateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rateTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.rateTextBox.Location = new System.Drawing.Point(691, 45);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(156, 26);
            this.rateTextBox.TabIndex = 17;
            this.rateTextBox.Text = "0.00";
            // 
            // productNametextBox
            // 
            this.productNametextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.productNametextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productNametextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNametextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.productNametextBox.Location = new System.Drawing.Point(393, 45);
            this.productNametextBox.Name = "productNametextBox";
            this.productNametextBox.Size = new System.Drawing.Size(156, 26);
            this.productNametextBox.TabIndex = 15;
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.productSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productSearchTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.productSearchTextBox.Location = new System.Drawing.Point(73, 45);
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(156, 26);
            this.productSearchTextBox.TabIndex = 14;
            this.productSearchTextBox.TextChanged += new System.EventHandler(this.productSearchTextBox_TextChanged);
            // 
            // productDetailsLbl
            // 
            this.productDetailsLbl.AutoSize = true;
            this.productDetailsLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDetailsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.productDetailsLbl.Location = new System.Drawing.Point(17, 12);
            this.productDetailsLbl.Name = "productDetailsLbl";
            this.productDetailsLbl.Size = new System.Drawing.Size(114, 19);
            this.productDetailsLbl.TabIndex = 14;
            this.productDetailsLbl.Text = "Product Details";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.rateLabel.Location = new System.Drawing.Point(630, 47);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(36, 18);
            this.rateLabel.TabIndex = 6;
            this.rateLabel.Text = "Rate";
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.qtyLabel.Location = new System.Drawing.Point(935, 47);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(61, 18);
            this.qtyLabel.TabIndex = 4;
            this.qtyLabel.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(323, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // searchPrdLbl
            // 
            this.searchPrdLbl.AutoSize = true;
            this.searchPrdLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPrdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.searchPrdLbl.Location = new System.Drawing.Point(17, 47);
            this.searchPrdLbl.Name = "searchPrdLbl";
            this.searchPrdLbl.Size = new System.Drawing.Size(49, 18);
            this.searchPrdLbl.TabIndex = 2;
            this.searchPrdLbl.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addedProductsDataGridView);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 294);
            this.panel2.TabIndex = 4;
            // 
            // addedProductsDataGridView
            // 
            this.addedProductsDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.addedProductsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.addedProductsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addedProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addedProductsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.addedProductsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.addedProductsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addedProductsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.addedProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.addedProductsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.addedProductsDataGridView.GridColor = System.Drawing.Color.Black;
            this.addedProductsDataGridView.Location = new System.Drawing.Point(21, 37);
            this.addedProductsDataGridView.Name = "addedProductsDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addedProductsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.addedProductsDataGridView.Size = new System.Drawing.Size(676, 254);
            this.addedProductsDataGridView.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Added Products";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.vatTextBox);
            this.panel1.Controls.Add(this.gradTotalTextBox);
            this.panel1.Controls.Add(this.discountTextBox);
            this.panel1.Controls.Add(this.subTotalTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(741, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 294);
            this.panel1.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(137)))), ((int)(((byte)(47)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.saveButton.Location = new System.Drawing.Point(295, 230);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(183, 59);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // vatTextBox
            // 
            this.vatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.vatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vatTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.vatTextBox.Location = new System.Drawing.Point(151, 134);
            this.vatTextBox.Name = "vatTextBox";
            this.vatTextBox.Size = new System.Drawing.Size(529, 26);
            this.vatTextBox.TabIndex = 29;
            this.vatTextBox.Text = "0";
            this.vatTextBox.TextChanged += new System.EventHandler(this.vatTextBox_TextChanged);
            // 
            // gradTotalTextBox
            // 
            this.gradTotalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.gradTotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradTotalTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradTotalTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.gradTotalTextBox.Location = new System.Drawing.Point(151, 178);
            this.gradTotalTextBox.Name = "gradTotalTextBox";
            this.gradTotalTextBox.Size = new System.Drawing.Size(529, 27);
            this.gradTotalTextBox.TabIndex = 28;
            this.gradTotalTextBox.Text = "0";
            // 
            // discountTextBox
            // 
            this.discountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.discountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.discountTextBox.Location = new System.Drawing.Point(151, 92);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(529, 26);
            this.discountTextBox.TabIndex = 27;
            this.discountTextBox.Text = "0";
            this.discountTextBox.TextChanged += new System.EventHandler(this.discountTextBox_TextChanged);
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.subTotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.subTotalTextBox.Location = new System.Drawing.Point(151, 53);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(529, 26);
            this.subTotalTextBox.TabIndex = 14;
            this.subTotalTextBox.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.label8.Location = new System.Drawing.Point(43, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "VAT (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.label6.Location = new System.Drawing.Point(43, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Discount (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.label5.Location = new System.Drawing.Point(40, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Grand Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.label4.Location = new System.Drawing.Point(43, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sub Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.label3.Location = new System.Drawing.Point(23, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Calculation Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.label7.Location = new System.Drawing.Point(30, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "INVOICE NUMBER";
            // 
            // invoiceNumberTextBox
            // 
            this.invoiceNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.invoiceNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceNumberTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNumberTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.invoiceNumberTextBox.Location = new System.Drawing.Point(165, 69);
            this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            this.invoiceNumberTextBox.Size = new System.Drawing.Size(275, 26);
            this.invoiceNumberTextBox.TabIndex = 14;
            this.invoiceNumberTextBox.Text = "INV00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.label9.Location = new System.Drawing.Point(1056, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "BILL DATE";
            // 
            // salesAndPurchaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1469, 700);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.invoiceNumberTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerBillDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "salesAndPurchaseFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.salesAndPurchaseFrm_Load);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addedProductsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.TextBox searchCustomerTextBox;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label contactLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label searchLael;
        private System.Windows.Forms.DateTimePicker dateTimePickerBillDate;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.Label productDetailsLbl;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label searchPrdLbl;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox productNametextBox;
        private System.Windows.Forms.Button addProdButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView addedProductsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox vatTextBox;
        private System.Windows.Forms.TextBox gradTotalTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox invoiceNumberTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox dealerCustomerCombo;
        private System.Windows.Forms.Label label9;
    }
}