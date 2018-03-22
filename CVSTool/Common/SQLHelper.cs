using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVSTool.Common
{
    class SQLHelper
    {
        public static void DataTableToSQLServer(DataTable dt, string connectString)
        {
            string connectionString = connectString;

            try
            {
                //删除已经存在的表
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    SqlCommand sqlStr = new SqlCommand();
                    sqlStr.Connection = sqlConn ;
                    sqlStr.CommandText = @"ALTER TABLE [dbo].[T_ST_RegionInfo] DROP CONSTRAINT [FK_T_ST_Region_T_BD_BuildBaseInfo2]
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

                    sqlStr.ExecuteNonQuery();

                    sqlConn.Close();
                    Console.WriteLine("-----sql 插入：");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" 错误：数据库连接失败，请设置数据库连接..." + ex);
                // ShowLog("错误：数据库连接失败，请设置数据库连接..." + ex.Message);

            }

            using (SqlConnection destinationConnection = new SqlConnection(connectionString))
            {
                destinationConnection.Open();

             
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection))
                {
                    try
                    {
                        bulkCopy.DestinationTableName = "T_ST_RegionInfo";//要插入的表的表名
                        bulkCopy.BatchSize = dt.Rows.Count;
                        //映射字段名 DataTable列名 ,数据库 对应的列名 仪表名称
                        bulkCopy.ColumnMappings.Add("建筑编码", "F_BuildID");
                        bulkCopy.ColumnMappings.Add("上级区域代码", "F_RegionParentID");
                        bulkCopy.ColumnMappings.Add("区域编码", "F_RegionID");
                        bulkCopy.ColumnMappings.Add("区域名称", "F_RegionName");
                        bulkCopy.ColumnMappings.Add("区域包含仪表代码", "F_MeterID");
                        bulkCopy.ColumnMappings.Add("仪表名称", "F_MeterName");
                        bulkCopy.ColumnMappings.Add("运算公式", "F_Operator");
                        bulkCopy.ColumnMappings.Add("百分率", "F_Rate");

                        bulkCopy.WriteToServer(dt);
                        System.Windows.Forms.MessageBox.Show("插入成功");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
