using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace FormDNDKQMK
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)//check mk và tentk
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string em)//check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void bt_dangky_Click(object sender, EventArgs e)
        {
            string tentk = tb_TK.Text;
            string matkhau = tb_MK.Text;
            string xnmatkhau = tb_XNMK.Text;
            string email = tb_email.Text;
            if (!checkAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản 6-24 ký tự,với các ký tự chữ và số,chữ hoa và chữ thường!"); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu 6-24 ký tự,với các ký tự chữ và số,chữ hoa và chữ thường!"); return; }
            if (xnmatkhau != matkhau) { MessageBox.Show("Vui lòng nhập mật khẩu chính xác!"); return; }
            if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; }
            if (modify.taiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng ký , vui lòng đăng ký email khác!"); return; }
            try
            {
                string query = "Insert into TaiKhoan values ('" + tentk + ",'" + matkhau + ",'" + email + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tài khoản này đã được đăng kí!,Vui lòng đăng kí tài khoản khác!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
