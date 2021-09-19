
namespace QLVT
{
    partial class frmKho
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
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            this.barKho = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCCN = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new QLVT.QLVT_DATHANGDataSet();
            this.BDSKho = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.GRTTKho = new DevExpress.XtraEditors.GroupControl();
            this.txtDC = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKho = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.txtMACN = new DevExpress.XtraEditors.TextEdit();
            this.grChiNhanhKho = new DevExpress.XtraEditors.GroupControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.GCKho = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowguid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewDataSource1 = new DevExpress.Persistent.Base.ReportsV2.ViewDataSource();
            this.viewDataSource2 = new DevExpress.Persistent.Base.ReportsV2.ViewDataSource();
            mACNLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRTTKho)).BeginInit();
            this.GRTTKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grChiNhanhKho)).BeginInit();
            this.grChiNhanhKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDataSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(48, 35);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(40, 13);
            mACNLabel.TabIndex = 3;
            mACNLabel.Text = "MACN:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(48, 95);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(47, 13);
            mAKHOLabel.TabIndex = 4;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(502, 91);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(51, 13);
            tENKHOLabel.TabIndex = 6;
            tENKHOLabel.Text = "TENKHO:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(502, 35);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // barKho
            // 
            this.barKho.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barKho.DockControls.Add(this.barDockControl1);
            this.barKho.DockControls.Add(this.barDockControlBottom);
            this.barKho.DockControls.Add(this.barDockControlLeft);
            this.barKho.DockControls.Add(this.barDockControlRight);
            this.barKho.Form = this;
            this.barKho.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThemVT,
            this.btnXoa,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnTaiLai,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem2,
            this.btnCCN,
            this.btnThoat});
            this.barKho.MainMenu = this.bar2;
            this.barKho.MaxItemId = 12;
            this.barKho.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaiLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemVT
            // 
            this.btnThemVT.Caption = "Thêm";
            this.btnThemVT.Id = 1;
            this.btnThemVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVT.ImageOptions.Image")));
            this.btnThemVT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemVT.ImageOptions.LargeImage")));
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barKho;
            this.barDockControl1.Size = new System.Drawing.Size(931, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 736);
            this.barDockControlBottom.Manager = this.barKho;
            this.barDockControlBottom.Size = new System.Drawing.Size(931, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barKho;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 691);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(931, 45);
            this.barDockControlRight.Manager = this.barKho;
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
            // btnCCN
            // 
            this.btnCCN.Caption = "Chuyển Chi Nhánh";
            this.btnCCN.Id = 10;
            this.btnCCN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCCN.ImageOptions.SvgImage")));
            this.btnCCN.Name = "btnCCN";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BDSKho
            // 
            this.BDSKho.DataMember = "Kho";
            this.BDSKho.DataSource = this.DS;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // GRTTKho
            // 
            this.GRTTKho.AutoSize = true;
            this.GRTTKho.Controls.Add(dIACHILabel);
            this.GRTTKho.Controls.Add(this.txtDC);
            this.GRTTKho.Controls.Add(tENKHOLabel);
            this.GRTTKho.Controls.Add(this.txtTenKho);
            this.GRTTKho.Controls.Add(mAKHOLabel);
            this.GRTTKho.Controls.Add(this.txtMaKho);
            this.GRTTKho.Controls.Add(mACNLabel);
            this.GRTTKho.Controls.Add(this.txtMACN);
            this.GRTTKho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GRTTKho.Location = new System.Drawing.Point(0, 600);
            this.GRTTKho.Name = "GRTTKho";
            this.GRTTKho.Size = new System.Drawing.Size(931, 136);
            this.GRTTKho.TabIndex = 8;
            this.GRTTKho.Text = "Thông Tin";
            this.GRTTKho.Paint += new System.Windows.Forms.PaintEventHandler(this.DCLabel_Paint);
            // 
            // txtDC
            // 
            this.txtDC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BDSKho, "DIACHI", true));
            this.txtDC.Location = new System.Drawing.Point(600, 32);
            this.txtDC.MenuManager = this.barKho;
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(226, 20);
            this.txtDC.TabIndex = 9;
            // 
            // txtTenKho
            // 
            this.txtTenKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BDSKho, "TENKHO", true));
            this.txtTenKho.Location = new System.Drawing.Point(600, 88);
            this.txtTenKho.MenuManager = this.barKho;
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(226, 20);
            this.txtTenKho.TabIndex = 7;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BDSKho, "MAKHO", true));
            this.txtMaKho.Location = new System.Drawing.Point(101, 88);
            this.txtMaKho.MenuManager = this.barKho;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(212, 20);
            this.txtMaKho.TabIndex = 5;
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BDSKho, "MACN", true));
            this.txtMACN.Location = new System.Drawing.Point(101, 32);
            this.txtMACN.MenuManager = this.barKho;
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Size = new System.Drawing.Size(212, 20);
            this.txtMACN.TabIndex = 4;
            // 
            // grChiNhanhKho
            // 
            this.grChiNhanhKho.AutoSize = true;
            this.grChiNhanhKho.Controls.Add(this.cmbChiNhanh);
            this.grChiNhanhKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.grChiNhanhKho.Location = new System.Drawing.Point(0, 45);
            this.grChiNhanhKho.Name = "grChiNhanhKho";
            this.grChiNhanhKho.Size = new System.Drawing.Size(931, 87);
            this.grChiNhanhKho.TabIndex = 26;
            this.grChiNhanhKho.Text = "Chi Nhánh";
            this.grChiNhanhKho.Paint += new System.Windows.Forms.PaintEventHandler(this.grChiNhanh_Paint);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(152, 38);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(262, 21);
            this.cmbChiNhanh.TabIndex = 0;
            // 
            // GCKho
            // 
            this.GCKho.DataSource = this.BDSKho;
            this.GCKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCKho.Location = new System.Drawing.Point(0, 132);
            this.GCKho.MainView = this.gridView1;
            this.GCKho.MenuManager = this.barKho;
            this.GCKho.Name = "GCKho";
            this.GCKho.Size = new System.Drawing.Size(931, 468);
            this.GCKho.TabIndex = 31;
            this.GCKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMACN,
            this.colrowguid,
            this.colMAKHO,
            this.colDIACHI,
            this.colTENKHO});
            this.gridView1.GridControl = this.GCKho;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 0;
            // 
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.Name = "colrowguid";
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 1;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            // 
            // colTENKHO
            // 
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 3;
            // 
            // viewDataSource1
            // 
            this.viewDataSource1.Name = "viewDataSource1";
            this.viewDataSource1.ObjectTypeName = null;
            this.viewDataSource1.TopReturnedRecords = 0;
            // 
            // viewDataSource2
            // 
            this.viewDataSource2.Name = "viewDataSource2";
            this.viewDataSource2.ObjectTypeName = null;
            this.viewDataSource2.TopReturnedRecords = 0;
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(931, 756);
            this.Controls.Add(this.GCKho);
            this.Controls.Add(this.grChiNhanhKho);
            this.Controls.Add(this.GRTTKho);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmKho";
            this.Text = "Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRTTKho)).EndInit();
            this.GRTTKho.ResumeLayout(false);
            this.GRTTKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grChiNhanhKho)).EndInit();
            this.grChiNhanhKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDataSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barKho;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemVT;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnTaiLai;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource BDSKho;
        private QLVT_DATHANGDataSet DS;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnCCN;
        private QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl GRTTKho;
        private DevExpress.XtraEditors.GroupControl grChiNhanhKho;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraGrid.GridControl GCKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.Persistent.Base.ReportsV2.ViewDataSource viewDataSource1;
        private DevExpress.Persistent.Base.ReportsV2.ViewDataSource viewDataSource2;
        private DevExpress.XtraEditors.TextEdit txtDC;
        private DevExpress.XtraEditors.TextEdit txtTenKho;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.TextEdit txtMACN;
    }
}