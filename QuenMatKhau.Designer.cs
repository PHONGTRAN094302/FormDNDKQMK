namespace FormDNDKQMK
{
    partial class QuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_XNEmail = new System.Windows.Forms.TextBox();
            this.bt_laylaiMK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(100, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xác Nhận Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(159, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết Quả:";
            // 
            // tb_XNEmail
            // 
            this.tb_XNEmail.Location = new System.Drawing.Point(241, 276);
            this.tb_XNEmail.Name = "tb_XNEmail";
            this.tb_XNEmail.Size = new System.Drawing.Size(236, 26);
            this.tb_XNEmail.TabIndex = 2;
            // 
            // bt_laylaiMK
            // 
            this.bt_laylaiMK.BackColor = System.Drawing.Color.Blue;
            this.bt_laylaiMK.ForeColor = System.Drawing.Color.White;
            this.bt_laylaiMK.Location = new System.Drawing.Point(296, 369);
            this.bt_laylaiMK.Name = "bt_laylaiMK";
            this.bt_laylaiMK.Size = new System.Drawing.Size(157, 59);
            this.bt_laylaiMK.TabIndex = 3;
            this.bt_laylaiMK.Text = "Lấy lại mật khẩu";
            this.bt_laylaiMK.UseVisualStyleBackColor = false;
            this.bt_laylaiMK.Click += new System.EventHandler(this.bt_laylaiMK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormDNDKQMK.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1.Location = new System.Drawing.Point(241, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_laylaiMK);
            this.Controls.Add(this.tb_XNEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuenMatKhau";
            this.Text = "QuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_XNEmail;
        private System.Windows.Forms.Button bt_laylaiMK;
    }
}