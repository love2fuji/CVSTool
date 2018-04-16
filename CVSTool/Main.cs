using CVSTool.Common;
using CVSTool.Server;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace CVSTool
{
    public partial class Main : Form
    {
        static string SqlConnectionString = Config.GetValue("MSSQLConnect");
        DataTable RegionDT = new DataTable();
        
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 显示软件运行日志
        /// </summary>
        /// <param name="info"></param>
        private delegate void ShowLogEventHandler(string info);
        public void ShowLog(string info)
        {
            if (this.ServerLog.InvokeRequired)
            {
                ShowLogEventHandler showLogHandler = new ShowLogEventHandler(this.ShowLog);
                this.ServerLog.BeginInvoke(showLogHandler, info);
            }
            else
            {
                string s = "";
                for (int i = 0; i < this.ServerLog.Lines.Length; i++)
                {
                    if (i > 200)
                        break;
                    s += ("\r\n" + this.ServerLog.Lines[i]);
                }
                this.ServerLog.Text = (DateTime.Now.ToString("yyy-MM-dd HH:mm:ss") + " >>>  " + info + s);
            }
        }



        private void btnBaseDataExport2Excel_Click(object sender, EventArgs e)
        {

        }



        private void btnDataExport2Excel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 导入区域基础数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportRegion_Click(object sender, EventArgs e)
        {
            try
            {
                if (0 == RegionServer.ImportRegion(RegionDT))
                {
                    ShowLog("*** 导入区域数据成功！***");
                    MessageBox.Show("*** 导入区域数据成功！***");
                }
                else {
                    ShowLog("Error: 导入区域数据失败！: 区域数据表为空，请确保数据有效！");
                    MessageBox.Show("Error: 导入区域数据失败！: 区域数据表为空，请确保数据有效！");
                }
            }
            catch (Exception ex)
            {
                ShowLog("Error: 导入区域数据失败！" + ex.Message);
                MessageBox.Show("Error: 导入区域数据失败！" + ex.Message);
            }

        }

        /// <summary>
        /// 导入部门基础数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportDepart_Click(object sender, EventArgs e)
        {
             try
            {
                if (0 == DepartmentServer.ImportDepartment(RegionDT))
                {
                    ShowLog("*** 导入部门数据成功！***");
                    MessageBox.Show("*** 导入部门数据成功！***");
                }
                else {
                    ShowLog("Error: 导入部门数据失败！: 部门数据表为空，请确保数据有效！");
                    MessageBox.Show("Error: 导入部门数据失败！: 部门数据表为空，请确保数据有效！");
                }
            }
            catch (Exception ex)
            {
                ShowLog("Error: 导入部门数据失败！" + ex.Message);
                MessageBox.Show("Error: 导入部门数据失败！" + ex.Message);
            }

        }


        private void btnOpenCSV_Click(object sender, EventArgs e)
        {
            try
            {
                /*打开文件选择窗口*/
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "c://";
                openFileDialog.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                /**/
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file_path = openFileDialog.FileName;//记录选择的文件全路径  
                    string file_dir = file_path.Substring(0, file_path.LastIndexOf(Path.DirectorySeparatorChar) + 1);//获取文件目录                    
                    string file_name = openFileDialog.SafeFileName;//获取文件名  
                    string file_exc = file_name.Substring(file_name.LastIndexOf("."), file_name.Length - file_name.LastIndexOf(".")); //获取文件扩展名 

                    ShowLog("打开文件，文件路径：" + file_path);
                    ShowLog("开始读取文件...");
                    //将数据放到表中  
                    RegionDT = CSVHelper.OpenCSV(file_path);
                    ShowLog("读取文件完成");

                    foreach (DataColumn item in RegionDT.Columns)
                    {
                        //columnName = item.ColumnName;
                        if (0 == CheckColumnName(item.ColumnName))
                        {
                            ShowLog("列名：" + item.ColumnName + " -> OK");
                        }
                        else
                        {
                            ShowLog("列名：" + item.ColumnName + " -> 错误，请输入正确的列名称");
                            MessageBox.Show("列名：" + item.ColumnName + " -> 错误，请输入正确的列名称","错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    //显示导入的数据
                    dgvShowRegion.DataSource = RegionDT;
                    tabConServerLog.SelectedTab = tpgRegion;
                }
            }
            catch (Exception ex)
            {
                ShowLog("Error: 打开文件失败！" + ex.Message);
                MessageBox.Show("Error: 打开文件失败！" + ex.Message , "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// 检查导入表格的列名是否正确
        /// </summary>
        /// <param name="columnName">列名</param>
        /// <returns>
        ///     0：列名正确
        ///     1：列名错误，列名不存在
        /// </returns>
        public int CheckColumnName(string columnName)
        {
            switch (columnName)
            {
                case "建筑编码":
                    break;
                case "上级区域编码":
                    break;
                case "区域编码":
                    break;
                case "区域名称":
                    break;
                case "区域包含仪表代码":
                    break;
                case "仪表名称":
                    break;
                case "运算公式":
                    break;
                case "百分率":
                    break;

                default:
                    return 1;
            }
            return 0;
        } 

        /// <summary>
        /// 显示区域基础数据行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvShowRegion_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        
    }
}
