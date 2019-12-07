namespace CoffeeShopManagement
{
    partial class frmDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewAllSales = new System.Windows.Forms.ToolStripMenuItem();
            this.grbProducts = new System.Windows.Forms.GroupBox();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.grbBill = new System.Windows.Forms.GroupBox();
            this.grdBill = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSell = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.grbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.grbBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddProduct,
            this.btnUpdateProduct,
            this.btnViewAllSales,
            this.btnSell});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(86, 20);
            this.btnAddProduct.Text = "Add product";
            // 
            // btnViewAllSales
            // 
            this.btnViewAllSales.Name = "btnViewAllSales";
            this.btnViewAllSales.Size = new System.Drawing.Size(90, 20);
            this.btnViewAllSales.Text = "View All Sales";
            // 
            // grbProducts
            // 
            this.grbProducts.Controls.Add(this.grdProducts);
            this.grbProducts.Location = new System.Drawing.Point(12, 27);
            this.grbProducts.Name = "grbProducts";
            this.grbProducts.Size = new System.Drawing.Size(248, 278);
            this.grbProducts.TabIndex = 1;
            this.grbProducts.TabStop = false;
            this.grbProducts.Text = "Products";
            // 
            // grdProducts
            // 
            this.grdProducts.AllowUserToAddRows = false;
            this.grdProducts.AllowUserToDeleteRows = false;
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProducts.Location = new System.Drawing.Point(3, 16);
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.ReadOnly = true;
            this.grdProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProducts.Size = new System.Drawing.Size(242, 259);
            this.grdProducts.TabIndex = 0;
            // 
            // grbBill
            // 
            this.grbBill.Controls.Add(this.grdBill);
            this.grbBill.Location = new System.Drawing.Point(311, 43);
            this.grbBill.Name = "grbBill";
            this.grbBill.Size = new System.Drawing.Size(296, 230);
            this.grbBill.TabIndex = 2;
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
            this.grdBill.Size = new System.Drawing.Size(290, 211);
            this.grdBill.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(310, 280);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 24);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(390, 284);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(115, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(529, 282);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(102, 20);
            this.btnUpdateProduct.Text = "Update Product";
            // 
            // btnSell
            // 
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(37, 20);
            this.btnSell.Text = "Sell";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 317);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grbBill);
            this.Controls.Add(this.grbProducts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.grbBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddProduct;
        private System.Windows.Forms.ToolStripMenuItem btnViewAllSales;
        private System.Windows.Forms.GroupBox grbProducts;
        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.GroupBox grbBill;
        private System.Windows.Forms.DataGridView grdBill;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ToolStripMenuItem btnUpdateProduct;
        private System.Windows.Forms.ToolStripMenuItem btnSell;
    }
}