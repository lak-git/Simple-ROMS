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
            this.SuspendLayout();
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.AccessibleDescription = "";
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 25;
            this.listBoxMenu.Location = new System.Drawing.Point(28, 12);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxMenu.Size = new System.Drawing.Size(317, 404);
            this.listBoxMenu.TabIndex = 0;
            // 
            // btnCalculateBill
            // 
            this.btnCalculateBill.Location = new System.Drawing.Point(28, 422);
            this.btnCalculateBill.Name = "btnCalculateBill";
            this.btnCalculateBill.Size = new System.Drawing.Size(203, 43);
            this.btnCalculateBill.TabIndex = 1;
            this.btnCalculateBill.Text = "Calculate Bill";
            this.btnCalculateBill.UseVisualStyleBackColor = true;
            this.btnCalculateBill.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Location = new System.Drawing.Point(32, 478);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(95, 25);
            this.lblTotalBill.TabIndex = 2;
            this.lblTotalBill.Text = "Total Bill";
            this.lblTotalBill.Click += new System.EventHandler(this.label1_Click);
            // 
            // RestaurantBillingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 541);
            this.Controls.Add(this.lblTotalBill);
            this.Controls.Add(this.btnCalculateBill);
            this.Controls.Add(this.listBoxMenu);
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
    }
}