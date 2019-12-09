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
            this.btnClear.Click += BtnClear_Click;
            this.btnDelete.Click += BtnDelete_Click;            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(this.grdHistories.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var history = (history)this.grdHistories.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteHistory(history.id);
                    MessageBox.Show("Delete successfully");
                    this.LoadHitories();
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            for(int i =0; i < grdHistories.Rows.Count; i++)
            {
                var histories = (history)this.grdHistories.Rows[i].DataBoundItem;
                this.Business.DeleteHistory(histories.id);
            }
            LoadHitories();
        }

        private void FrmAllSales_Load(object sender, EventArgs e)
        {
            LoadHitories();
            this.txtNumber.Text = TotalHistory().ToString();
        }
        void LoadHitories()
        {
            var load = this.Business.GetHistories();
            this.grdHistories.DataSource = load;
        }
        int TotalHistory()
        {
            int Total = 0;
            for (int i = 0; i < grdHistories.Rows.Count; i++)
            {
                int n = int.Parse(grdHistories.Rows[i].Cells["price"].Value.ToString());
                Total += n;
            }
            return Total;
        }
    }
}
