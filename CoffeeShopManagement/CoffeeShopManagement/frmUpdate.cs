using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class frmUpdate : Form
    {
        private ProductsManagement Business;
        private int ProductId;
        public frmUpdate(int id)
        {
            InitializeComponent();
            this.ProductId = id;
            this.Business = new ProductsManagement();
            this.btnCancel.Click += BtnCancel_Click;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.Load += FrmUpdate_Load;
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            var @products = this.Business.GetProduct(this.ProductId);
            this.txtName.Text = products.Name;
            this.txtPrice.Text = products.Price.ToString();
            this.cobSize.Text = products.Size;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var size = this.cobSize.Text;
            var price = int.Parse(this.txtPrice.Text);
            this.Business.EditProduct(ProductId, name, size, price);
            MessageBox.Show("Update successfully");
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
