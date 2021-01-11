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
    class DeaCustManager
    {

        static string myconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        public bool insert(DealerCustomer dealerCustomer)
        {
            bool isSuccess = false;

            SqlConnection connection = new SqlConnection(myconnection);

            try
            {
                String sql = "INSERT INTO DEALERS_CUSTOMERS (name, contact, address, type, email) VALUES (@name, @contact, @address, @type, @email)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", dealerCustomer.name);
                cmd.Parameters.AddWithValue("@address", dealerCustomer.address);
                cmd.Parameters.AddWithValue("@contact", dealerCustomer.contact);
                cmd.Parameters.AddWithValue("@email", dealerCustomer.email);
                cmd.Parameters.AddWithValue("@type", dealerCustomer.type);

                connection.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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

            return isSuccess;
        }

        public DealerCustomer search(string keyword)
        {
            SqlConnection connection = new SqlConnection(myconnection);
            DealerCustomer dealerCustomer = new DealerCustomer();

            DataTable dt = new DataTable();

            try
            {

                string sql = "SELECT * FROM DEALERS_CUSTOMERS WHERE name LIKE '%" + keyword + "%' OR type LIKE '%" + keyword + "%' OR id LIKE '%" + keyword + "%'";
                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                connection.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dealerCustomer.id = int.Parse(dt.Rows[0]["id"].ToString());
                    dealerCustomer.name = dt.Rows[0]["name"].ToString();
                    dealerCustomer.email = dt.Rows[0]["email"].ToString();
                    dealerCustomer.contact = dt.Rows[0]["contact"].ToString();
                    dealerCustomer.address = dt.Rows[0]["address"].ToString();
                    dealerCustomer.type= dt.Rows[0]["type"].ToString();
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

            return dealerCustomer;
        }

        public DealerCustomer getDealerCustomerIDFromName(string name)
        {
            DealerCustomer dealer = new DealerCustomer();
            SqlConnection connection = new SqlConnection(myconnection);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id from DEALERS_CUSTOMERS where name = '" + name + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                connection.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dealer.id = int.Parse(dt.Rows[0]["id"].ToString());
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
            return dealer;
        }
    }
}
