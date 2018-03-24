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

        public Main()
        {
            InitializeComponent();
        }

        private void btnExport2Excel_Click(object sender, EventArgs e)
        {

        }

       

        private void btnDataExport2Excel_Click(object sender, EventArgs e)
        {

        }

        private void btnImportRegion_Click(object sender, EventArgs e)
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

                //创建一个空表  
                DataTable dt = new DataTable();
                //将数据放到空表中  
                dt = CSVHelper.OpenCSV(file_path);
                //显示导入的数据
                dgrSendMsgLog.DataSource = dt;
                CSVToSQLServer(dt);

            }
        }

        void CSVToSQLServer(DataTable dt)
        {
            //创建表 T_ST_RegionInfo
            string SQLString = @"ALTER TABLE [dbo].[T_ST_RegionInfo] DROP CONSTRAINT [FK_T_ST_Region_T_BD_BuildBaseInfo2]
                                            IF EXISTS(Select 1 From Sysobjects Where Name='T_ST_RegionInfo')   
                                                  DROP TABLE T_ST_RegionInfo   
                                             SET ANSI_NULLS ON
                                             SET QUOTED_IDENTIFIER ON
                                             SET ANSI_PADDING ON
                                            CREATE TABLE [dbo].[T_ST_RegionInfo](
	                                            [F_BuildID] [varchar](16) NOT NULL,
	                                            [F_RegionParentID] [varchar](20) NOT NULL,
	                                            [F_RegionID] [varchar](20) NOT NULL,
	                                            [F_RegionName] [nvarchar](20) NOT NULL,
	                                            [F_MeterID] [varchar](20) NOT NULL,
	                                            [F_MeterName] [varchar](50) NULL,
	                                            [F_Operator] [varchar](10) NOT NULL,
	                                            [F_Rate] [decimal](10, 2) NOT NULL
                                            ) ON [PRIMARY]
                                             SET ANSI_PADDING OFF
                                             ALTER TABLE [dbo].[T_ST_RegionInfo]  WITH NOCHECK ADD  CONSTRAINT [FK_T_ST_Region_T_BD_BuildBaseInfo2] FOREIGN KEY([F_BuildID]) 
                                               REFERENCES [dbo].[T_BD_BuildBaseInfo] ([F_BuildID])
                                             ALTER TABLE [dbo].[T_ST_RegionInfo] CHECK CONSTRAINT [FK_T_ST_Region_T_BD_BuildBaseInfo2]
                                            ";
            string SQLStringRegion = @"DELETE FROM T_ST_RegionMeter
                                       DELETE FROM T_ST_Region
                                       INSERT INTO T_ST_Region 
	                                        SELECT F_RegionID, MAX(F_BuildID) AS F_BuildID
			                                       ,MAX( F_RegionParentID) AS F_RegionParentID
			                                       ,MAX( F_RegionName) AS F_RegionName
	                                          FROM T_ST_RegionInfo 
	                                          GROUP BY F_RegionID";

            string SQLStringRegionMeter = @"INSERT INTO T_ST_RegionMeter
	                                        SELECT F_RegionID, F_MeterID, F_Operator, F_Rate
	                                        FROM T_ST_RegionInfo ";

            //创建表 T_ST_RegionInfo
            SQLHelper.ExecuteSql(SQLString);
            //将数据插入RegionInfo表
            SQLHelper.DataTableToSQLServer(dt);
            //将数据插入Region表
            SQLHelper.ExecuteSql(SQLStringRegion);
            //将数据插入RegionMeter表
            SQLHelper.ExecuteSql(SQLStringRegionMeter);

        }
    }
}
