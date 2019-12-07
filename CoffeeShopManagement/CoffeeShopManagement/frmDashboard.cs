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
    public partial class frmDashboard : Form
    {
        private ProductsManagement Business;
        public frmDashboard()
        {
            InitializeComponent();
            this.Business = new ProductsManagement();
            this.btnAddProduct.Click += BtnAddProduct_Click;
            this.Load += FrmDashboard_Load;
            this.btnUpdateProduct.Click += BtnUpdateProduct_Click;
            this.btnSell.Click += BtnSell_Click;           
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            var sell = (Product)this.grdProducts.SelectedRows[0].DataBoundItem;
            var form = new frmSell(sell.id);
            form.ShowDialog();
            this.LoadBill();
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            var @product = (Product)this.grdProducts.SelectedRows[0].DataBoundItem;
            var form = new frmUpdate(@product.id);
            form.ShowDialog();
            this.ViewAllProducts();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            this.ViewAllProducts();
            this.LoadBill();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            var form = new frmAddProduct();
            form.ShowDialog();
            this.ViewAllProducts();
        }
        void ViewAllProducts()
        {
            var load = this.Business.GetProducts();
            this.grdProducts.DataSource = load;
        }
        void LoadBill()
        {
            var load = this.Business.GetBills();
            this.grdBill.DataSource = load;
        }
    }
}
