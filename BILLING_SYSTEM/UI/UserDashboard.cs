using BILLING_SYSTEM.DataAccessObjects;
using BILLING_SYSTEM.Objects;
using BILLING_SYSTEM.UI;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace BILLING_SYSTEM
{
    public partial class UserDashboard : Form
    {
        TransactionsManager transactionsManager = new TransactionsManager();
        public static bool isSale = false;
        public static bool isPurchase = false;
        public UserDashboard()
        {
            InitializeComponent();
            changeTheAppearanceForMnuStrip();
        }

        

        public void changeTheAppearanceForMnuStrip()
        {
            menuStripUser.BackColor = Color.FromArgb(134, 194, 50);
            menuStripUser.ForeColor = Color.White;
            menuStripUser.Font = new System.Drawing.Font("Calibri", 16);
            menuStripUser.Font = new System.Drawing.Font(menuStripUser.Font, FontStyle.Bold);
            

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isPurchase = true;
            isSale = false;
            salesAndPurchaseFrm purchase = new salesAndPurchaseFrm();
            purchase.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isSale = true;
            isPurchase = false;
            salesAndPurchaseFrm purchase = new salesAndPurchaseFrm();
            purchase.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ProductsForm frm = new ProductsForm();
            frm.Show();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            isPurchase = false;
            isSale = false;
            string upperName = LoginForm.loggedUsername;
            usernameLabel.Text = "HELLO " + upperName.ToUpper();
            System.Data.DataTable dt = transactionsManager.displayAllTransactions();
            invoicesDataGridView.DataSource = dt;
            addTotalToTheGridView();
        }

        private void addTotalToTheGridView()
        {
            invoicesDataGridView[2, invoicesDataGridView.Rows.Count - 1].Value = "TOTAL";
            decimal total = 0;
            decimal vat = 0;
            decimal discount = 0;
            
            for(int i = 0; i < invoicesDataGridView.Rows.Count - 1; i++)
            {
                var value = invoicesDataGridView.Rows[i].Cells[3].Value;
                var value1 = invoicesDataGridView.Rows[i].Cells[4].Value;
                var value2 = invoicesDataGridView.Rows[i].Cells[6].Value;
                if (value != null)
                {
                    total += decimal.Parse(value.ToString());
                    discount += decimal.Parse(value1.ToString());
                    vat += decimal.Parse(value2.ToString());
                }
                
            }

            invoicesDataGridView.Rows[invoicesDataGridView.Rows.Count - 1].Cells[3].Value = total.ToString();
            invoicesDataGridView.Rows[invoicesDataGridView.Rows.Count - 1].Cells[4].Value = discount.ToString();
            invoicesDataGridView.Rows[invoicesDataGridView.Rows.Count - 1].Cells[6].Value = vat.ToString();
        }

        private void transactionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = transactionTypeComboBox.Text;

            System.Data.DataTable dt = transactionsManager.displayTransactionByType(type);
            invoicesDataGridView.DataSource = dt;
            addTotalToTheGridView();
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = transactionsManager.displayAllTransactions();
            invoicesDataGridView.DataSource = dt;
            addTotalToTheGridView();
        }

       

  

        private void printRaportButton_Click_1(object sender, EventArgs e)
        {
            Excel excel = new Excel();
            System.Data.DataTable dt = transactionsManager.displayAllTransactions();
            System.Data.DataTable dt1 = transactionsManager.displayTransactionByType("SALE");
            System.Data.DataTable dt2 = transactionsManager.displayTransactionByType("PURCHASE");
            DataSet set = new DataSet();
            set.Tables.Add(dt);
            set.Tables.Add(dt1);
            set.Tables.Add(dt2);
            set.Tables[0].TableName = "ALL TRANSACTIONS";
            set.Tables[1].TableName = "SALE";
            set.Tables[2].TableName = "PURCHASE";
            bool ok = excel.WriteDataTableToExcel(set, @"C:\Users\andre\source\repos\BILLING_SYSTEM\BILLING_SYSTEM\report.xlsx");

            if (ok == true)
            {
                MessageBox.Show("Report created!");
            }
            else
            {
                MessageBox.Show("Fail!");
            }

            Microsoft.Office.Interop.Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            ex.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = ex.Workbooks.Open(@"C:\Users\andre\source\repos\BILLING_SYSTEM\BILLING_SYSTEM\report.xlsx");

            
        }
    }
}
