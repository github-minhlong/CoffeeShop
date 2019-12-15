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
    public partial class frmAllSales : Form
    {
        private ProductsManagement Business;       
        public frmAllSales()
        {
            InitializeComponent();
            this.Business = new ProductsManagement();
            this.Load += FrmAllSales_Load;            
            this.grdHistories.DoubleClick += grdHistories_DoubleClick;            
        }        
        void grdHistories_DoubleClick(object sender, EventArgs e)
        {
            var _history = (history)this.grdHistories.SelectedRows[0].DataBoundItem;
            new frmBillDetail().ShowDialog();
        }
        private void FrmAllSales_Load(object sender, EventArgs e)
        {
            LoadHitories();
        }
        void LoadHitories()
        {
            var load = this.Business.GetHistories();
            this.grdHistories.DataSource = load;
        }
    }
}
