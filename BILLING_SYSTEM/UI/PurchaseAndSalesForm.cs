using BILLING_SYSTEM.Objects;
using Microsoft.Office.Interop.Word;
using System;
using System.Data;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using System.Collections;
using System.Collections.Generic;
using BILLING_SYSTEM.DataAccessObjects;
using BILLING_SYSTEM.UI;
using System.Transactions;

namespace BILLING_SYSTEM
{
    public partial class salesAndPurchaseFrm : Form
    {
       
        DataTable transactionDataTable = new DataTable();
        List<Product> produse = new List<Product>();

        DeaCustManager deaCustManager = new DeaCustManager();
        DealerCustomer dealer = new DealerCustomer();
        ProductManger productManger = new ProductManger();
        TransactionsManager transactionsManager = new TransactionsManager();


        TransactionDetailManager transactionDetailManager = new TransactionDetailManager();
        
        
        UserManager userManager = new UserManager();

        decimal calculatedVAT = 0;
        decimal calculatedDiscount = 0;



        public salesAndPurchaseFrm()
        {
            InitializeComponent();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addProdButton_Click(object sender, EventArgs e)
        {
            string productName = productNametextBox.Text;
            decimal rate = decimal.Parse(rateTextBox.Text);
            decimal qty = decimal.Parse(qtyTextBox.Text);
            decimal total = rate * qty;


            decimal subTotal = decimal.Parse(subTotalTextBox.Text);
            subTotal = total + subTotal;

            if (productName == "")
            {
                MessageBox.Show("Select the product first. Try Again!");
            }
            else
            {

                transactionDataTable.Rows.Add(productName, rate, qty, total);
                Product product = new Product(productName, rate, qty, total);
                produse.Add(product);
                addedProductsDataGridView.DataSource = transactionDataTable;
                insertProduct(product);
                productSearchTextBox.Text = "";
                productNametextBox.Text = "";
                rateTextBox.Text = "0.00";
                qtyTextBox.Text = "0.00";
                
                subTotalTextBox.Text = subTotal.ToString();

                
            }
        }


        private void insertProduct(Product product)
        {

            product.added_by = (userManager.getIDFromUserName(LoginForm.loggedUsername)).id;

            bool ok = productManger.insert(product);

            if (ok == true)
            {
                MessageBox.Show("Product added successfully!");
            }
            else
            {
                MessageBox.Show("Fail!");
            }
        }

        private void salesAndPurchaseFrm_Load(object sender, EventArgs e)
        {
           
            if (UserDashboard.isSale == true)
            {
                labelFooter.Text = "SALE";
            }
            if (UserDashboard.isPurchase == true)
            {
                labelFooter.Text = "PURCHASE";
            }
            transactionDataTable.Columns.Add("Product Name");
            transactionDataTable.Columns.Add("Rate");
            transactionDataTable.Columns.Add("Quantity");
            transactionDataTable.Columns.Add("Total");
        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            string value = discountTextBox.Text;
            if (value == "")
            {
                MessageBox.Show("Please add discount first!");
            }
            else
            {
                decimal subTotal = decimal.Parse(subTotalTextBox.Text);
                decimal discount = decimal.Parse(discountTextBox.Text);
                decimal grandTotal = ((100 - discount) / 100) * subTotal;
                calculatedDiscount = (discount / 100) * subTotal;
                gradTotalTextBox.Text = grandTotal.ToString();
            }
        }

        private void vatTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal check = decimal.Parse(gradTotalTextBox.Text);
            if (check == 0)
            {
                MessageBox.Show("Calculate the Discount and set the Grand Total first!");
            }
            else
            {
                decimal vat = decimal.Parse(vatTextBox.Text);

                decimal grandTotalWithVAT = ((100 + vat) / 100) * check;
                calculatedVAT = (vat / 100) * check;
                gradTotalTextBox.Text = grandTotalWithVAT.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            createDocument();
            Microsoft.Office.Interop.Word.Application ap = new Microsoft.Office.Interop.Word.Application();
            ap.Visible = true;
            Document doc = ap.Documents.Open(@"C:\Users\andre\source\repos\BILLING_SYSTEM\BILLING_SYSTEM\invoice.docx");

            Objects.Transaction transaction = new Objects.Transaction();
            DealerCustomer dC = deaCustManager.getDealerCustomerIDFromName(nameTextBox.Text.ToString());

            transaction.type = labelFooter.Text;
            transaction.customerId = dC.id;
            transaction.grandTotal = Math.Round(decimal.Parse(gradTotalTextBox.Text), 2);
            transaction.discount = calculatedDiscount;
            transaction.vat = calculatedVAT;
            transaction.date = DateTime.Now;
            MessageBox.Show(LoginForm.loggedUsername);
            MessageBox.Show(((userManager.getIDFromUserName(LoginForm.loggedUsername)).id).ToString());
            User user = new User();
            user = userManager.getIDFromUserName(LoginForm.loggedUsername);
            transaction.added_by = user.id;
            
            bool succes = true;

            using(TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;
                bool w = transactionsManager.insert(transaction, out transactionID);

                for(int i = 0; i < transactionDataTable.Rows.Count; i++)
                {
                    TransactionDetail transactionDetail = new TransactionDetail();
                    Product product = productManger.getProductIDFromName(productNametextBox.Text);
                    transactionDetail.productId = product.id;
                    transactionDetail.qty = decimal.Parse(transactionDataTable.Rows[i][1].ToString());
                    transactionDetail.rate = decimal.Parse(transactionDataTable.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDataTable.Rows[i][3].ToString()), 2);
                    transactionDetail.added_by = (userManager.getIDFromUserName(LoginForm.loggedUsername)).id;
                    transactionDetail.addedDate = DateTime.Now;

                    bool y = transactionDetailManager.insert(transactionDetail);
                    succes = w && y;


                }

                if (succes == true)
                {
                    scope.Complete();
                    MessageBox.Show("Transaction Completed Successfully!");
                    addedProductsDataGridView.DataSource = null;
                    addedProductsDataGridView.Rows.Clear();
                    transactionDataTable.Clear();
                    searchCustomerTextBox.Text = "";
                    contactTextBox.Text = "";
                    addressTextBox.Text = "";
                    emailTextBox.Text = "";
                    nameTextBox.Text = "";
                    subTotalTextBox.Text = "0";
                    gradTotalTextBox.Text = "0";
                    discountTextBox.Text = "0";
                    vatTextBox.Text = "0";
                 }
                else
                {

                }


            }

        }

      

