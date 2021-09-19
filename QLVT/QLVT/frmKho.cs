using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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


        

        private SqlConnection conn_publisher = new SqlConnection();
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";



        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.constr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về CSDL gốc. \nBạn xem lại Tên Server của Publisher và tên CSDL trong chuỗi kết nối.\n" + e.Message);
                return 0;
            }
        }
        private void frmKho_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.DS.Kho);
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