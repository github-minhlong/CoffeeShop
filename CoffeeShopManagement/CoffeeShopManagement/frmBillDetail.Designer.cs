namespace CoffeeShopManagement
{
    partial class frmBillDetail
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
            this.grbBill = new System.Windows.Forms.GroupBox();
            this.grdBill = new System.Windows.Forms.DataGridView();
            this.grbBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBill
            // 
            this.grbBill.Controls.Add(this.grdBill);
            this.grbBill.Location = new System.Drawing.Point(12, 12);
            this.grbBill.Name = "grbBill";
            this.grbBill.Size = new System.Drawing.Size(644, 414);
            this.grbBill.TabIndex = 5;
            this.grbBill.TabStop = false;
            this.grbBill.Text = "Bill";
            // 
            // grdBill
            // 
            this.grdBill.AllowUserToAddRows = false;
            this.grdBill.AllowUserToDeleteRows = false;
            this.grdBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBill.Location = new System.Drawing.Point(3, 16);
            this.grdBill.Name = "grdBill";
            this.grdBill.ReadOnly = true;
            this.grdBill.Size = new System.Drawing.Size(638, 395);
            this.grdBill.TabIndex = 0;
            // 
            // frmBillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.grbBill);
            this.Name = "frmBillDetail";
            this.Text = "frmBillDetail";
            this.grbBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBill;
        public System.Windows.Forms.DataGridView grdBill;
    }
}