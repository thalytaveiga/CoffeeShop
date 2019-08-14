namespace CoffeeShopGUI
{
    partial class FormCustomerOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomerOrders));
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtOrders = new System.Windows.Forms.TextBox();
            this.lblCustomerOrders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.Location = new System.Drawing.Point(61, 105);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(190, 316);
            this.lbxCustomers.TabIndex = 0;
            this.lbxCustomers.SelectedIndexChanged += new System.EventHandler(this.lbxCustomers_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(283, 453);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 67);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtOrders
            // 
            this.txtOrders.BackColor = System.Drawing.Color.White;
            this.txtOrders.Location = new System.Drawing.Point(257, 105);
            this.txtOrders.Multiline = true;
            this.txtOrders.Name = "txtOrders";
            this.txtOrders.ReadOnly = true;
            this.txtOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrders.Size = new System.Drawing.Size(346, 316);
            this.txtOrders.TabIndex = 3;
            this.txtOrders.TabStop = false;
            // 
            // lblCustomerOrders
            // 
            this.lblCustomerOrders.AutoSize = true;
            this.lblCustomerOrders.Location = new System.Drawing.Point(117, 54);
            this.lblCustomerOrders.Name = "lblCustomerOrders";
            this.lblCustomerOrders.Size = new System.Drawing.Size(49, 13);
            this.lblCustomerOrders.TabIndex = 4;
            this.lblCustomerOrders.Text = "              ";
            // 
            // FormCustomerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(658, 532);
            this.Controls.Add(this.lblCustomerOrders);
            this.Controls.Add(this.txtOrders);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbxCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormCustomerOrders";
            this.Text = "CustomersOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCustomers;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtOrders;
        private System.Windows.Forms.Label lblCustomerOrders;
    }
}