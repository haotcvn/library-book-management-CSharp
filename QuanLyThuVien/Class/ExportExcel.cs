using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Class
{
    class ExportExcel
    {
        public void ToExcel(DataGridView dgv, string path, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            try
            {
                //Tạo mới một Excel WorkBook 

                oExcel.Visible = false;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                oSheet.Name = "Sheet1";

                // Tạo phần Tiêu đề
                Microsoft.Office.Interop.Excel.Range head = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[1,1];
                head.Value2 = title;
                head.MergeCells = true;
                head.Font.Bold = true;
                head.Font.Name = "Times New Roman";
                head.Font.Size = "13";
                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                
                // Tạo tiêu đề cột 
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    oSheet.Cells[2, i + 1] = dgv.Columns[i].HeaderText;

                    Microsoft.Office.Interop.Excel.Range rowHead = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[2, i + 1];
                    rowHead.Font.Name = "Times New Roman";
                    rowHead.Font.Size = "13";
                    rowHead.Font.Bold = true;
                    rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                    rowHead.Interior.ColorIndex = 6;
                    rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                }

                // Content
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        if (dgv.Rows[i].Cells[j].Value != null)
                        {
                            oSheet.Cells[i + 3, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();

                            Microsoft.Office.Interop.Excel.Range rowContent = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[i+3, j+1];
                            rowContent.Font.Name = "Times New Roman";
                            rowContent.Font.Size = "13";
                            rowContent.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                            rowContent.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        }
                    }
                }

                // save workbook
                oExcel.Columns.AutoFit();
                oBook.SaveAs(path);
                oBook.Close();
                oExcel.Quit();
                MessageBox.Show("Xuất file thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                oBook = null;
                oSheet = null; ;
            }
        }
    }
}
