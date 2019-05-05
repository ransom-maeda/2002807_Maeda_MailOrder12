namespace _2002807_Maeda_MailOrder12
{
    partial class Form1
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addThisItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZIP = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.stateInput = new System.Windows.Forms.MaskedTextBox();
            this.zipInput = new System.Windows.Forms.MaskedTextBox();
            this.boxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.orderInfo = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.fontChange = new System.Windows.Forms.FontDialog();
            this.colorChange = new System.Windows.Forms.ColorDialog();
            this.boxSummary = new System.Windows.Forms.GroupBox();
            this.totalAmountOutput = new System.Windows.Forms.TextBox();
            this.handlingOutput = new System.Windows.Forms.TextBox();
            this.salesTaxOutput = new System.Windows.Forms.TextBox();
            this.amountDueOutput = new System.Windows.Forms.TextBox();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelHandling = new System.Windows.Forms.Label();
            this.labelSalesTax = new System.Windows.Forms.Label();
            this.labelDollarAmount = new System.Windows.Forms.Label();
            this.Customers = new System.Windows.Forms.ListBox();
            this.menu.SuspendLayout();
            this.boxCustomerInfo.SuspendLayout();
            this.orderInfo.SuspendLayout();
            this.boxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(548, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSummaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // updateSummaryToolStripMenuItem
            // 
            this.updateSummaryToolStripMenuItem.Name = "updateSummaryToolStripMenuItem";
            this.updateSummaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateSummaryToolStripMenuItem.Text = "Update &Summary";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addThisItemToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addThisItemToolStripMenuItem
            // 
            this.addThisItemToolStripMenuItem.Name = "addThisItemToolStripMenuItem";
            this.addThisItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addThisItemToolStripMenuItem.Text = "&Add This Item";
            this.addThisItemToolStripMenuItem.Click += new System.EventHandler(this.addThisItemToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "C&olor";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(6, 60);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(6, 94);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "City";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(6, 128);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 4;
            this.labelState.Text = "State";
            // 
            // labelZIP
            // 
            this.labelZIP.AutoSize = true;
            this.labelZIP.Location = new System.Drawing.Point(6, 162);
            this.labelZIP.Name = "labelZIP";
            this.labelZIP.Size = new System.Drawing.Size(52, 13);
            this.labelZIP.TabIndex = 5;
            this.labelZIP.Text = "ZIP Code";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(92, 23);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 6;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(92, 57);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(100, 20);
            this.addressInput.TabIndex = 7;
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(92, 91);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(100, 20);
            this.cityInput.TabIndex = 8;
            // 
            // stateInput
            // 
            this.stateInput.Location = new System.Drawing.Point(92, 125);
            this.stateInput.Mask = "aa";
            this.stateInput.Name = "stateInput";
            this.stateInput.Size = new System.Drawing.Size(100, 20);
            this.stateInput.TabIndex = 9;
            // 
            // zipInput
            // 
            this.zipInput.Location = new System.Drawing.Point(92, 159);
            this.zipInput.Mask = "00000";
            this.zipInput.Name = "zipInput";
            this.zipInput.Size = new System.Drawing.Size(100, 20);
            this.zipInput.TabIndex = 10;
            // 
            // boxCustomerInfo
            // 
            this.boxCustomerInfo.Controls.Add(this.labelName);
            this.boxCustomerInfo.Controls.Add(this.zipInput);
            this.boxCustomerInfo.Controls.Add(this.labelAddress);
            this.boxCustomerInfo.Controls.Add(this.stateInput);
            this.boxCustomerInfo.Controls.Add(this.labelCity);
            this.boxCustomerInfo.Controls.Add(this.cityInput);
            this.boxCustomerInfo.Controls.Add(this.labelState);
            this.boxCustomerInfo.Controls.Add(this.addressInput);
            this.boxCustomerInfo.Controls.Add(this.labelZIP);
            this.boxCustomerInfo.Controls.Add(this.nameInput);
            this.boxCustomerInfo.Location = new System.Drawing.Point(12, 37);
            this.boxCustomerInfo.Name = "boxCustomerInfo";
            this.boxCustomerInfo.Size = new System.Drawing.Size(206, 190);
            this.boxCustomerInfo.TabIndex = 11;
            this.boxCustomerInfo.TabStop = false;
            this.boxCustomerInfo.Text = "Customer Information";
            // 
            // orderInfo
            // 
            this.orderInfo.Controls.Add(this.labelPrice);
            this.orderInfo.Controls.Add(this.priceInput);
            this.orderInfo.Controls.Add(this.labelDescription);
            this.orderInfo.Controls.Add(this.labelQuantity);
            this.orderInfo.Controls.Add(this.labelWeight);
            this.orderInfo.Controls.Add(this.weightInput);
            this.orderInfo.Controls.Add(this.quantityInput);
            this.orderInfo.Controls.Add(this.descriptionInput);
            this.orderInfo.Location = new System.Drawing.Point(225, 37);
            this.orderInfo.Name = "orderInfo";
            this.orderInfo.Size = new System.Drawing.Size(245, 159);
            this.orderInfo.TabIndex = 12;
            this.orderInfo.TabStop = false;
            this.orderInfo.Text = "Order Information";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(6, 128);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "Price";
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(132, 125);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(100, 20);
            this.priceInput.TabIndex = 16;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(6, 26);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 13);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Product Description";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(6, 60);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 10;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(6, 94);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(41, 13);
            this.labelWeight.TabIndex = 11;
            this.labelWeight.Text = "Weight";
            // 
            // weightInput
            // 
            this.weightInput.Location = new System.Drawing.Point(132, 91);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(100, 20);
            this.weightInput.TabIndex = 14;
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(132, 57);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(100, 20);
            this.quantityInput.TabIndex = 13;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(132, 23);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(100, 20);
            this.descriptionInput.TabIndex = 12;
            // 
            // boxSummary
            // 
            this.boxSummary.Controls.Add(this.totalAmountOutput);
            this.boxSummary.Controls.Add(this.handlingOutput);
            this.boxSummary.Controls.Add(this.salesTaxOutput);
            this.boxSummary.Controls.Add(this.amountDueOutput);
            this.boxSummary.Controls.Add(this.labelTotalAmount);
            this.boxSummary.Controls.Add(this.labelHandling);
            this.boxSummary.Controls.Add(this.labelSalesTax);
            this.boxSummary.Controls.Add(this.labelDollarAmount);
            this.boxSummary.Location = new System.Drawing.Point(12, 233);
            this.boxSummary.Name = "boxSummary";
            this.boxSummary.Size = new System.Drawing.Size(224, 179);
            this.boxSummary.TabIndex = 13;
            this.boxSummary.TabStop = false;
            this.boxSummary.Text = "Summary";
            // 
            // totalAmountOutput
            // 
            this.totalAmountOutput.Location = new System.Drawing.Point(118, 149);
            this.totalAmountOutput.Name = "totalAmountOutput";
            this.totalAmountOutput.Size = new System.Drawing.Size(100, 20);
            this.totalAmountOutput.TabIndex = 7;
            // 
            // handlingOutput
            // 
            this.handlingOutput.Location = new System.Drawing.Point(118, 108);
            this.handlingOutput.Name = "handlingOutput";
            this.handlingOutput.Size = new System.Drawing.Size(100, 20);
            this.handlingOutput.TabIndex = 6;
            // 
            // salesTaxOutput
            // 
            this.salesTaxOutput.Location = new System.Drawing.Point(118, 67);
            this.salesTaxOutput.Name = "salesTaxOutput";
            this.salesTaxOutput.Size = new System.Drawing.Size(100, 20);
            this.salesTaxOutput.TabIndex = 5;
            // 
            // amountDueOutput
            // 
            this.amountDueOutput.Location = new System.Drawing.Point(118, 26);
            this.amountDueOutput.Name = "amountDueOutput";
            this.amountDueOutput.Size = new System.Drawing.Size(100, 20);
            this.amountDueOutput.TabIndex = 4;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(6, 152);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(93, 13);
            this.labelTotalAmount.TabIndex = 3;
            this.labelTotalAmount.Text = "Total Amount Due";
            // 
            // labelHandling
            // 
            this.labelHandling.AutoSize = true;
            this.labelHandling.Location = new System.Drawing.Point(6, 111);
            this.labelHandling.Name = "labelHandling";
            this.labelHandling.Size = new System.Drawing.Size(49, 13);
            this.labelHandling.TabIndex = 2;
            this.labelHandling.Text = "Handling";
            // 
            // labelSalesTax
            // 
            this.labelSalesTax.AutoSize = true;
            this.labelSalesTax.Location = new System.Drawing.Point(6, 70);
            this.labelSalesTax.Name = "labelSalesTax";
            this.labelSalesTax.Size = new System.Drawing.Size(54, 13);
            this.labelSalesTax.TabIndex = 1;
            this.labelSalesTax.Text = "Sales Tax";
            // 
            // labelDollarAmount
            // 
            this.labelDollarAmount.AutoSize = true;
            this.labelDollarAmount.Location = new System.Drawing.Point(6, 29);
            this.labelDollarAmount.Name = "labelDollarAmount";
            this.labelDollarAmount.Size = new System.Drawing.Size(96, 13);
            this.labelDollarAmount.TabIndex = 0;
            this.labelDollarAmount.Text = "Dollar Amount Due";
            // 
            // Customers
            // 
            this.Customers.FormattingEnabled = true;
            this.Customers.Location = new System.Drawing.Point(242, 202);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(138, 212);
            this.Customers.TabIndex = 14;
            this.Customers.SelectedIndexChanged += new System.EventHandler(this.Orders_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 473);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.boxSummary);
            this.Controls.Add(this.orderInfo);
            this.Controls.Add(this.boxCustomerInfo);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = " Mail Order 12";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.boxCustomerInfo.ResumeLayout(false);
            this.boxCustomerInfo.PerformLayout();
            this.orderInfo.ResumeLayout(false);
            this.orderInfo.PerformLayout();
            this.boxSummary.ResumeLayout(false);
            this.boxSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addThisItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZIP;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.MaskedTextBox stateInput;
        private System.Windows.Forms.MaskedTextBox zipInput;
        private System.Windows.Forms.GroupBox boxCustomerInfo;
        private System.Windows.Forms.GroupBox orderInfo;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.FontDialog fontChange;
        private System.Windows.Forms.ColorDialog colorChange;
        private System.Windows.Forms.GroupBox boxSummary;
        private System.Windows.Forms.TextBox totalAmountOutput;
        private System.Windows.Forms.TextBox handlingOutput;
        private System.Windows.Forms.TextBox salesTaxOutput;
        private System.Windows.Forms.TextBox amountDueOutput;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelHandling;
        private System.Windows.Forms.Label labelSalesTax;
        private System.Windows.Forms.Label labelDollarAmount;
        private System.Windows.Forms.ListBox Customers;
    }
}

