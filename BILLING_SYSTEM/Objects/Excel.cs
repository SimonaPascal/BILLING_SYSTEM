using Microsoft.Office.Interop.Excel;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;


namespace BILLING_SYSTEM.Objects
{
    class Excel
    {
        public object ExcelTotalsCalculation { get; private set; }

        public bool WriteDataTableToExcel( System.Data.DataSet dataSet, string path)
        {
            

            try
           {
                
                //release objects
                
                int inHeader = 3, inColumn = 0, inRow = 0;
                //  get Application object.
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
               

                excel.DisplayAlerts = false;
                System.Reflection.Missing Default = System.Reflection.Missing.Value;
                // Creation a new Workbook
                Microsoft.Office.Interop.Excel.Workbook  excelworkBook = excel.Workbooks.Add(1);
                

                foreach (System.Data.DataTable dataTable in dataSet.Tables)
                {
                    Microsoft.Office.Interop.Excel.Worksheet excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.Sheets.Add(Default, excelworkBook.Sheets[excelworkBook.Sheets.Count], 1, Default);
                    excelSheet.Name = dataTable.TableName;

                    for(int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        excelSheet.Cells[inHeader + 1, i + 1] = dataTable.Columns[i].ColumnName.ToUpper(); 
                    }

                    for(int m = 0; m <dataTable.Rows.Count; m++)
                    {
                        for(int n = 0; n < dataTable.Columns.Count; n++)
                        {
                            inColumn = n + 1;
                            inRow = inHeader + 2 + m;
                            excelSheet.Cells[inRow, inColumn] = dataTable.Rows[m].ItemArray[n];
                            
                            if(m % 2 == 0)
                            {
                                excelSheet.get_Range("A" + inRow.ToString(), "H" + inRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.FromHtml("#6B6E70");
                            }
                            else
                            {
                                excelSheet.get_Range("A" + inRow.ToString(), "H" + inRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.FromHtml("#474B4F");
                            }
                        }
                    }

                    Range cellRang = excelSheet.get_Range("A4", "H4");
                    cellRang.Interior.Color = System.Drawing.ColorTranslator.FromHtml("#86C232");
                    cellRang.Font.Color = System.Drawing.ColorTranslator.FromHtml("#222629");
                    cellRang.Font.Bold = true;
                    cellRang.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    cellRang.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    cellRang.Font.Size = 16;
                    excelSheet.get_Range("D4").EntireColumn.NumberFormat = "0.00";
                    excelSheet.Columns.AutoFit();
                    Range rg = excelSheet.Cells[2, 8];
                    rg.EntireColumn.NumberFormat = "MM/DD/YYYY";

          

                }
                

              

               


                Microsoft.Office.Interop.Excel.Worksheet lastSheet = excelworkBook.Sheets[1];
                lastSheet.Delete();
                excel.DisplayAlerts = true;
                excel.Visible = false;

                (excelworkBook.Sheets[1] as Microsoft.Office.Interop.Excel.Worksheet).Activate();
                excelworkBook.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, _Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing,
                   Type.Missing, Type.Missing);
                excelworkBook.Close();
                excel.Quit();

                return true;
           }
           catch (Exception ex)
            { 
               MessageBox.Show(ex.Message);
               return false;
            }
            finally
           {
                
               
           }
        }

        public void openExcel()
        {

        }

       
    }
}
