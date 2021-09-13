
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode5 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode6 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode7 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode8 = new DevExpress.XtraGrid.GridLevelNode();
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
            this.cbbCN = new System.Windows.Forms.ComboBox();
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
            this.grTTNV = new DevExpress.XtraEditors.GroupControl();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.dateTimeNV = new System.Windows.Forms.DateTimePicker();
            this.boxTTX = new System.Windows.Forms.CheckBox();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMANV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grChiNhanh)).BeginInit();
            this.grChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTTNV)).BeginInit();
            this.grTTNV.SuspendLayout();
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
            this.barDockControlTop.Size = new System.Drawing.Size(1141, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 481);
            this.barDockControlBottom.Manager = this.barQL;
            this.barDockControlBottom.Size = new System.Drawing.Size(1141, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barQL;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 436);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1141, 45);
            this.barDockControlRight.Manager = this.barQL;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 436);
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
            this.grChiNhanh.Controls.Add(this.cbbCN);
            this.grChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.grChiNhanh.Location = new System.Drawing.Point(0, 45);
            this.grChiNhanh.Name = "grChiNhanh";
            this.grChiNhanh.Size = new System.Drawing.Size(1141, 87);
            this.grChiNhanh.TabIndex = 25;
            this.grChiNhanh.Text = "Chi Nhánh";
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
            // gcNV
            // 
            this.gcNV.DataSource = this.bdsNV;
            this.gcNV.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "FK_CTDDH_DatHang";
            gridLevelNode4.RelationName = "FK_CTPN_PhieuNhap";
            gridLevelNode3.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode4});
            gridLevelNode3.RelationName = "FK_PhieuNhap_DatHang";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2,
            gridLevelNode3});
            gridLevelNode1.RelationName = "FK_DatHang_NhanVien";
            gridLevelNode6.RelationName = "FK_CTPN_PhieuNhap";
            gridLevelNode5.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode6});
            gridLevelNode5.RelationName = "FK_PhieuNhap_NhanVien";
            gridLevelNode8.RelationName = "FK_CTPX_PX";
            gridLevelNode7.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode8});
            gridLevelNode7.RelationName = "FK_PX_NhanVien";
            this.gcNV.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode5,
            gridLevelNode7});
            this.gcNV.Location = new System.Drawing.Point(0, 132);
            this.gcNV.MainView = this.gridViewNV;
            this.gcNV.MenuManager = this.barQL;
            this.gcNV.Name = "gcNV";
            this.gcNV.Size = new System.Drawing.Size(1141, 349);
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
            this.gridViewNV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDIACHI, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            // grTTNV
            // 
            this.grTTNV.AutoSize = true;
            this.grTTNV.Controls.Add(this.txtLuong);
            this.grTTNV.Controls.Add(this.dateTimeNV);
            this.grTTNV.Controls.Add(this.boxTTX);
            this.grTTNV.Controls.Add(this.txtMaCN);
            this.grTTNV.Controls.Add(this.txtTen);
            this.grTTNV.Controls.Add(this.txtDC);
            this.grTTNV.Controls.Add(this.txtHo);
            this.grTTNV.Controls.Add(this.txtMaNV);
            this.grTTNV.Controls.Add(this.label7);
            this.grTTNV.Controls.Add(this.label6);
            this.grTTNV.Controls.Add(this.label5);
            this.grTTNV.Controls.Add(this.label4);
            this.grTTNV.Controls.Add(this.label3);
            this.grTTNV.Controls.Add(this.label2);
            this.grTTNV.Controls.Add(this.lbMANV);
            this.grTTNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grTTNV.Location = new System.Drawing.Point(0, 338);
            this.grTTNV.Name = "grTTNV";
            this.grTTNV.Size = new System.Drawing.Size(1141, 143);
            this.grTTNV.TabIndex = 27;
            this.grTTNV.Text = "Thông Tin";
            this.grTTNV.Paint += new System.Windows.Forms.PaintEventHandler(this.grTTNV_Paint);
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(450, 92);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(87, 21);
            this.txtLuong.TabIndex = 30;
            // 
            // dateTimeNV
            // 
            this.dateTimeNV.Location = new System.Drawing.Point(125, 94);
            this.dateTimeNV.Name = "dateTimeNV";
            this.dateTimeNV.Size = new System.Drawing.Size(85, 21);
            this.dateTimeNV.TabIndex = 29;
            this.dateTimeNV.Value = new System.DateTime(2021, 9, 12, 0, 0, 0, 0);
            this.dateTimeNV.ValueChanged += new System.EventHandler(this.dateTimeNV_ValueChanged);
            // 
            // boxTTX
            // 
            this.boxTTX.AutoSize = true;
            this.boxTTX.Location = new System.Drawing.Point(681, 97);
            this.boxTTX.Name = "boxTTX";
            this.boxTTX.Size = new System.Drawing.Size(96, 17);
            this.boxTTX.TabIndex = 28;
            this.boxTTX.Text = "Trạng thái xóa";
            this.boxTTX.UseVisualStyleBackColor = true;
            // 
            // txtMaCN
            // 
            this.txtMaCN.Location = new System.Drawing.Point(681, 46);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(96, 21);
            this.txtMaCN.TabIndex = 27;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(450, 46);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(87, 21);
            this.txtTen.TabIndex = 26;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(295, 94);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(81, 21);
            this.txtDC.TabIndex = 25;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(295, 46);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(81, 21);
            this.txtHo.TabIndex = 24;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(125, 49);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(85, 21);
            this.txtMaNV.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "MACN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "LƯƠNG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "TÊN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "HỌ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "NGAYSINH:";
            // 
            // lbMANV
            // 
            this.lbMANV.AutoSize = true;
            this.lbMANV.Location = new System.Drawing.Point(66, 54);
            this.lbMANV.Name = "lbMANV";
            this.lbMANV.Size = new System.Drawing.Size(39, 13);
            this.lbMANV.TabIndex = 16;
            this.lbMANV.Text = "MANV:";
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 501);
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
            ((System.ComponentModel.ISupportInitialize)(this.grTTNV)).EndInit();
            this.grTTNV.ResumeLayout(false);
            this.grTTNV.PerformLayout();
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
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
        private DevExpress.XtraEditors.GroupControl grChiNhanh;
        private System.Windows.Forms.ComboBox cbbCN;
        private DevExpress.XtraEditors.GroupControl grTTNV;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.DateTimePicker dateTimeNV;
        private System.Windows.Forms.CheckBox boxTTX;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMANV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNV;
        private DevExpress.XtraBars.BarButtonItem btnCCN;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
    }
}