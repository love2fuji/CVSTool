using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVSTool.Common
{
    class ExcelHelper
    {
        /// <summary>
        /// 报警记录导出到Excel表格
        /// </summary>
        /// <param name="dt"></param>
        public static void ExportToExcel(System.Data.DataTable dt)
        {
            //导出到execl  
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "导出Excel (*.xls)|*.xls";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.CreatePrompt = false;
                saveFileDialog.Title = "导出文件保存路径";
                saveFileDialog.ShowDialog();
                string strName = saveFileDialog.FileName;
                if (strName.Length != 0)
                {
                    //没有数据的话就不往下执行  
                    if (dt.Rows.Count == 0)
                        return;

                    //toolStripProgressBar1.Visible = true;
                    System.Reflection.Missing miss = System.Reflection.Missing.Value;
                    //实例化一个Excel.Application对象  
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Application.Workbooks.Add(true);
                    excel.Visible = false;//若是true，则在导出的时候会显示EXcel界面。
                    //设置禁止弹出保存和覆盖的询问提示框   
                    excel.DisplayAlerts = false;
                    excel.AlertBeforeOverwriting = true;
                    if (excel == null)
                    {
                        MessageBox.Show("EXCEL无法启动！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Microsoft.Office.Interop.Excel.Workbooks books = (Microsoft.Office.Interop.Excel.Workbooks)excel.Workbooks;
                    Microsoft.Office.Interop.Excel.Workbook book = (Microsoft.Office.Interop.Excel.Workbook)(books.Add(miss));
                    Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                    sheet.Name = "报警记录";
                    int m = 0, n = 0;


                    //生成Excel中列头名称  
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        excel.Cells[1, i + 1] = dt.Columns[i].ColumnName;//输出DataGridView列头名  
                    }

                    //把DataGridView当前页的数据保存在Excel中  
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)//控制Excel中行，上下的距离，就是可以到Excel最下的行数，比数据长了报错，比数据短了会显示不完  
                        {
                            for (int j = 0; j < dt.Columns.Count; j++)//控制Excel中列，左右的距离，就是可以到Excel最右的列数，比数据长了报错，比数据短了会显示不完  
                            {
                                string str = dt.Rows[i][j].ToString();
                                excel.Cells[i + 2, j + 1] = "'" + str;//i控制行，从Excel中第2行开始输出第一行数据，j控制列，从Excel中第1列输出第1列数据，"'" +是以string形式保存，所以遇到数字不会转成16进制  
                            }
                        }
                    }
                    sheet.SaveAs(strName, miss, miss, miss, miss, miss, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, miss, miss, miss);
                    book.Close(false, miss, miss);
                    books.Close();
                    excel.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(book);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(books);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);

                    GC.Collect();
                    MessageBox.Show("数据已经成功导出!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // toolStripProgressBar1.Value = 0;  
                    System.Diagnostics.Process.Start(strName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
            }
        }
    }
}
