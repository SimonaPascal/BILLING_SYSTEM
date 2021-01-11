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
    class ProductManger
    {
        static string myconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public bool insert(Product product)
        {
            bool isSuccess = false;

            SqlConnection connection = new SqlConnection(myconnection);

            try
            {
                String sql = "INSERT INTO PRODUCTS (name, rate, qty, added_by) VALUES (@name, @rate, @qty, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", product.name);
                cmd.Parameters.AddWithValue("@qty", product.qty);
                cmd.Parameters.AddWithValue("@rate", product.rate);
                cmd.Parameters.AddWithValue("@added_by", product.added_by);
            

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

        public Product search(string keyword)
        {
            SqlConnection connection = new SqlConnection(myconnection);
            Product product = new Product();

            DataTable dt = new DataTable();

            try
            {

                string sql = "SELECT * FROM PRODUCTS WHERE name LIKE '%" + keyword + "%' OR id LIKE '%" + keyword + "%'";
                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                connection.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    product.id = int.Parse(dt.Rows[0]["id"].ToString());
                    product.name = dt.Rows[0]["name"].ToString();
                    product.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    product.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
                    product.added_by = int.Parse(dt.Rows[0]["added_by"].ToString());
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

            return product;
        }

        public Product getProductIDFromName(string name)
        {
            Product product = new Product();
            SqlConnection connection = new SqlConnection(myconnection);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id from PRODUCTS where name = '" + name + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                connection.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    product.id = int.Parse(dt.Rows[0]["id"].ToString());
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
            return product;
        }
    }
}
