using BILLING_SYSTEM.Objects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BILLING_SYSTEM.DataAccessObjects
{
    class UserManager
    {
        static string myconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public bool insert(User user)
        {
            bool isSuccess = false;

            SqlConnection connection = new SqlConnection(myconnection);

            try
            {
                String sql = "INSERT INTO USERS (first_name, last_name, username, password, email_address) VALUES (@first_name, @last_name, @username, @password, @email_address)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@first_name", user.first_name);
                cmd.Parameters.AddWithValue("@last_name", user.last_name);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@email_address", user.email);
                cmd.Parameters.AddWithValue("@username", user.username);

                connection.Open();
                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isSuccess;
        }

        public User getIDFromUserName(string username)
        {
            User user = new User();
            SqlConnection connection = new SqlConnection(myconnection);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id from USERS where username='"+username+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                connection.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    user.id = int.Parse(dt.Rows[0]["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return user;
        }
    }
}
