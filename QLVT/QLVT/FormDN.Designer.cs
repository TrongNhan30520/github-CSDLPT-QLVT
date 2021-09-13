
namespace QLVT
{
    partial class FormDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDN));
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnDN = new System.Windows.Forms.Button();
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(88, 165);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(189, 21);
            this.txtTK.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(88, 204);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '●';
            this.txtMK.Size = new System.Drawing.Size(189, 21);
            this.txtMK.TabIndex = 1;
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(145, 297);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(74, 37);
            this.btnDN.TabIndex = 2;
            this.btnDN.Text = "ĐĂNG NHẬP";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            this.btnDN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnDN_keyPress);
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChinhanh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(132, 248);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(104, 22);
            this.cmbChinhanh.TabIndex = 3;
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormDN
            // 
            this.AcceptButton = this.btnDN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(357, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbChinhanh);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Name = "FormDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Đăng Nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.ComboBox cmbChinhanh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}