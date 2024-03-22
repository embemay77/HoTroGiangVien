using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI
{
    public partial class DangKy : Form
    {
        private readonly EmailService _emailService;
        private readonly string _connectionString;

        public DangKy()
        {
            InitializeComponent();
            _emailService = new EmailService();
            _connectionString = SqlConnectionData.GetConnectionString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string to = user.Text;
            string pass = mk.Text;

            // Kiểm tra tính hợp lệ của địa chỉ email
            if (!IsValidEmail(to))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int index = user.Text.IndexOf('@');
                string id = user.Text.Substring(0, index);
                string content = $"TaiKhoan: {id}\nMatKhau: {pass}";
                _emailService.SendEmail(to, "Kích hoạt tài khoản", content);
                SaveRegistrationData(id, pass);
                MessageBox.Show("Email gửi thành công.Vui lòng  kiểm tra lại mail để kích hoạt tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLogin fm = new FormLogin();
                fm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gửi email thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void SaveRegistrationData(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO TaiKhoan (id, mk) VALUES (@Username, @Password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
