
namespace QLVT
{
    partial class frmVatTu
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
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatTu));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barVT = new DevExpress.XtraBars.BarManager(this.components);
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
            this.BDSVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.QLVT_DATHANGDataSet();
            this.vattuTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.GCVatTu = new DevExpress.XtraGrid.GridControl();
            this.gridViewKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowguid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TTVatTu = new DevExpress.XtraEditors.GroupControl();
            this.numSLT = new System.Windows.Forms.NumericUpDown();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTVatTu)).BeginInit();
            this.TTVatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLT)).BeginInit();
            this.SuspendLayout();
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(486, 101);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(77, 13);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "Số Lượng Tồn:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(102, 101);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(63, 13);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn vị tính:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(486, 61);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(64, 13);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên Vật Tư:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(102, 62);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(60, 13);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã Vật Tư:";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 45);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(857, 0);
            // 
            // barVT
            // 
            this.barVT.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barVT.DockControls.Add(this.barDockControl1);
            this.barVT.DockControls.Add(this.barDockControlBottom);
            this.barVT.DockControls.Add(this.barDockControlLeft);
            this.barVT.DockControls.Add(this.barDockControlRight);
            this.barVT.Form = this;
            this.barVT.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
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
            this.barVT.MainMenu = this.bar2;
            this.barVT.MaxItemId = 12;
            this.barVT.StatusBar = this.bar3;
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
            this.barDockControl1.Manager = this.barVT;
            this.barDockControl1.Size = new System.Drawing.Size(857, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 443);
            this.barDockControlBottom.Manager = this.barVT;
            this.barDockControlBottom.Size = new System.Drawing.Size(857, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barVT;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 398);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(857, 45);
            this.barDockControlRight.Manager = this.barVT;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 398);
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
            // BDSVatTu
            // 
            this.BDSVatTu.DataMember = "Vattu";
            this.BDSVatTu.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // GCVatTu
            // 
            this.GCVatTu.DataSource = this.BDSVatTu;
            this.GCVatTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.GCVatTu.Location = new System.Drawing.Point(0, 45);
            this.GCVatTu.MainView = this.gridViewKho;
            this.GCVatTu.MenuManager = this.barVT;
            this.GCVatTu.Name = "GCVatTu";
            this.GCVatTu.Size = new System.Drawing.Size(857, 268);
            this.GCVatTu.TabIndex = 6;
            this.GCVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKho});
            // 
            // gridViewKho
            // 
            this.gridViewKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON,
            this.colrowguid});
            this.gridViewKho.GridControl = this.GCVatTu;
            this.gridViewKho.Name = "gridViewKho";
            this.gridViewKho.OptionsBehavior.Editable = false;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.Name = "colrowguid";
            // 
            // TTVatTu
            // 
            this.TTVatTu.AutoSize = true;
            this.TTVatTu.Controls.Add(sOLUONGTONLabel);
            this.TTVatTu.Controls.Add(this.numSLT);
            this.TTVatTu.Controls.Add(dVTLabel);
            this.TTVatTu.Controls.Add(this.txtDVT);
            this.TTVatTu.Controls.Add(tENVTLabel);
            this.TTVatTu.Controls.Add(this.txtTenVT);
            this.TTVatTu.Controls.Add(mAVTLabel);
            this.TTVatTu.Controls.Add(this.txtMaVT);
            this.TTVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TTVatTu.Location = new System.Drawing.Point(0, 313);
            this.TTVatTu.Name = "TTVatTu";
            this.TTVatTu.Size = new System.Drawing.Size(857, 130);
            this.TTVatTu.TabIndex = 7;
            this.TTVatTu.Text = "Thông Tin";
            // 
            // numSLT
            // 
            this.numSLT.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BDSVatTu, "SOLUONGTON", true));
            this.numSLT.Location = new System.Drawing.Point(593, 95);
            this.numSLT.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSLT.Name = "numSLT";
            this.numSLT.Size = new System.Drawing.Size(124, 21);
            this.numSLT.TabIndex = 7;
            // 
            // txtDVT
            // 
            this.txtDVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSVatTu, "DVT", true));
            this.txtDVT.Location = new System.Drawing.Point(182, 98);
            this.txtDVT.MaxLength = 15;
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(120, 21);
            this.txtDVT.TabIndex = 5;
            // 
            // txtTenVT
            // 
            this.txtTenVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSVatTu, "TENVT", true));
            this.txtTenVT.Location = new System.Drawing.Point(593, 54);
            this.txtTenVT.MaxLength = 30;
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(124, 21);
            this.txtTenVT.TabIndex = 3;
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSVatTu, "MAVT", true));
            this.txtMaVT.Location = new System.Drawing.Point(182, 58);
            this.txtMaVT.MaxLength = 4;
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(120, 21);
            this.txtMaVT.TabIndex = 1;
            // 
            // frmVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 463);
            this.Controls.Add(this.TTVatTu);
            this.Controls.Add(this.GCVatTu);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmVatTu";
            this.Text = "Vật Tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTVatTu)).EndInit();
            this.TTVatTu.ResumeLayout(false);
            this.TTVatTu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barVT;
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnCCN;
        private System.Windows.Forms.BindingSource BDSVatTu;
        private QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl GCVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKho;
        private QLVT_DATHANGDataSet DS;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
        private DevExpress.XtraEditors.GroupControl TTVatTu;
        private System.Windows.Forms.NumericUpDown numSLT;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.TextBox txtMaVT;
    }
}