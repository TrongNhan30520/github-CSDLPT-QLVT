using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmVatTu : DevExpress.XtraEditors.XtraForm
    {
        public frmVatTu()
        {
            InitializeComponent();
            
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDSVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
        private void HienThi()
        {
            txtMaVT.DataBindings.Clear();
            txtMaVT.DataBindings.Add("text", GCVatTu.DataSource, "MAVT");
            txtDVT.DataBindings.Clear();
            txtDVT.DataBindings.Add("text", GCVatTu.DataSource, "DVT");
            txtTenVT.DataBindings.Clear();
            txtTenVT.DataBindings.Add("text", GCVatTu.DataSource, "TENVT");
            numSLT.DataBindings.Clear();
            numSLT.DataBindings.Add("text", GCVatTu.DataSource, "SOLUONGTON");
        }

        
        private void frmVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            HienThi();
            TTVatTu.Enabled = false;

        }
    }
}