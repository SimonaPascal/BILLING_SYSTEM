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
    class LoginManager
    {
        
        static string myconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
         
        public bool loginCheck(LoginBLL user)
        {
            bool isSuccess = false;

            SqlConnection connection = new SqlConnection(myconnection);
            try
            {

                string sql = "SELECT * FROM USERS WHERE username = @username AND password = @password";

                SqlCommand cmd = new SqlCommand(sql, connection);

                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@password", user.password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
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

        
    }


}
