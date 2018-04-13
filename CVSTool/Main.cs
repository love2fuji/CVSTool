using CVSTool.Common;
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

        private void btnBaseDataExport2Excel_Click(object sender, EventArgs e)
        {

        }



        private void btnDataExport2Excel_Click(object sender, EventArgs e)
        {

        }

        private void btnImportRegion_Click(object sender, EventArgs e)
        {
            if (RegionDT.Rows.Count > 0)
            {
                for (int i = 0; i < RegionDT.Rows.Count; i++)
                {
                    string BuildID = RegionDT.Rows[i]["建筑编码"].ToString();
                    string RegionParentID = RegionDT.Rows[i]["上级区域编码"].ToString();
                    string RegionID = RegionDT.Rows[i]["区域编码"].ToString();
                    string RegionName = RegionDT.Rows[i]["区域名称"].ToString();
                    string MeterID = RegionDT.Rows[i]["区域包含仪表代码"].ToString();
                    string Operator = RegionDT.Rows[i]["运算公式"].ToString();
                    int Rate = Convert.ToInt32(RegionDT.Rows[i]["百分率"]);
                    //导入T_ST_Region表
                    string SQLString = @"IF EXISTS (SELECT 1 FROM T_ST_Region WHERE F_RegionID= '" + RegionID + @" ') 
                                            UPDATE T_ST_Region SET F_BuildID = '" + BuildID + @"', F_RegionParentID = '" +
                                            RegionParentID + @"', F_RegionName = '" + RegionName + @"' WHERE F_RegionID = '" + RegionID + @"' 
                                        ELSE
                                            INSERT INTO T_ST_Region
                                            (F_RegionID, F_BuildID, F_RegionParentID, F_RegionName) VALUES
                                               ( '" + RegionID + @"','" + BuildID + @"','" + RegionParentID + @"','" + RegionName + @"') ";

                    SQLHelper.ExecuteSql(SQLString);

                    //导入T_ST_RegionMeter表
                    string SQLString2 = @"IF EXISTS (SELECT 1 FROM T_ST_RegionMeter WHERE F_RegionID= '" + RegionID + @" ' AND F_MeterID='" + MeterID + @" ' ) 
                                            UPDATE T_ST_RegionMeter SET F_Operator = '" + Operator + @"', F_Rate = '" +
                                            Rate + @"'  WHERE F_RegionID = '" + RegionID + @"' AND F_MeterID='" + MeterID + @"';
                                        ELSE
                                            INSERT INTO T_ST_RegionMeter
                                            (F_RegionID, F_MeterID, F_Operator, F_Rate) VALUES
                                               ( '" + RegionID + @"','" + MeterID + @"','" + Operator + @"','" + Rate + @"') ";

                    SQLHelper.ExecuteSql(SQLString2);
                }
                MessageBox.Show("*** 导入区域数据成功！***");
            }
            else
            {
                MessageBox.Show("----导入区域数据失败！ ： 区域数据表为空，请确保数据有效！");
            }



            
        }




        private void btnOpenCSV_Click(object sender, EventArgs e)
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


                //将数据放到表中  
                RegionDT = CSVHelper.OpenCSV(file_path);

                //显示导入的数据
                dgvShowRegion.DataSource = RegionDT;
                tabConServerLog.SelectedTab = tpgRegion;

            }

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
