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
            this.txtTotal.DoubleClick += TxtTotal_DoubleClick;
            this.btnDelete.Click += BtnDelete_Click;
            this.grdBill.DoubleClick += GrdBill_DoubleClick;
            this.btnCheckOut.Click += BtnCheckOut_Click;
            this.btnViewAllSales.Click += BtnViewAllSales_Click;
        }

        private void BtnViewAllSales_Click(object sender, EventArgs e)
        {
            var form = new frmAllSales();
            form.Show();
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            for(int n = 0; n < grdBill.Rows.Count; n++)
            {
                var name = this.grdBill.Rows[n].Cells["name"].Value.ToString();
                var size = this.grdBill.Rows[n].Cells["size"].Value.ToString();
                var price = int.Parse(this.grdBill.Rows[n].Cells["price"].Value.ToString());
                var quantity = int.Parse(this.grdBill.Rows[n].Cells["quantity"].Value.ToString());
                this.Business.AddHistory(name, size, price, quantity);
            }
            if (int.Parse(txtTotal.Text) > 0)
            {
                for (int i = 0; i < grdBill.Rows.Count; i++)
                {
                    var orders = (order)this.grdBill.Rows[i].DataBoundItem;
                    this.Business.DeleteProductsInBill(orders.id);
                }
                this.LoadBill();
            }
            else
            {
                MessageBox.Show("Can't pay!");
            }
        }

        private void GrdBill_DoubleClick(object sender, EventArgs e)
        {
            if(this.grdBill.SelectedRows.Count == 1)
            {
                var orders = (order)this.grdBill.SelectedRows[0].DataBoundItem;
                this.Business.DeleteProductsInBill(orders.id);
                this.LoadBill();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(this.grdProducts.SelectedRows.Count == 1)
            {
                if(MessageBox.Show("Do you want to delete this?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var products = (Product)this.grdProducts.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteProduct(products.id);
                    MessageBox.Show("Delete successfully");
                    this.ViewAllProducts();
                }
            }
        }

        private void TxtTotal_DoubleClick(object sender, EventArgs e)
        {
            int total = TotalBill();
            txtTotal.Text = total.ToString();
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
        int TotalBill()
        {
            int Total = 0;
            for(int i = 0; i<grdBill.Rows.Count; i++)
            {
                int n = int.Parse(grdBill.Rows[i].Cells["price"].Value.ToString());
                Total += n;
            }
            return Total;
        }
    }
}
