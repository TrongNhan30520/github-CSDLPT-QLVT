
namespace QLVT
{
    partial class frmNhanvien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label mACNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode9 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode10 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode11 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode12 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode13 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode14 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode15 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode16 = new DevExpress.XtraGrid.GridLevelNode();
            this.barQL = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnCCN = new DevExpress.XtraBars.BarButtonItem();
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
            this.DS = new QLVT.QLVT_DATHANGDataSet();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.grChiNhanh = new DevExpress.XtraEditors.GroupControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.gcNV = new DevExpress.XtraGrid.GridControl();
            this.gridViewNV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowguid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BDSDH = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.BDSPX = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter();
            this.boxTTX = new System.Windows.Forms.CheckBox();
            this.spinMaNV = new DevExpress.XtraEditors.SpinEdit();
            this.grTTNV = new DevExpress.XtraEditors.GroupControl();
            this.txtMACN = new DevExpress.XtraEditors.TextEdit();
            this.lUONGSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.DateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grChiNhanh)).BeginInit();
            this.grChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTTNV)).BeginInit();
            this.grTTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(22, 52);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(39, 13);
            mANVLabel.TabIndex = 30;
            mANVLabel.Text = "MANV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(236, 56);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 31;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(501, 52);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 32;
            tENLabel.Text = "TEN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(215, 131);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 33;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(808, 60);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(62, 13);
            nGAYSINHLabel.TabIndex = 34;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Location = new System.Drawing.Point(501, 135);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(45, 13);
            lUONGLabel.TabIndex = 35;
            lUONGLabel.Text = "LUONG:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(22, 131);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(40, 13);
            mACNLabel.TabIndex = 36;
            mACNLabel.Text = "MACN:";
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
            this.barQL.DockWindowTabFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCCN,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCCN, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
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
            // btnCCN
            // 
            this.btnCCN.Caption = "Chuyển Chi Nhánh";
            this.btnCCN.Id = 10;
            this.btnCCN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCCN.ImageOptions.SvgImage")));
            this.btnCCN.Name = "btnCCN";
            this.btnCCN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 11;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1328, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 736);
            this.barDockControlBottom.Manager = this.barQL;
            this.barDockControlBottom.Size = new System.Drawing.Size(1328, 20);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1328, 45);
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
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
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
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.DS;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // grChiNhanh
            // 
            this.grChiNhanh.AutoSize = true;
            this.grChiNhanh.Controls.Add(this.cmbChiNhanh);
            this.grChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.grChiNhanh.Location = new System.Drawing.Point(0, 45);
            this.grChiNhanh.Name = "grChiNhanh";
            this.grChiNhanh.Size = new System.Drawing.Size(1328, 87);
            this.grChiNhanh.TabIndex = 25;
            this.grChiNhanh.Text = "Chi Nhánh";
            this.grChiNhanh.Paint += new System.Windows.Forms.PaintEventHandler(this.grChiNhanh_Paint);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(152, 38);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(276, 21);
            this.cmbChiNhanh.TabIndex = 0;
            // 
            // gcNV
            // 
            this.gcNV.DataSource = this.bdsNV;
            this.gcNV.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode10.RelationName = "FK_CTDDH_DatHang";
            gridLevelNode12.RelationName = "FK_CTPN_PhieuNhap";
            gridLevelNode11.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode12});
            gridLevelNode11.RelationName = "FK_PhieuNhap_DatHang";
            gridLevelNode9.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode10,
            gridLevelNode11});
            gridLevelNode9.RelationName = "FK_DatHang_NhanVien";
            gridLevelNode14.RelationName = "FK_CTPN_PhieuNhap";
            gridLevelNode13.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode14});
            gridLevelNode13.RelationName = "FK_PhieuNhap_NhanVien";
            gridLevelNode16.RelationName = "FK_CTPX_PX";
            gridLevelNode15.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode16});
            gridLevelNode15.RelationName = "FK_PX_NhanVien";
            this.gcNV.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode9,
            gridLevelNode13,
            gridLevelNode15});
            this.gcNV.Location = new System.Drawing.Point(0, 132);
            this.gcNV.MainView = this.gridViewNV;
            this.gcNV.MenuManager = this.barQL;
            this.gcNV.Name = "gcNV";
            this.gcNV.Size = new System.Drawing.Size(1328, 604);
            this.gcNV.TabIndex = 26;
            this.gcNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNV});
            this.gcNV.Click += new System.EventHandler(this.gcNV_Click_2);
            // 
            // gridViewNV
            // 
            this.gridViewNV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa,
            this.colrowguid});
            this.gridViewNV.GridControl = this.gcNV;
            this.gridViewNV.Name = "gridViewNV";
            this.gridViewNV.OptionsBehavior.Editable = false;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colLUONG
            // 
            this.colLUONG.DisplayFormat.FormatString = "n0";
            this.colLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            // 
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.Name = "colrowguid";
            // 
            // BDSDH
            // 
            this.BDSDH.DataMember = "DatHang";
            this.BDSDH.DataSource = this.DS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // BDSPX
            // 
            this.BDSPX.DataMember = "PhieuXuat";
            this.BDSPX.DataSource = this.DS;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // boxTTX
            // 
            this.boxTTX.AutoSize = true;
            this.boxTTX.Location = new System.Drawing.Point(876, 127);
            this.boxTTX.Name = "boxTTX";
            this.boxTTX.Size = new System.Drawing.Size(96, 17);
            this.boxTTX.TabIndex = 28;
            this.boxTTX.Text = "Trạng thái xóa";
            this.boxTTX.UseVisualStyleBackColor = true;
            // 
            // spinMaNV
            // 
            this.spinMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MANV", true));
            this.spinMaNV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMaNV.Location = new System.Drawing.Point(67, 49);
            this.spinMaNV.MenuManager = this.barQL;
            this.spinMaNV.Name = "spinMaNV";
            this.spinMaNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinMaNV.Size = new System.Drawing.Size(100, 20);
            this.spinMaNV.TabIndex = 31;
            // 
            // grTTNV
            // 
            this.grTTNV.AutoSize = true;
            this.grTTNV.Controls.Add(mACNLabel);
            this.grTTNV.Controls.Add(this.txtMACN);
            this.grTTNV.Controls.Add(lUONGLabel);
            this.grTTNV.Controls.Add(this.lUONGSpinEdit);
            this.grTTNV.Controls.Add(nGAYSINHLabel);
            this.grTTNV.Controls.Add(this.DateNgaySinh);
            this.grTTNV.Controls.Add(dIACHILabel);
            this.grTTNV.Controls.Add(this.txtDiaChi);
            this.grTTNV.Controls.Add(tENLabel);
            this.grTTNV.Controls.Add(this.txtTen);
            this.grTTNV.Controls.Add(hOLabel);
            this.grTTNV.Controls.Add(this.txtHo);
            this.grTTNV.Controls.Add(mANVLabel);
            this.grTTNV.Controls.Add(this.spinMaNV);
            this.grTTNV.Controls.Add(this.boxTTX);
            this.grTTNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grTTNV.Location = new System.Drawing.Point(0, 560);
            this.grTTNV.Name = "grTTNV";
            this.grTTNV.Size = new System.Drawing.Size(1328, 176);
            this.grTTNV.TabIndex = 27;
            this.grTTNV.Text = "Thông Tin";
            this.grTTNV.Paint += new System.Windows.Forms.PaintEventHandler(this.grTTNV_Paint);
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MACN", true));
            this.txtMACN.Location = new System.Drawing.Point(68, 128);
            this.txtMACN.MenuManager = this.barQL;
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Size = new System.Drawing.Size(100, 20);
            this.txtMACN.TabIndex = 37;
            // 
            // lUONGSpinEdit
            // 
            this.lUONGSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "LUONG", true));
            this.lUONGSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lUONGSpinEdit.Location = new System.Drawing.Point(573, 128);
            this.lUONGSpinEdit.MenuManager = this.barQL;
            this.lUONGSpinEdit.Name = "lUONGSpinEdit";
            this.lUONGSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUONGSpinEdit.Properties.DisplayFormat.FormatString = "n0";
            this.lUONGSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.lUONGSpinEdit.Properties.EditFormat.FormatString = "n0";
            this.lUONGSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.lUONGSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.lUONGSpinEdit.TabIndex = 36;
            // 
            // DateNgaySinh
            // 
            this.DateNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "NGAYSINH", true));
            this.DateNgaySinh.EditValue = null;
            this.DateNgaySinh.Location = new System.Drawing.Point(876, 53);
            this.DateNgaySinh.MenuManager = this.barQL;
            this.DateNgaySinh.Name = "DateNgaySinh";
            this.DateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.DateNgaySinh.TabIndex = 35;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(268, 128);
            this.txtDiaChi.MenuManager = this.barQL;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 34;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(568, 49);
            this.txtTen.MenuManager = this.barQL;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(105, 20);
            this.txtTen.TabIndex = 33;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(268, 49);
            this.txtHo.MenuManager = this.barQL;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(100, 20);
            this.txtHo.TabIndex = 32;
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1328, 756);
            this.Controls.Add(this.grTTNV);
            this.Controls.Add(this.gcNV);
            this.Controls.Add(this.grChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MinimumSize = new System.Drawing.Size(866, 32);
            this.Name = "frmNhanvien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grChiNhanh)).EndInit();
            this.grChiNhanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTTNV)).EndInit();
            this.grTTNV.ResumeLayout(false);
            this.grTTNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barQL;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnTaiLai;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.BindingSource bdsNV;
        private QLVT_DATHANGDataSet DS;
        private QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcNV;
        private DevExpress.XtraEditors.GroupControl grChiNhanh;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNV;
        private DevExpress.XtraBars.BarButtonItem btnCCN;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource BDSDH;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource BDSPX;
        private QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
        private DevExpress.XtraEditors.GroupControl grTTNV;
        private DevExpress.XtraEditors.TextEdit txtMACN;
        private DevExpress.XtraEditors.SpinEdit lUONGSpinEdit;
        private DevExpress.XtraEditors.DateEdit DateNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.SpinEdit spinMaNV;
        private System.Windows.Forms.CheckBox boxTTX;
    }
}