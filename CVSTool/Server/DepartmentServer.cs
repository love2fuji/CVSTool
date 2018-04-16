using CVSTool.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVSTool.Server
{
    class DepartmentServer
    {
        public static int ImportDepartment(DataTable RegionDT)
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
                    string SQLString = @"IF EXISTS (SELECT 1 FROM T_ST_DepartmentInfo WHERE F_DepartmentID= '" + RegionID + @" ') 
                                            UPDATE T_ST_DepartmentInfo SET F_BuildID = '" + BuildID + @"', F_DepartParentID = '" +
                                            RegionParentID + @"', F_DepartmentName = '" + RegionName + @"' WHERE F_DepartmentID = '" + RegionID + @"' 
                                        ELSE
                                            INSERT INTO T_ST_DepartmentInfo
                                            (F_DepartmentID, F_BuildID, F_DepartParentID, F_DepartmentName) VALUES
                                               ( '" + RegionID + @"','" + BuildID + @"','" + RegionParentID + @"','" + RegionName + @"') ";

                    SQLHelper.ExecuteSql(SQLString);

                    //导入T_ST_RegionMeter表
                    string SQLString2 = @"IF EXISTS (SELECT 1 FROM T_ST_DepartmentMeter WHERE F_DepartmentID= '" + RegionID + @" ' AND F_MeterID='" + MeterID + @" ' ) 
                                            UPDATE T_ST_DepartmentMeter SET F_Operator = '" + Operator + @"', F_Rate = '" +
                                            Rate + @"'  WHERE F_DepartmentID = '" + RegionID + @"' AND F_MeterID='" + MeterID + @"';
                                        ELSE
                                            INSERT INTO T_ST_DepartmentMeter
                                            (F_DepartmentID, F_MeterID, F_Operator, F_Rate) VALUES
                                               ( '" + RegionID + @"','" + MeterID + @"','" + Operator + @"','" + Rate + @"') ";

                    SQLHelper.ExecuteSql(SQLString2);
                }
                return 0;

            }
            else
            {
                return 1;

            }

        }
    }
}
