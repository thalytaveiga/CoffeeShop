namespace CoffeeShopGUI
{
    partial class FormAddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrder));
            this.labelMenu = new System.Windows.Forms.Label();
            this.lbxMenuItem = new System.Windows.Forms.ListBox();
            this.lbxOrder = new System.Windows.Forms.ListBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnOkOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.lbxMenuAddition = new System.Windows.Forms.ListBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTtotalCost = new System.Windows.Forms.Label();
            this.lblCustomerOrder = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerOrderId = new System.Windows.Forms.Label();
            this.btnAddItemToOrder = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.ckbDelivered = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(84, 9);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(101, 47);
            this.labelMenu.TabIndex = 2;
            this.labelMenu.Text = "Menu";
            // 
            // lbxMenuItem
            // 
            this.lbxMenuItem.FormattingEnabled = true;
            this.lbxMenuItem.Location = new System.Drawing.Point(54, 126);
            this.lbxMenuItem.Name = "lbxMenuItem";
            this.lbxMenuItem.Size = new System.Drawing.Size(251, 121);
            this.lbxMenuItem.TabIndex = 0;
            // 
            // lbxOrder
            // 
            this.lbxOrder.FormattingEnabled = true;
            this.lbxOrder.HorizontalScrollbar = true;
            this.lbxOrder.Location = new System.Drawing.Point(466, 126);
            this.lbxOrder.Name = "lbxOrder";
            this.lbxOrder.Size = new System.Drawing.Size(346, 264);
            this.lbxOrder.TabIndex = 3;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(327, 244);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(111, 23);
            this.btnRemoveItem.TabIndex = 4;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnOkOrder
            // 
            this.btnOkOrder.Location = new System.Drawing.Point(284, 522);
            this.btnOkOrder.Name = "btnOkOrder";
            this.btnOkOrder.Size = new System.Drawing.Size(92, 57);
            this.btnOkOrder.TabIndex = 5;
            this.btnOkOrder.Text = "Ok";
            this.btnOkOrder.UseVisualStyleBackColor = true;
            this.btnOkOrder.Click += new System.EventHandler(this.btnOkOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(402, 522);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(92, 57);
            this.btnCancelOrder.TabIndex = 6;
            this.btnCancelOrder.Text = "Cancel";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // lbxMenuAddition
            // 
            this.lbxMenuAddition.FormattingEnabled = true;
            this.lbxMenuAddition.Location = new System.Drawing.Point(54, 282);
            this.lbxMenuAddition.Name = "lbxMenuAddition";
            this.lbxMenuAddition.Size = new System.Drawing.Size(251, 108);
            this.lbxMenuAddition.TabIndex = 7;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(463, 403);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(67, 13);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Total Cost: $";
            // 
            // lblTtotalCost
            // 
            this.lblTtotalCost.AutoSize = true;
            this.lblTtotalCost.Location = new System.Drawing.Point(533, 403);
            this.lblTtotalCost.Name = "lblTtotalCost";
            this.lblTtotalCost.Size = new System.Drawing.Size(31, 13);
            this.lblTtotalCost.TabIndex = 9;
            this.lblTtotalCost.Text = "        ";
            // 
            // lblCustomerOrder
            // 
            this.lblCustomerOrder.AutoSize = true;
            this.lblCustomerOrder.Location = new System.Drawing.Point(92, 73);
            this.lblCustomerOrder.Name = "lblCustomerOrder";
            this.lblCustomerOrder.Size = new System.Drawing.Size(57, 13);
            this.lblCustomerOrder.TabIndex = 10;
            this.lblCustomerOrder.Text = "Customer: ";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(98, 96);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(51, 13);
            this.lblOrderId.TabIndex = 11;
            this.lblOrderId.Text = "Order Id: ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(146, 73);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(25, 13);
            this.lblCustomerName.TabIndex = 12;
            this.lblCustomerName.Text = "      ";
            // 
            // lblCustomerOrderId
            // 
            this.lblCustomerOrderId.AutoSize = true;
            this.lblCustomerOrderId.Location = new System.Drawing.Point(146, 96);
            this.lblCustomerOrderId.Name = "lblCustomerOrderId";
            this.lblCustomerOrderId.Size = new System.Drawing.Size(34, 13);
            this.lblCustomerOrderId.TabIndex = 13;
            this.lblCustomerOrderId.Text = "         ";
            // 
            // btnAddItemToOrder
            // 
            this.btnAddItemToOrder.Location = new System.Drawing.Point(327, 160);
            this.btnAddItemToOrder.Name = "btnAddItemToOrder";
            this.btnAddItemToOrder.Size = new System.Drawing.Size(111, 23);
            this.btnAddItemToOrder.TabIndex = 14;
            this.btnAddItemToOrder.Text = "Add Item";
            this.btnAddItemToOrder.UseVisualStyleBackColor = true;
            this.btnAddItemToOrder.Click += new System.EventHandler(this.btnAddItemToOrder_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(327, 334);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(111, 23);
            this.btnAddition.TabIndex = 15;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // ckbDelivered
            // 
            this.ckbDelivered.AutoSize = true;
            this.ckbDelivered.Location = new System.Drawing.Point(54, 403);
            this.ckbDelivered.Name = "ckbDelivered";
            this.ckbDelivered.Size = new System.Drawing.Size(71, 17);
            this.ckbDelivered.TabIndex = 17;
            this.ckbDelivered.Text = "Delivered";
            this.ckbDelivered.UseVisualStyleBackColor = true;
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(869, 608);
            this.Controls.Add(this.ckbDelivered);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnAddItemToOrder);
            this.Controls.Add(this.lblCustomerOrderId);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblCustomerOrder);
            this.Controls.Add(this.lblTtotalCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lbxMenuAddition);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnOkOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lbxOrder);
            this.Controls.Add(this.lbxMenuItem);
            this.Controls.Add(this.labelMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormAddOrder";
            this.Text = "AddOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.ListBox lbxMenuItem;
        private System.Windows.Forms.ListBox lbxOrder;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnOkOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.ListBox lbxMenuAddition;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblTtotalCost;
        private System.Windows.Forms.Label lblCustomerOrder;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerOrderId;
        private System.Windows.Forms.Button btnAddItemToOrder;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.CheckBox ckbDelivered;
    }
}