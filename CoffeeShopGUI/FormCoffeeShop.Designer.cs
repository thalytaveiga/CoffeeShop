namespace CoffeeShopGUI
{
    partial class FormCoffeeShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCoffeeShop));
            this.btnNewCust = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.gbxCustomers = new System.Windows.Forms.GroupBox();
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.labelCoffeeShop = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxLastOrder = new System.Windows.Forms.ListBox();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnEditCust = new System.Windows.Forms.Button();
            this.lblTotalOrder = new System.Windows.Forms.Label();
            this.lblTotalOrderValue = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnNotDeliveredOrders = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lblOrderBtwDates = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.btnListOrdersBtwDates = new System.Windows.Forms.Button();
            this.gbxCustomers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewCust
            // 
            this.btnNewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCust.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewCust.Location = new System.Drawing.Point(356, 178);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(88, 37);
            this.btnNewCust.TabIndex = 0;
            this.btnNewCust.Text = "Add New Customer";
            this.btnNewCust.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewCust.UseVisualStyleBackColor = true;
            this.btnNewCust.Click += new System.EventHandler(this.btnNewCust_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrder.Image")));
            this.btnAddOrder.Location = new System.Drawing.Point(291, 484);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(88, 71);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // gbxCustomers
            // 
            this.gbxCustomers.Controls.Add(this.lbxCustomers);
            this.gbxCustomers.Location = new System.Drawing.Point(23, 147);
            this.gbxCustomers.Name = "gbxCustomers";
            this.gbxCustomers.Size = new System.Drawing.Size(278, 263);
            this.gbxCustomers.TabIndex = 2;
            this.gbxCustomers.TabStop = false;
            this.gbxCustomers.Text = "Customers";
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.Location = new System.Drawing.Point(7, 19);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(265, 238);
            this.lbxCustomers.TabIndex = 0;
            // 
            // labelCoffeeShop
            // 
            this.labelCoffeeShop.AutoSize = true;
            this.labelCoffeeShop.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoffeeShop.Location = new System.Drawing.Point(78, 13);
            this.labelCoffeeShop.Name = "labelCoffeeShop";
            this.labelCoffeeShop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCoffeeShop.Size = new System.Drawing.Size(185, 47);
            this.labelCoffeeShop.TabIndex = 3;
            this.labelCoffeeShop.Text = "Coffee Shop";
            this.labelCoffeeShop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxLastOrder);
            this.groupBox1.Location = new System.Drawing.Point(494, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 263);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Order";
            // 
            // lbxLastOrder
            // 
            this.lbxLastOrder.FormattingEnabled = true;
            this.lbxLastOrder.Location = new System.Drawing.Point(6, 19);
            this.lbxLastOrder.Name = "lbxLastOrder";
            this.lbxLastOrder.Size = new System.Drawing.Size(299, 238);
            this.lbxLastOrder.TabIndex = 0;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveAll.BackgroundImage")));
            this.btnSaveAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAll.Location = new System.Drawing.Point(443, 484);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(88, 71);
            this.btnSaveAll.TabIndex = 6;
            this.btnSaveAll.Text = "Save";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnEditCust
            // 
            this.btnEditCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCust.Location = new System.Drawing.Point(356, 245);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(88, 37);
            this.btnEditCust.TabIndex = 7;
            this.btnEditCust.Text = "Edit Customer";
            this.btnEditCust.UseVisualStyleBackColor = true;
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
            // 
            // lblTotalOrder
            // 
            this.lblTotalOrder.AutoSize = true;
            this.lblTotalOrder.Location = new System.Drawing.Point(497, 422);
            this.lblTotalOrder.Name = "lblTotalOrder";
            this.lblTotalOrder.Size = new System.Drawing.Size(75, 13);
            this.lblTotalOrder.TabIndex = 8;
            this.lblTotalOrder.Text = "Total Order: $ ";
            // 
            // lblTotalOrderValue
            // 
            this.lblTotalOrderValue.AutoSize = true;
            this.lblTotalOrderValue.Location = new System.Drawing.Point(568, 422);
            this.lblTotalOrderValue.Name = "lblTotalOrderValue";
            this.lblTotalOrderValue.Size = new System.Drawing.Size(37, 13);
            this.lblTotalOrderValue.TabIndex = 9;
            this.lblTotalOrderValue.Text = "          ";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(497, 447);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(57, 13);
            this.lblCustomer.TabIndex = 10;
            this.lblCustomer.Text = "Customer: ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(549, 447);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(34, 13);
            this.lblCustomerName.TabIndex = 11;
            this.lblCustomerName.Text = "         ";
            // 
            // btnNotDeliveredOrders
            // 
            this.btnNotDeliveredOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotDeliveredOrders.Location = new System.Drawing.Point(1028, 164);
            this.btnNotDeliveredOrders.Name = "btnNotDeliveredOrders";
            this.btnNotDeliveredOrders.Size = new System.Drawing.Size(169, 81);
            this.btnNotDeliveredOrders.TabIndex = 12;
            this.btnNotDeliveredOrders.Text = "List not delivered orders";
            this.btnNotDeliveredOrders.UseVisualStyleBackColor = true;
            this.btnNotDeliveredOrders.Click += new System.EventHandler(this.btnNotDeliveredOrders_Click);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(1012, 394);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 13;
            // 
            // lblOrderBtwDates
            // 
            this.lblOrderBtwDates.AutoSize = true;
            this.lblOrderBtwDates.Location = new System.Drawing.Point(1039, 361);
            this.lblOrderBtwDates.Name = "lblOrderBtwDates";
            this.lblOrderBtwDates.Size = new System.Drawing.Size(131, 13);
            this.lblOrderBtwDates.TabIndex = 14;
            this.lblOrderBtwDates.Text = "See orders between dates";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(976, 401);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(30, 13);
            this.lblDateFrom.TabIndex = 15;
            this.lblDateFrom.Text = "From";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(986, 444);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(20, 13);
            this.lblDateTo.TabIndex = 16;
            this.lblDateTo.Text = "To";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(1012, 437);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 17;
            // 
            // btnListOrdersBtwDates
            // 
            this.btnListOrdersBtwDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListOrdersBtwDates.Location = new System.Drawing.Point(1028, 484);
            this.btnListOrdersBtwDates.Name = "btnListOrdersBtwDates";
            this.btnListOrdersBtwDates.Size = new System.Drawing.Size(169, 81);
            this.btnListOrdersBtwDates.TabIndex = 18;
            this.btnListOrdersBtwDates.Text = "List";
            this.btnListOrdersBtwDates.UseVisualStyleBackColor = true;
            this.btnListOrdersBtwDates.Click += new System.EventHandler(this.btnListOrdersBtwDates_Click);
            // 
            // FormCoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.btnListOrdersBtwDates);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.lblOrderBtwDates);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.btnNotDeliveredOrders);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblTotalOrderValue);
            this.Controls.Add(this.lblTotalOrder);
            this.Controls.Add(this.btnEditCust);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCoffeeShop);
            this.Controls.Add(this.gbxCustomers);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnNewCust);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormCoffeeShop";
            this.Text = "CoffeeShop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxCustomers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCust;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.GroupBox gbxCustomers;
        private System.Windows.Forms.ListBox lbxCustomers;
        private System.Windows.Forms.Label labelCoffeeShop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxLastOrder;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnEditCust;
        private System.Windows.Forms.Label lblTotalOrder;
        private System.Windows.Forms.Label lblTotalOrderValue;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnNotDeliveredOrders;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lblOrderBtwDates;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button btnListOrdersBtwDates;
    }
}