using BILLING_SYSTEM.Objects;
using BILLING_SYSTEM.UI;
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
    class TransactionsManager
    {
        static string myconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        #region Insert

        public bool insert(Transaction transaction, out int transactionID)
        {
            bool isSuccess = false;
            transactionID = -1;
            SqlConnection connection = new SqlConnection(myconnection);

            try
            {
                String sql = "INSERT INTO TRANSACTIONS (type, dea_cust_id, grand_total, date, discount, tax, added_by) VALUES (@type, @dea_cust_id, @grand_total, @date, @discount, @tax, @added_by); SELECT @@IDENTITY;";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@dea_cust_id", transaction.customerId);
                cmd.Parameters.AddWithValue("@grand_total", transaction.grandTotal);
                cmd.Parameters.AddWithValue("@date", transaction.date);
                cmd.Parameters.AddWithValue("@discount", transaction.discount);
                cmd.Parameters.AddWithValue("@type", transaction.type);
                cmd.Parameters.AddWithValue("@tax", transaction.vat);
                cmd.Parameters.AddWithValue("@added_by", transaction.added_by);

                connection.Open();
                object o = cmd.ExecuteScalar();

                if (o != null)
                {
                    transactionID = int.Parse(o.ToString());
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
        #endregion

        public DataTable displayAllTransactions()
        {
            SqlConnection connection = new SqlConnection(myconnection);

            DataTable dt = new DataTable();

            UserManager user = new UserManager();

            try
            {

                string sql = "SELECT * FROM TRANSACTIONS WHERE added_by  = '" + (user.getIDFromUserName(LoginForm.loggedUsername)).id+"'";
                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                connection.Open();

                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public DataTable displayTransactionByType(string type)
        {
            SqlConnection connection = new SqlConnection(myconnection);

            DataTable dt = new DataTable();
            UserManager user = new UserManager();
            try
            {

                string sql = "SELECT * FROM TRANSACTIONS WHERE type='"+type+ "' AND added_by = '" + (user.getIDFromUserName(LoginForm.loggedUsername)).id + "'";
                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                connection.Open();

                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
    }
}
