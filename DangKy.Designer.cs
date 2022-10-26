namespace FormDNDKQMK
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_TK = new System.Windows.Forms.TextBox();
            this.tb_MK = new System.Windows.Forms.TextBox();
            this.tb_XNMK = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.bt_dangky = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(50, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Tài Khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(50, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(50, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xác Nhận Mật Khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(50, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email:";
            // 
            // tb_TK
            // 
            this.tb_TK.Location = new System.Drawing.Point(214, 237);
            this.tb_TK.Name = "tb_TK";
            this.tb_TK.Size = new System.Drawing.Size(285, 26);
            this.tb_TK.TabIndex = 2;
            // 
            // tb_MK
            // 
            this.tb_MK.Location = new System.Drawing.Point(214, 278);
            this.tb_MK.Name = "tb_MK";
            this.tb_MK.PasswordChar = '*';
            this.tb_MK.Size = new System.Drawing.Size(285, 26);
            this.tb_MK.TabIndex = 2;
            // 
            // tb_XNMK
            // 
            this.tb_XNMK.Location = new System.Drawing.Point(214, 316);
            this.tb_XNMK.Name = "tb_XNMK";
            this.tb_XNMK.PasswordChar = '*';
            this.tb_XNMK.Size = new System.Drawing.Size(285, 26);
            this.tb_XNMK.TabIndex = 2;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(214, 360);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(285, 26);
            this.tb_email.TabIndex = 2;
            // 
            // bt_dangky
            // 
            this.bt_dangky.BackColor = System.Drawing.Color.SpringGreen;
            this.bt_dangky.Location = new System.Drawing.Point(316, 403);
            this.bt_dangky.Name = "bt_dangky";
            this.bt_dangky.Size = new System.Drawing.Size(108, 35);
            this.bt_dangky.TabIndex = 3;
            this.bt_dangky.Text = "Đăng Ký";
            this.bt_dangky.UseVisualStyleBackColor = false;
            this.bt_dangky.Click += new System.EventHandler(this.bt_dangky_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormDNDKQMK.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1.Location = new System.Drawing.Point(214, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_dangky);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_XNMK);
            this.Controls.Add(this.tb_MK);
            this.Controls.Add(this.tb_TK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangKy";
            this.Text = "DangKy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_TK;
        private System.Windows.Forms.TextBox tb_MK;
        private System.Windows.Forms.TextBox tb_XNMK;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button bt_dangky;
    }
}