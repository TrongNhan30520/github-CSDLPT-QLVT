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
    public partial class frmLapPhieu : DevExpress.XtraEditors.XtraForm
    {
        public frmLapPhieu()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDSDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmLapPhieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
            // TODO: This line of code loads data into the 'DS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.DS.DatHang);

        }

        private void GCDatHang_Click(object sender, EventArgs e)
        {

        }
    }
}