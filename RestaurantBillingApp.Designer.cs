namespace Simple_ROMS
{
    partial class RestaurantBillingApp
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
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.btnCalculateBill = new System.Windows.Forms.Button();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.OrderSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.AccessibleDescription = "";
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(14, 6);
            this.listBoxMenu.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxMenu.Size = new System.Drawing.Size(160, 212);
            this.listBoxMenu.TabIndex = 0;
            // 
            // btnCalculateBill
            // 
            this.btnCalculateBill.Location = new System.Drawing.Point(14, 219);
            this.btnCalculateBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateBill.Name = "btnCalculateBill";
            this.btnCalculateBill.Size = new System.Drawing.Size(102, 22);
            this.btnCalculateBill.TabIndex = 1;
            this.btnCalculateBill.Text = "Calculate Bill";
            this.btnCalculateBill.UseVisualStyleBackColor = true;
            this.btnCalculateBill.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Location = new System.Drawing.Point(16, 249);
            this.lblTotalBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(47, 13);
            this.lblTotalBill.TabIndex = 2;
            this.lblTotalBill.Text = "Total Bill";
            this.lblTotalBill.Click += new System.EventHandler(this.label1_Click);
            // 
            // OrderSummary
            // 
            this.OrderSummary.AutoSize = true;
            this.OrderSummary.Location = new System.Drawing.Point(287, 25);
            this.OrderSummary.Name = "OrderSummary";
            this.OrderSummary.Size = new System.Drawing.Size(0, 13);
            this.OrderSummary.TabIndex = 3;
            // 
            // RestaurantBillingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 281);
            this.Controls.Add(this.OrderSummary);
            this.Controls.Add(this.lblTotalBill);
            this.Controls.Add(this.btnCalculateBill);
            this.Controls.Add(this.listBoxMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RestaurantBillingApp";
            this.Text = "RestaurantBillingApp";
            this.Load += new System.EventHandler(this.RestaurantBillingApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Button btnCalculateBill;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Label OrderSummary;
    }
}