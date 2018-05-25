using CVSTool.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CVSTool.Server
{
    class EnergyItemServer
    {
        public static int ImportEnergyItem(DataTable RegionDT)
        {
            if (RegionDT.Rows.Count > 0)
            {
                for (int i = 0; i < RegionDT.Rows.Count; i++)
                {
                    string BuildID = RegionDT.Rows[i]["建筑编码"].ToString();
                    string EnergyItem1 = RegionDT.Rows[i]["一级分项编码"].ToString();
                    string EnergyItem2 = RegionDT.Rows[i]["二级分项编码"].ToString();
                    string EnergyItem3 = RegionDT.Rows[i]["三级分项编码"].ToString();
                    string MeterID = RegionDT.Rows[i]["包含仪表代码"].ToString();
                    string Operator = RegionDT.Rows[i]["运算公式"].ToString();
                    string Rate = RegionDT.Rows[i]["百分率"].ToString();
                    //导入T_ST_CalcFormulaMeter表
                    if (!string.IsNullOrEmpty(EnergyItem1))
                    {
                        string SQLString = @"IF EXISTS (SELECT 1 FROM T_ST_CalcFormulaMeter WHERE F_FormulaID= '" + EnergyItem1 + @"' AND F_MeterID='"+ MeterID+ @"') 
                                            UPDATE T_ST_CalcFormulaMeter SET F_Operator = '" + Operator + @"', F_Rate = " +
                                            Rate + @"  WHERE F_FormulaID = '" + EnergyItem1 + @"' AND F_MeterID='" + MeterID + @"'; 
                                        ELSE
                                            INSERT INTO T_ST_CalcFormulaMeter
                                            (F_FormulaID, F_MeterID, F_Operator, F_Rate ) VALUES
                                            ( '" + EnergyItem1 + @"','" + MeterID + @"','" + Operator + @"'," + Rate + @") ";

                        SQLHelper.ExecuteSql(SQLString);
                    }

                    if (!string.IsNullOrEmpty(EnergyItem2))
                    {
                        string SQLString2 = @"IF EXISTS (SELECT 1 FROM T_ST_CalcFormulaMeter WHERE F_FormulaID= '" + EnergyItem2 + @"' AND F_MeterID='" + MeterID + @"') 
                                            UPDATE T_ST_CalcFormulaMeter SET F_Operator = '" + Operator + @"', F_Rate = " +
                                            Rate + @"  WHERE F_FormulaID = '" + EnergyItem2 + @"' AND F_MeterID='" + MeterID + @"'; 
                                        ELSE
                                            INSERT INTO T_ST_CalcFormulaMeter
                                            (F_FormulaID, F_MeterID, F_Operator, F_Rate ) VALUES
                                            ( '" + EnergyItem2 + @"','" + MeterID + @"','" + Operator + @"'," + Rate + @") ";

                        SQLHelper.ExecuteSql(SQLString2);
                    }

                    if (!string.IsNullOrEmpty(EnergyItem3))
                    {
                        string SQLString3 = @"IF EXISTS (SELECT 1 FROM T_ST_CalcFormulaMeter WHERE F_FormulaID= '" + EnergyItem3 + @"' AND F_MeterID='" + MeterID + @"') 
                                            UPDATE T_ST_CalcFormulaMeter SET F_Operator = '" + Operator + @"', F_Rate = " +Rate + 
                                                @" WHERE F_FormulaID = '" + EnergyItem3 + @"' AND F_MeterID='" + MeterID + @"'; 
                                        ELSE
                                            INSERT INTO T_ST_CalcFormulaMeter
                                            (F_FormulaID, F_MeterID, F_Operator, F_Rate ) VALUES
                                            ( '" + EnergyItem3 + @"','" + MeterID + @"','" + Operator + @"'," + Rate + @") ";

                        SQLHelper.ExecuteSql(SQLString3);
                    }



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
