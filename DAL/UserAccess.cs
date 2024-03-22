using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserAccess:DatabaseAccess
    {
        public User getAccByID(int id)
        {
            SqlConnection con = SqlConnectionData.Connect();
            con.Open();
            string query = "SELECT * FROM Users WHERE Id = @id";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                User user = new User();
                user.UserId = reader.GetInt32(0);
                user.Id = reader["Id"].ToString();
                user.Email = reader["Email"].ToString();
                user.Address = reader["Address"].ToString();
                user.FullName = reader["Full_name"].ToString();
                user.SoHD = reader["SoHD"].ToString();
                user.NgayHetHan = Convert.ToDateTime(reader["ngayhethan"]);

                reader.Close();
                con.Close(); // Đóng kết nối sau khi sử dụng

                return user;
            }
            else
            {
                reader.Close();
                con.Close(); // Đóng kết nối sau khi sử dụng
                return null;
            }
        }

    }
}