        //Create document method  
        private void createDocument()
        {
            try
            {
                //Create an instance for word app  
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application  
                winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.  
                winword.Visible = false;

                //Create a missing variable for missing value  
                object missing = System.Reflection.Missing.Value;

                //Create a new document  
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //Add header into the document  
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    //Get the header range and add the header details.  
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                    headerRange.Font.Size = 25;
                    headerRange.Text = "INVOICE " + invoiceNumberTextBox.Text + " " + dateTimePickerBillDate.Value;
                }
  
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.  
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 25;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = "BILLING SYSTEM";
                }

                //Add paragraph with Heading 2 style  
                Microsoft.Office.Interop.Word.Paragraph customerHeader = document.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Heading 2";
                customerHeader.Range.set_Style(ref styleHeading2);
                customerHeader.Range.Text = "Customer Details";
                // customerHeader.Range.InsertParagraphAfter();

                createParagraph("Customer: ", nameTextBox.Text.Trim(), document, missing);
                createParagraph("Address: ", addressTextBox.Text.Trim(), document, missing);
                createParagraph("Email Address: ", emailTextBox.Text.Trim(), document, missing);
                createParagraph("Contact: ", contactTextBox.Text.Trim(), document, missing);

                //Add paragraph with Heading 1 style  
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 1";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Text = "                     ";
                para1.Range.InsertParagraphAfter();

                Table firstTable = document.Tables.Add(para1.Range, produse.Count + 1, 4,  ref missing, ref missing);

                firstTable.Borders.Enable = 1;

                createTable(firstTable);

