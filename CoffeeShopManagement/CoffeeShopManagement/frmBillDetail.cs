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
    public partial class frmBillDetail : Form
    {        
        private ProductsManagement Business;
        public frmBillDetail()
        {
            InitializeComponent();            
            this.Business = new ProductsManagement();
            this.Load += frmBillDetail_Load;
        }

        void frmBillDetail_Load(object sender, EventArgs e)
        {
            LoadBill();
        }
        void LoadBill()
        {
            var load = this.Business.GetBills();
            this.grdBill.DataSource = load;
        }
    }
}
