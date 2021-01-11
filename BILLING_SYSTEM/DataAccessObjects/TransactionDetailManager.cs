using BILLING_SYSTEM.Objects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BILLING_SYSTEM.DataAccessObjects
{
    class TransactionDetailManager
    {
        static string myconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public bool insert(TransactionDetail transaction)
        {
            bool isSuccess = false;

            SqlConnection connection = new SqlConnection(myconnection);

            try
            {
                String sql = "INSERT INTO TRASACTION_DETAILS (product_id, total, rate, qty, dea_cust_id, added_by) VALUES ( @product_id, @total, @rate, @qty, @dea_cust_id, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@dea_cust_id", transaction.customerId);
                cmd.Parameters.AddWithValue("@total", transaction.total);
                cmd.Parameters.AddWithValue("@rate", transaction.rate);
                cmd.Parameters.AddWithValue("@product_id", transaction.productId);
                cmd.Parameters.AddWithValue("@qty", transaction.qty);
                cmd.Parameters.AddWithValue("@added_by", transaction.added_by);

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
    }
}
