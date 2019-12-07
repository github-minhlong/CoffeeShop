namespace CoffeeShopManagement
{
    partial class frmSell
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cobSize = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(59, 175);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 22;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(80, 85);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(192, 20);
            this.txtPrice.TabIndex = 21;
            // 
            // cobSize
            // 
            this.cobSize.BackColor = System.Drawing.SystemColors.Window;
            this.cobSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobSize.Enabled = false;
            this.cobSize.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cobSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cobSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cobSize.Location = new System.Drawing.Point(80, 45);
            this.cobSize.Name = "cobSize";
            this.cobSize.Size = new System.Drawing.Size(192, 21);
            this.cobSize.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(80, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 19;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(12, 84);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 18);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Price";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(12, 48);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(37, 18);
            this.lblSize.TabIndex = 17;
            this.lblSize.Text = "Size";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(12, 129);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 18);
            this.lblQuantity.TabIndex = 24;
            this.lblQuantity.Text = "Quantity";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 25;
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 210);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cobSize);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblName);
            this.Name = "frmSell";
            this.Text = "frmSell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cobSize;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox textBox1;
    }
}