using CVSTool.Common;
using CVSTool.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CVSTool
{
    public partial class Main : Form
    {
        static string SqlConnectionString = Config.GetValue("MSSQLConnect");
        DataTable RegionDT = new DataTable();
        DataTable BuildInfo = new DataTable();
        bool comboxFirstLoad = true;

        public Main()
        {
            InitializeComponent();
            AddData2Combox();
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



        private void btnDepartmentDataExport2CSV_Click(object sender, EventArgs e)
        {
            try
            {
                string buildName = cboxBiuldInfo.GetItemText(cboxBiuldInfo.Items[cboxBiuldInfo.SelectedIndex]);
                string buildID = cboxBiuldInfo.GetItemText(cboxBiuldInfo.SelectedValue);
                ShowLog("选择要导出的建筑物为：" + buildName + "  建筑代码：" + buildID);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                //打开的文件选择对话框上的标题
                saveFileDialog.Title = "请选择文件";
                //设置文件类型
                saveFileDialog.Filter = "文本文件(*.csv)|*.csv|所有文件(*.*)|*.*";
                //设置默认文件类型显示顺序
                saveFileDialog.FilterIndex = 1;
                //保存对话框是否记忆上次打开的目录
                saveFileDialog.RestoreDirectory = true;
                //设置是否允许多选
                //saveFileDialog.Multiselect = false;
                //按下确定选择的按钮
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //获得文件路径
                    string localFilePath = saveFileDialog.FileName.ToString();
                    //获取文件路径，不带文件名
                    //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));

                    CSVHelper.SaveToCSV(ExportServer.ExportDepartmentData(buildID), localFilePath);
                    ShowLog("*** 导出数据成功！***");
                    MessageBox.Show("*** 导出数据成功！***", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowLog("Error: 导出数据失败！" + ex.Message);
                MessageBox.Show("Error:  导出数据失败！" + ex.Message);
            }

        }


        private void btnRegionDataExport2CSV_Click(object sender, EventArgs e)
        {
            try
            {
                string buildName = cboxBiuldInfo.GetItemText(cboxBiuldInfo.Items[cboxBiuldInfo.SelectedIndex]);
                string buildID = cboxBiuldInfo.GetItemText(cboxBiuldInfo.SelectedValue);
                ShowLog("选择要导出的建筑物为：" + buildName + "  建筑代码：" + buildID);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                //打开的文件选择对话框上的标题
                saveFileDialog.Title = "请选择文件";
                //设置文件类型
                saveFileDialog.Filter = "文本文件(*.csv)|*.csv|所有文件(*.*)|*.*";
                //设置默认文件类型显示顺序
                saveFileDialog.FilterIndex = 1;
                //保存对话框是否记忆上次打开的目录
                saveFileDialog.RestoreDirectory = true;
                //设置是否允许多选
                //saveFileDialog.Multiselect = false;
                //按下确定选择的按钮
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //获得文件路径
                    string localFilePath = saveFileDialog.FileName.ToString();
                    //获取文件路径，不带文件名
                    //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));

                    CSVHelper.SaveToCSV(ExportServer.ExportRegionData(buildID), localFilePath);
                    ShowLog("*** 导出区域数据成功！***");
                    MessageBox.Show("*** 导出区域数据成功！***", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowLog("Error: 导出区域数据失败！" + ex.Message);
                MessageBox.Show("Error:  导出区域数据失败！" + ex.Message);
            }

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
                else
                {
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
                else
                {
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

        /// <summary>
        /// 打开CSV文件，并检查是否正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenCSV_Click(object sender, EventArgs e)
        {
            try
            {
                /*打开文件选择窗口*/
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "c://";
                openFileDialog.Filter = "文本文件|*.csv|C#文件|*.cs|所有文件|*.*";
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
                        if (0 == CheckColumnName(item.ColumnName))
                        {
                            ShowLog("列名：" + item.ColumnName + " -> OK");
                        }
                        else
                        {
                            ShowLog("列名：" + item.ColumnName + " -> 错误，请输入正确的列名称");
                            MessageBox.Show("列名：" + item.ColumnName + " -> 错误，请输入正确的列名称", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    //显示导入CSV文件的数据
                    dgvShowRegion.DataSource = RegionDT;
                    tabConServerLog.SelectedTab = tpgRegion;


                    //检查建筑编码，仪表代码数据是否正确
                    if (RegionDT.Rows.Count > 0)
                    {
                        ShowLog("开始检查 基础数据...");
                        for (int i = 0; i <= RegionDT.Rows.Count - 1; i++)
                        {
                            string BuildID = RegionDT.Rows[i]["建筑编码"].ToString();
                            string MeterID = RegionDT.Rows[i]["包含仪表代码"].ToString();
                            if (!string.IsNullOrEmpty(MeterID))
                            {
                                if (ExportServer.CheckData(BuildID, MeterID) == 0)
                                {
                                    //数据有误，禁止导入
                                    btnImportRegion.Enabled = false;
                                    btnImportDepart.Enabled = false;
                                    btnEnergyItemImport.Enabled = false;
                                    int row = i + 1;
                                    ShowLog("第" + row + "行建筑编码：" + BuildID + "或 仪表编码：" + MeterID + " 不存在，请输入正确的建筑编码和仪表编码");
                                    MessageBox.Show("第" + row + "行建筑编码：" + BuildID + "或 仪表编码：" + MeterID + " 不存在，请输入正确的建筑编码和仪表编码", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                        //数据正确，可以导入
                        btnImportRegion.Enabled = true;
                        btnImportDepart.Enabled = true;
                        btnEnergyItemImport.Enabled = true;
                        ShowLog("检查基础数据完成，数据正确");

                    }
                }
            }
            catch (Exception ex)
            {
                ShowLog("Error: 打开文件失败！" + ex.Message);
                MessageBox.Show("Error: 打开文件失败！" + ex.Message, "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                case "上级区域(部门)编码":
                    break;
                case "区域(部门)编码":
                    break;
                case "区域(部门)名称":
                    break;
                case "包含仪表代码":
                    break;
                case "仪表名称":
                    break;
                case "一级分项编码":
                    break;
                case "二级分项编码":
                    break;
                case "三级分项编码":
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

        private void Main_Load(object sender, EventArgs e)
        {
            //禁止导入
            btnImportRegion.Enabled = false;
            btnImportDepart.Enabled = false;
            btnEnergyItemImport.Enabled = false;



        }

        private void AddData2Combox()
        {
            BuildInfo = ExportServer.GetBuildInfo();
            cboxBiuldInfo.DataSource = BuildInfo;
            cboxBiuldInfo.DisplayMember = BuildInfo.Columns[1].ColumnName;
            cboxBiuldInfo.ValueMember = BuildInfo.Columns[0].ColumnName;

        }



        private void btnBaseDataExport_Click(object sender, EventArgs e)
        {
            try
            {
                string buildName = cboxBiuldInfo.GetItemText(cboxBiuldInfo.Items[cboxBiuldInfo.SelectedIndex]);
                string buildID = cboxBiuldInfo.GetItemText(cboxBiuldInfo.SelectedValue);
                ShowLog("选择要导出的建筑物为：" + buildName + "  建筑代码：" + buildID);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                //打开的文件选择对话框上的标题
                saveFileDialog.Title = "请选择文件";
                //设置文件类型
                saveFileDialog.Filter = "文本文件(*.csv)|*.csv|所有文件(*.*)|*.*";
                //设置默认文件类型显示顺序
                saveFileDialog.FilterIndex = 1;
                //保存对话框是否记忆上次打开的目录
                saveFileDialog.RestoreDirectory = true;
                //设置是否允许多选
                //saveFileDialog.Multiselect = false;
                //按下确定选择的按钮
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //获得文件路径
                    string localFilePath = saveFileDialog.FileName.ToString();
                    //获取文件路径，不带文件名
                    //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));

                    CSVHelper.SaveToCSV(ExportServer.ExportBaseData(buildID), localFilePath);
                    ShowLog("*** 导出基础数据成功！***");
                    MessageBox.Show("*** 导出基础数据成功！***", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowLog("Error: 导出基础数据失败！" + ex.Message);
                MessageBox.Show("Error:  导出基础数据失败！" + ex.Message);
            }
        }

        private void cboxBiuldInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxFirstLoad)
            {
                comboxFirstLoad = false;
                return;
            }
            string buildName = cboxBiuldInfo.GetItemText(cboxBiuldInfo.Items[cboxBiuldInfo.SelectedIndex]);
            string buildID = cboxBiuldInfo.GetItemText(cboxBiuldInfo.SelectedValue);

            ShowLog("选择要导出的建筑物为：" + buildName + "  建筑代码：" + buildID);
        }

        private void btnEnergyDataExport_Click(object sender, EventArgs e)
        {
            try
            {
                string buildName = cboxBiuldInfo.GetItemText(cboxBiuldInfo.Items[cboxBiuldInfo.SelectedIndex]);
                string buildID = cboxBiuldInfo.GetItemText(cboxBiuldInfo.SelectedValue);
                ShowLog("选择要导出的建筑物为：" + buildName + "  建筑代码：" + buildID);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                //打开的文件选择对话框上的标题
                saveFileDialog.Title = "请选择文件";
                //设置文件类型
                saveFileDialog.Filter = "文本文件(*.csv)|*.csv|所有文件(*.*)|*.*";
                //设置默认文件类型显示顺序
                saveFileDialog.FilterIndex = 1;
                //保存对话框是否记忆上次打开的目录
                saveFileDialog.RestoreDirectory = true;
                //设置是否允许多选
                //saveFileDialog.Multiselect = false;
                //按下确定选择的按钮
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //获得文件路径
                    string localFilePath = saveFileDialog.FileName.ToString();
                    //获取文件路径，不带文件名
                    //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));

                    CSVHelper.SaveToCSV(ExportServer.ExportEnergyData(buildID), localFilePath);
                    ShowLog("*** 导出能耗基础数据成功！***");
                    MessageBox.Show("*** 导出能耗基础数据成功！***", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowLog("Error: 导出能耗基础数据失败！" + ex.Message);
                MessageBox.Show("Error:  导出能耗基础数据失败！" + ex.Message);
            }
        }

        private void btnEnergyItemImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (0 == EnergyItemServer.ImportEnergyItem(RegionDT))
                {
                    ShowLog("*** 导入分项数据成功！***");
                    MessageBox.Show("*** 导入分项数据成功！***");
                }
                else
                {
                    ShowLog("Error: 导入分项 数据失败！: 分项数据表为空，请确保数据有效！");
                    MessageBox.Show("Error: 导入 分项 数据失败！: 分项数据表为空，请确保数据有效！");
                }
            }
            catch (Exception ex)
            {
                ShowLog("Error: 导入分项数据失败！" + ex.Message);
                MessageBox.Show("Error: 导入分项数据失败！" + ex.Message);
            }
        }
    }
}
