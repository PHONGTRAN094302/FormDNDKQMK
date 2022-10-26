using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDNDKQMK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void linkLabel_QMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }
        private void linkLabel_DK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }
        Modify modify = new Modify();
        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            string tentk = tb_taikhoan.Text;
            string matkhau = tb_matkhau.Text;
            if(tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);}
            else if(matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);}
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '"+tentk+"' and MatKhau = '"+matkhau+"'";
                if(modify.taiKhoans(query).Count!=0)
                {
                    MessageBox.Show("Đăng Nhập Thành Công!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên Tài Khoản hoặc mật khẩu không chính xác!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
    }
}
