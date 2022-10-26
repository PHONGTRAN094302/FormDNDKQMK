namespace FormDNDKQMK
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.linkLabel_QMK = new System.Windows.Forms.LinkLabel();
            this.linkLabel_DK = new System.Windows.Forms.LinkLabel();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Location = new System.Drawing.Point(236, 228);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(237, 26);
            this.tb_taikhoan.TabIndex = 1;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(236, 292);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '*';
            this.tb_matkhau.Size = new System.Drawing.Size(237, 26);
            this.tb_matkhau.TabIndex = 1;
            // 
            // linkLabel_QMK
            // 
            this.linkLabel_QMK.AutoSize = true;
            this.linkLabel_QMK.Location = new System.Drawing.Point(208, 361);
            this.linkLabel_QMK.Name = "linkLabel_QMK";
            this.linkLabel_QMK.Size = new System.Drawing.Size(127, 20);
            this.linkLabel_QMK.TabIndex = 2;
            this.linkLabel_QMK.TabStop = true;
            this.linkLabel_QMK.Text = "Quên mật khẩu?";
            this.linkLabel_QMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_QMK_LinkClicked);
            // 
            // linkLabel_DK
            // 
            this.linkLabel_DK.AutoSize = true;
            this.linkLabel_DK.Location = new System.Drawing.Point(418, 361);
            this.linkLabel_DK.Name = "linkLabel_DK";
            this.linkLabel_DK.Size = new System.Drawing.Size(69, 20);
            this.linkLabel_DK.TabIndex = 2;
            this.linkLabel_DK.TabStop = true;
            this.linkLabel_DK.Text = "Đăng Ký";
            this.linkLabel_DK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DK_LinkClicked);
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.BackColor = System.Drawing.Color.Gold;
            this.bt_dangnhap.Location = new System.Drawing.Point(318, 399);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(118, 39);
            this.bt_dangnhap.TabIndex = 3;
            this.bt_dangnhap.Text = "Đăng Nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FormDNDKQMK.Properties.Resources.icon_password;
            this.pictureBox3.Location = new System.Drawing.Point(169, 292);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormDNDKQMK.Properties.Resources.user_icon_150670;
            this.pictureBox2.Location = new System.Drawing.Point(169, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormDNDKQMK.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1.Location = new System.Drawing.Point(236, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.linkLabel_DK);
            this.Controls.Add(this.linkLabel_QMK);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.tb_taikhoan);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tb_taikhoan;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.LinkLabel linkLabel_QMK;
        private System.Windows.Forms.LinkLabel linkLabel_DK;
        private System.Windows.Forms.Button bt_dangnhap;
    }
}

