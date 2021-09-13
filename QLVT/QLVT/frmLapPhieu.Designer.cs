
namespace QLVT
{
    partial class frmLapPhieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapPhieu));
            this.barQL = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnLapPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.grLapPhieu = new DevExpress.XtraEditors.GroupControl();
            this.cbbCN = new System.Windows.Forms.ComboBox();
            this.DS = new QLVT.QLVT_DATHANGDataSet();
            this.BDSDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter();
            this.phieuXuatTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter();
            this.GCDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BDSPX = new System.Windows.Forms.BindingSource(this.components);
            this.GCPX = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grDatHang = new DevExpress.XtraEditors.GroupControl();
            this.cTDDHGridControl = new DevExpress.XtraGrid.GridControl();
            this.BDSCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grThongTin = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.barQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grLapPhieu)).BeginInit();
            this.grLapPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDatHang)).BeginInit();
            this.grDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // barQL
            // 
            this.barQL.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barQL.DockControls.Add(this.barDockControlTop);
            this.barQL.DockControls.Add(this.barDockControlBottom);
            this.barQL.DockControls.Add(this.barDockControlLeft);
            this.barQL.DockControls.Add(this.barDockControlRight);
            this.barQL.Form = this;
            this.barQL.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnTaiLai,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem2,
            this.btnLapPhieu,
            this.btnThoat});
            this.barQL.MainMenu = this.bar2;
            this.barQL.MaxItemId = 12;
            this.barQL.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaiLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLapPhieu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Caption = "Tải lại";
            this.btnTaiLai.Id = 6;
            this.btnTaiLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaiLai.ImageOptions.SvgImage")));
            this.btnTaiLai.Name = "btnTaiLai";
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.ActAsDropDown = true;
            this.btnLapPhieu.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnLapPhieu.Caption = "Lập phiếu";
            this.btnLapPhieu.Id = 10;
            this.btnLapPhieu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLapPhieu.ImageOptions.SvgImage")));
            this.btnLapPhieu.Name = "btnLapPhieu";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 11;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(257, 164);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barQL;
            this.barDockControlTop.Size = new System.Drawing.Size(945, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 736);
            this.barDockControlBottom.Manager = this.barQL;
            this.barDockControlBottom.Size = new System.Drawing.Size(945, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barQL;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 691);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(945, 45);
            this.barDockControlRight.Manager = this.barQL;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 691);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.ActAsDropDown = true;
            this.barButtonItem8.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem8.Caption = "Chuyển Chi Nhánh";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Thoát";
            this.barButtonItem9.Id = 8;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thoát";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barQL;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // grLapPhieu
            // 
            this.grLapPhieu.AutoSize = true;
            this.grLapPhieu.Controls.Add(this.cbbCN);
            this.grLapPhieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.grLapPhieu.Location = new System.Drawing.Point(0, 45);
            this.grLapPhieu.Name = "grLapPhieu";
            this.grLapPhieu.Size = new System.Drawing.Size(945, 87);
            this.grLapPhieu.TabIndex = 27;
            this.grLapPhieu.Text = "Chi Nhánh";
            // 
            // cbbCN
            // 
            this.cbbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCN.FormattingEnabled = true;
            this.cbbCN.Location = new System.Drawing.Point(152, 38);
            this.cbbCN.Name = "cbbCN";
            this.cbbCN.Size = new System.Drawing.Size(262, 21);
            this.cbbCN.TabIndex = 0;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BDSDatHang
            // 
            this.BDSDatHang.DataMember = "DatHang";
            this.BDSDatHang.DataSource = this.DS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // GCDatHang
            // 
            this.GCDatHang.DataSource = this.BDSDatHang;
            this.GCDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.GCDatHang.Location = new System.Drawing.Point(0, 132);
            this.GCDatHang.MainView = this.gridView1;
            this.GCDatHang.MenuManager = this.barQL;
            this.GCDatHang.Name = "GCDatHang";
            this.GCDatHang.Size = new System.Drawing.Size(945, 171);
            this.GCDatHang.TabIndex = 28;
            this.GCDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GCDatHang.Click += new System.EventHandler(this.GCDatHang_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GCDatHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Đơn Đặt Hàng";
            // 
            // BDSPX
            // 
            this.BDSPX.DataMember = "PhieuXuat";
            this.BDSPX.DataSource = this.DS;
            // 
            // GCPX
            // 
            this.GCPX.DataSource = this.BDSPX;
            this.GCPX.Dock = System.Windows.Forms.DockStyle.Top;
            this.GCPX.Location = new System.Drawing.Point(0, 303);
            this.GCPX.MainView = this.gridView2;
            this.GCPX.MenuManager = this.barQL;
            this.GCPX.Name = "GCPX";
            this.GCPX.Size = new System.Drawing.Size(945, 172);
            this.GCPX.TabIndex = 28;
            this.GCPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.GCPX;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "Phiếu Xuất";
            // 
            // grDatHang
            // 
            this.grDatHang.Controls.Add(this.cTDDHGridControl);
            this.grDatHang.Controls.Add(this.grThongTin);
            this.grDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grDatHang.Location = new System.Drawing.Point(0, 475);
            this.grDatHang.Name = "grDatHang";
            this.grDatHang.Size = new System.Drawing.Size(945, 305);
            this.grDatHang.TabIndex = 29;
            this.grDatHang.Text = "Đặt Hàng";
            // 
            // cTDDHGridControl
            // 
            this.cTDDHGridControl.DataSource = this.BDSCTDDH;
            this.cTDDHGridControl.Location = new System.Drawing.Point(332, 26);
            this.cTDDHGridControl.MainView = this.gridView3;
            this.cTDDHGridControl.MenuManager = this.barQL;
            this.cTDDHGridControl.Name = "cTDDHGridControl";
            this.cTDDHGridControl.Size = new System.Drawing.Size(613, 187);
            this.cTDDHGridControl.TabIndex = 1;
            this.cTDDHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // BDSCTDDH
            // 
            this.BDSCTDDH.DataMember = "CTDDH";
            this.BDSCTDDH.DataSource = this.DS;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.cTDDHGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowViewCaption = true;
            this.gridView3.ViewCaption = "Chi Tiết Đơn Đặt Hàng";
            // 
            // grThongTin
            // 
            this.grThongTin.Location = new System.Drawing.Point(0, 26);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Size = new System.Drawing.Size(332, 187);
            this.grThongTin.TabIndex = 0;
            this.grThongTin.TabStop = false;
            this.grThongTin.Text = "Thông tin";
            // 
            // frmLapPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 756);
            this.Controls.Add(this.grDatHang);
            this.Controls.Add(this.GCPX);
            this.Controls.Add(this.GCDatHang);
            this.Controls.Add(this.grLapPhieu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLapPhieu";
            this.Text = "Lập phiếu";
            this.Load += new System.EventHandler(this.frmLapPhieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grLapPhieu)).EndInit();
            this.grLapPhieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDatHang)).EndInit();
            this.grDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barQL;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnTaiLai;
        private DevExpress.XtraBars.BarButtonItem btnLapPhieu;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraEditors.GroupControl grLapPhieu;
        private System.Windows.Forms.ComboBox cbbCN;
        private System.Windows.Forms.BindingSource BDSDatHang;
        private QLVT_DATHANGDataSet DS;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl GCDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource BDSPX;
        private DevExpress.XtraGrid.GridControl GCPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl grDatHang;
        private System.Windows.Forms.GroupBox grThongTin;
        private QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource BDSCTDDH;
        private DevExpress.XtraGrid.GridControl cTDDHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}