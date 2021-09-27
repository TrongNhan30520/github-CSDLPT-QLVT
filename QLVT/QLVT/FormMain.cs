using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT
{

    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        public void HienThiMenu()
        {
            MANV.Text = "Mã NV: " + Program.username;
            HOTEN.Text = "Họ tên nhân viên : " + Program.mHoten;
            NHOM.Text = "Nhóm: " + Program.mGroup;
            //Phân quyền bật sáng chức năng bằng visitable
            //Tiếp tục if trên Program.Group

            ribbonControl1.Visible=true;

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKho));
            if (frm != null) frm.Activate();
            else
            {
                frmKho fKho = new frmKho();
                fKho.MdiParent = this;
                fKho.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {/*
            Form fm = this.CheckExists(typeof(FormMain));
            if (fm != null) fm.Close();
            Form frm = this.CheckExists(typeof(FormDN));
            if (frm != null) frm.Activate();
            else
            {
                FormDN FrmDN = new FormDN();
                FrmDN.MdiParent = this;
                FrmDN.Show();
            }*/
        }

        private void btnDX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            
            Form frm = this.CheckExists(typeof(FormDN));
            if (frm != null)

                frm.Activate();
            else
            {
                this.Close();
                FormDN f = new FormDN();
               /* f.MdiParent = this;*/
                f.Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                Form frm = this.CheckExists(typeof(frmNhanvien));
                if (frm != null) frm.Activate();
                else
                {
                    frmNhanvien fnv = new frmNhanvien();
                    fnv.MdiParent = this;
                    fnv.Show();
                }

            
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVatTu));
            if (frm != null) frm.Activate();
            else
            {
                frmVatTu fVatTu = new frmVatTu();
                fVatTu.MdiParent = this;
                fVatTu.Show();
            }

        }

        private void btnLapPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLapPhieu));
            if (frm != null) frm.Activate();
            else
            {
                frmLapPhieu fLapPhieu = new frmLapPhieu();
                fLapPhieu.MdiParent = this;
                fLapPhieu.Show();
            }
        }
    }
}
