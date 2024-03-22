using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormLogin : Form
    {
        TaiKhoan tk = new TaiKhoan();
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DangKy fm = new DangKy();
            fm.Show();
            this.Hide();
        }
        private bool CheckLogin()
        {
            tk.taikhoan = user.Text;
            tk.mk = pass.Text;
            string getUser = tkBLL.CheckLogic(tk);
            switch (getUser)
            {
                case "Require_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return false;
                case "Require_matkhau":
                    MessageBox.Show("Tài khoản không được để trống");
                    return false;
                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return false;
            }
            return true;
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            if(CheckLogin())
            {
                MessageBox.Show("Đăng nhập thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void checkBoxHTMK_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxHTMK.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar=true;
            }
        }
    }
}
