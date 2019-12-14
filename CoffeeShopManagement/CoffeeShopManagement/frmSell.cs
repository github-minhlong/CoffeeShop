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
    public partial class frmSell : Form
    {
        private ProductsManagement Business;
        private int Id;
        public frmSell(int id)
        {           
            InitializeComponent();
            this.Business = new ProductsManagement();
            this.Id = id;
            this.Load += FrmSell_Load;
            this.btnCancel.Click += BtnCancel_Click;
            this.btnSell.Click += BtnSell_Click;
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var size = this.txtSize.Text;
            var price = TotalPrice();
            var quantity = int.Parse(this.txtQuantity.Text);
            this.Business.AddOrder(name, size, price, quantity);           
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSell_Load(object sender, EventArgs e)
        {
            var sell = this.Business.GetProduct(Id);
            this.txtName.Text = sell.Name;
            this.txtPrice.Text = sell.Price.ToString();
            this.txtSize.Text = sell.Size;
        }
        int TotalPrice()
        {
            int TotalPrice = int.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            if (quantity > 1)
            {
                TotalPrice = quantity * int.Parse(this.txtPrice.Text);
            }
            return TotalPrice;
        }
    }
}
