using CVSTool.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVSTool.Server
{
    class RegionServer
    {
        public static int ImportRegion(DataTable RegionDT)
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
                return 0; 
               
            }
            else
            {
                return 1;
               
            }

        }
    }
}
