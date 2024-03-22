using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUII
{
    public partial class FormMenu : Form
    {
        private UserBLL userBLL = new UserBLL();
        public string LoggedInAccountId { get; set; }

        public FormMenu()
        {
            InitializeComponent();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            User user = userBLL.getAccByID(Program.userID);
            if (user != null)
            {
                hoten.Text = user.FullName;
                sdt.Text = user.PhoneNumber;
                sohd.Text = user.SoHD;
                luong.Text = user.Luong.ToString();
                email.Text = user.Email;
                diachi.Text = user.Address;
                hanhd.Text = user.NgayHetHan.ToString("dd/MM/yyyy");
            }
        }
    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
