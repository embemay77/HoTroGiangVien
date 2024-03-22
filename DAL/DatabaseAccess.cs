using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {
        public static string GetConnectionString()
        {
            return "Data Source=BAOHAN;Initial Catalog=HoTroGiangVien;Integrated Security=True;";
        }
        public static SqlConnection Connect()
        {
            string conStr = GetConnectionString();
            SqlConnection con = new SqlConnection(conStr);
            return con;
        }
    }
    public class DatabaseAccess
    {
        public static string CheckLogicDTO(TaiKhoan tk)
        {
            string user = null;
            SqlConnection con = SqlConnectionData.Connect();
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_logic", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", tk.taikhoan);
            cmd.Parameters.AddWithValue("@pass", tk.mk);
            ///phân quyền.....code sao
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                }

                reader.Close();
                con.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
            return user;

        }
       

    }
}
