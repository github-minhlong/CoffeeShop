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
    public partial class frmAddProduct : Form
    {
        private ProductsManagement Business;
        public frmAddProduct()
        {
            InitializeComponent();
            this.Business = new ProductsManagement();
            this.btnCancel.Click += BtnCancel_Click;
            this.btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var size = this.cobSize.Text;
            var price = int.Parse(this.txtPrice.Text);
            this.Business.AddProduct(name, size, price);
            MessageBox.Show("Add successfully");
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
