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
        public static string connectionString = Config.GetValue("MSSQLConnect");
        public static void CreatTable()
        {

        }


        /// <summary>
        /// 表是否存在
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public static bool TabExists(string TableName)
        {
            string strsql = "SELECT COUNT(*) FROM sysobjects WHERE id = object_id(N'[" + TableName + "]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1";
            //string strsql = "SELECT count(*) FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[" + TableName + "]') AND type in (N'U')";
            object obj = GetSingle(strsql);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        cmd.CommandTimeout = 100;
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }


        /// <summary>
        /// 将数据导入表中T_ST_RegionInfo
        /// </summary>
        /// <param name="dt"></param>
        public static void DataTableToSQLServer(DataTable dt)
        {
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


        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public static object GetSingle(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = cmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }
    }

}
