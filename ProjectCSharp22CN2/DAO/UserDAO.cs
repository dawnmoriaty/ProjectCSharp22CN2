using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// install bản của next nhá
using BCrypt.Net;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ProjectCSharp22CN2.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ProjectCSharp22CN2.Model;

namespace ProjectCSharp22CN2.Dao
{
    class UserDao
    {
        public UserDao() { }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        private bool VerifyPassword(string enteredPassword, string storedPasswordHash)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedPasswordHash);
        }
        public User? CheckLogin(string username, string password)
        {
            SqlConnection conn = ConnectDB.GetConnection();
            try
            {
                string query = "SELECT Id, UserName, PasswordHash, UserRole FROM Users WHERE UserName = @userName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userName", username);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string storedPasswordHash = reader["PasswordHash"].ToString();

                    // Kiểm tra mật khẩu bằng BCrypt
                    if (VerifyPassword(password, storedPasswordHash))
                    {
                        return new User
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            UserName = reader["UserName"].ToString(),
                            UserRole = reader["UserRole"].ToString()
                        };
                    }
                }
                return null; // Đăng nhập thất bại
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi đăng nhập: " + ex.Message);
                return null;
            }
            finally
            {
                ConnectDB.CloseConnection(conn);
            }
        }
        public string Register(string username, string password, string userRole = "USER")
        {
            SqlConnection conn = ConnectDB.GetConnection();
            try
            {
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE UserName = @userName";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@userName", username);
                int userExists = (int)checkCmd.ExecuteScalar();

                if (userExists > 0)
                {
                    return "Tên đăng nhập đã tồn tại";
                }

                string hashedPassword = HashPassword(password);
                string insertQuery = "INSERT INTO Users (UserName, PasswordHash, UserRole) VALUES (@userName, @password, @userRole)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@userName", username);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@userRole", userRole);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return "Đăng ký thành công";
                }
                else
                {
                    return "Không thể chèn dữ liệu vào cơ sở dữ liệu";
                }
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
            finally
            {
                ConnectDB.CloseConnection(conn);
            }
        }
    }
}