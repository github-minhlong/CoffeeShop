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
            this.grdOrder.DoubleClick += GrdBill_DoubleClick;
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
            this.Business.AddHistory(TotalOrder());
            OrderToBill();
            if (int.Parse(txtTotal.Text) > 0)
            {
                for (int i = 0; i < grdOrder.Rows.Count; i++)
                {
                    var orders = (order)this.grdOrder.Rows[i].DataBoundItem;
                    this.Business.DeleteProductsOrder(orders.id);
                }
                this.LoadOrder();
            }
            else
            {
                MessageBox.Show("Can't pay!");
            }            
        }

        private void GrdBill_DoubleClick(object sender, EventArgs e)
        {
            if(this.grdOrder.SelectedRows.Count == 1)
            {
                var orders = (order)this.grdOrder.SelectedRows[0].DataBoundItem;
                this.Business.DeleteProductsOrder(orders.id);
                this.LoadOrder();
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
            int total = TotalOrder();
            txtTotal.Text = total.ToString();
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            var sell = (Product)this.grdProducts.SelectedRows[0].DataBoundItem;            
            var form = new frmSell(sell.id);
            form.ShowDialog();
            this.LoadOrder();
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
            this.LoadOrder();
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
        void LoadOrder()
        {
            var load = this.Business.GetOrders();
            this.grdOrder.DataSource = load;
        }
        int TotalOrder()
        {
            int Total = 0;
            for(int i = 0; i<grdOrder.Rows.Count; i++)
            {
                int n = int.Parse(grdOrder.Rows[i].Cells["price"].Value.ToString());
                Total += n;
            }
            return Total;
        }        
        void OrderToBill()
        {
            for (int i = 0; i < grdOrder.Rows.Count; i++)
            {                
                var name = this.grdOrder.Rows[i].Cells["name"].Value.ToString();
                var size = this.grdOrder.Rows[i].Cells["size"].Value.ToString();
                var price = int.Parse(this.grdOrder.Rows[i].Cells["price"].Value.ToString());
                var quantity = int.Parse(this.grdOrder.Rows[i].Cells["quantity"].Value.ToString());
                this.Business.AddBills(name, size, price, quantity);
            }
        }
    }
}