                createTotalDetailsParagraphs("  ", "  ", document, missing, "Heading 1", false);
                createTotalDetailsParagraphs(subTotalTextBox.Text, "Subtotal: ", document, missing, "Heading 3", false);
                createTotalDetailsParagraphs(discountTextBox.Text, "Discount: ", document, missing, "Heading 3", false);
                createTotalDetailsParagraphs(vatTextBox.Text, "VAT(%): ", document, missing, "Heading 3", false);
                createTotalDetailsParagraphs(gradTotalTextBox.Text, "Grand Total: ", document, missing, "Heading 1", true);
                //Save the document  
                object filename = @"C:\Users\andre\source\repos\BILLING_SYSTEM\BILLING_SYSTEM\invoice.docx";
                document.SaveAs2(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Document created successfully !");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void createTable(Table firstTable)
        {
            string[] labels = { "Product Name", "Rate", "Quantity", "Total" };
            foreach (Row row in firstTable.Rows)
            {
                int i = 0;

                foreach (Cell cell in row.Cells)
                {

                    //Header row  
                    if (cell.RowIndex == 1)
                    {
                        cell.Range.Text = labels[i];
                        cell.Range.Font.Bold = 1;
                        //other format properties goes here  
                        cell.Range.Font.Name = "calibri";
                        cell.Range.Font.Size = 10;
                        //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
                        cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                        //Center alignment for the Header cells  
                        cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                        i++;

                    }
                    //Data row  
                    else
                    {

                        Console.WriteLine("Coloana " + cell.ColumnIndex);
                        Console.WriteLine("Rand " + (row.Index));
                        if (cell.ColumnIndex == 1)
                        {
                            cell.Range.Text = produse[row.Index - 2].name;
                        }
                        if (cell.ColumnIndex == 2)
                        {
                            cell.Range.Text = (produse[row.Index - 2].rate).ToString();
                        }
                        if (cell.ColumnIndex == 3)
                        {
                            cell.Range.Text = (produse[row.Index - 2].qty).ToString();
                        }
                        if (cell.ColumnIndex == 4)
                        {
                            cell.Range.Text = (produse[row.Index - 2].total).ToString();
                        }

                    }



                }

            }
        }

        private void createTotalDetailsParagraphs(string textBox, string text, Microsoft.Office.Interop.Word.Document document, object missing, string heading, bool style)
        {
            //Add paragraph with Heading 1 style  

            string paragraf = String.Concat(text, textBox);

            Microsoft.Office.Interop.Word.Paragraph para = document.Content.Paragraphs.Add(ref missing);
            
            object styleHeading1 = heading;
            para.Range.set_Style(ref styleHeading1);
            para.Range.Text = paragraf;
            if (style == true)
            {
                para.Range.Font.Bold = 3;
            }
            para.Range.Font.Color = WdColor.wdColorBlack;
            para.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            para.Range.InsertParagraphAfter();
        }

        private void createParagraph(string text, string textBox, Microsoft.Office.Interop.Word.Document document, object missing)
        {
            //Add paragraph with Heading 1 style  
            string paragraf = String.Concat(text, textBox);

            Microsoft.Office.Interop.Word.Paragraph para = document.Content.Paragraphs.Add(ref missing);
            object styleHeading1 = "Heading 3";
            para.Range.set_Style(ref styleHeading1);
            para.Range.Text = paragraf;
            para.Range.Font.Color = WdColor.wdColorBlack;
            para.Range.InsertParagraphAfter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dealer.address = addressTextBox.Text;
            dealer.contact = contactTextBox.Text;
            dealer.email = emailTextBox.Text;
            dealer.name = emailTextBox.Text;
            dealer.type = dealerCustomerCombo.Text;
            bool ok = deaCustManager.insert(dealer);

            if(ok == true)
            {
                MessageBox.Show("Dealer or customer added successfully!");
            }
            else
            {
                MessageBox.Show("Fail!");
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchCustomerTextBox.Text;

            if(keyword != null)
            {
                DealerCustomer dC= deaCustManager.search(keyword);
                nameTextBox.Text = dC.name;
                addressTextBox.Text = dC.address;
                contactTextBox.Text = dC.contact;
                emailTextBox.Text = dC.email;
                dealerCustomerCombo.Text = dC.type;

            }
        }

        private void productSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = productSearchTextBox.Text;

            if (keyword != null)
            {
                Product prod = productManger.search(keyword);
                productNametextBox.Text = prod.name;
                rateTextBox.Text = prod.rate.ToString();
            }
        }
    }
}
