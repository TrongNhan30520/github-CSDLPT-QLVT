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
    public partial class frmKho : DevExpress.XtraEditors.XtraForm
    {
        public frmKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDSKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }


        private void HienThi()
        {
            txtMaCN.DataBindings.Clear();
            txtMaCN.DataBindings.Add("text", GCKho.DataSource, "MACN");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("text", GCKho.DataSource, "DIACHI");
            txtMaKho.DataBindings.Clear();
            txtMaKho.DataBindings.Add("text", GCKho.DataSource, "MAKHO");
            txtTenKho.DataBindings.Clear();
            txtTenKho.DataBindings.Add("text", GCKho.DataSource, "TENKHO");

        }

       
        private void frmKho_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.DS.Kho);
            HienThi();
            GRTTKho.Enabled = false;

        }

        private void khoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.BDSKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void GCKho_Click(object sender, EventArgs e)
        {

        }

        private void DCLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grChiNhanh_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}