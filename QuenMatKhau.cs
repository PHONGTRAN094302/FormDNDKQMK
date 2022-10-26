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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();
        private void bt_laylaiMK_Click(object sender, EventArgs e)
        {
            string email = tb_XNEmail.Text;
            if(email.Trim() == "") { MessageBox.Show("Vui lòng nhập email đăng ký!"); }
            else
            {
                string query = "Select * from TaiKhoan where Email = '"+email+"'";
                if(modify.taiKhoans(query).Count!=0)
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật khẩu: "+ modify.taiKhoans(query)[0].MatKhau;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa được đăng ký!";
                }
            }
            }
        }
    }
