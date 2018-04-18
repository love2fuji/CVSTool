using CVSTool.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVSTool.Server
{
    class ExportServer
    {
        public static DataTable ExportDepartmentData()
        {
            string SQLString = @"SELECT T_ST_DepartmentInfo.F_BuildID AS '建筑编码'
		                                ,F_DepartParentID AS '上级区域(部门)编码'
		                                ,T_ST_DepartmentInfo.F_DepartmentID AS '区域(部门)编码'
		                                ,T_ST_DepartmentInfo.F_DepartmentName AS '区域(部门)名称'
		                                ,T_ST_DepartmentMeter.F_MeterID AS '区域(部门)包含仪表代码'
		                                ,F_MeterName AS '仪表名称'
		                                ,T_ST_DepartmentMeter.F_Operator AS '运算公式'
		                                ,T_ST_DepartmentMeter.F_Rate AS '百分率' 
                                  FROM T_ST_MeterUseInfo
	                                INNER JOIN T_ST_DepartmentMeter ON T_ST_DepartmentMeter.F_MeterID=T_ST_MeterUseInfo.F_MeterID
	                                INNER JOIN T_ST_DepartmentInfo ON T_ST_DepartmentInfo.F_DepartmentID=T_ST_DepartmentMeter.F_DepartmentID
                                  ORDER BY T_ST_DepartmentInfo.F_BuildID ,T_ST_DepartmentInfo.F_DepartmentID,T_ST_DepartmentMeter.F_MeterID";

            DataTable DT = new DataTable();
            DT=SQLHelper.GetDataTable(SQLString);

            return DT;

        }

        public static DataTable ExportRegionData()
        {
            string SQLString = @" SELECT T_ST_Region.F_BuildID AS '建筑编码'
		                                ,F_RegionParentID AS '上级区域(部门)编码'
		                                ,T_ST_Region.F_RegionID AS '区域(部门)编码'
		                                ,T_ST_Region.F_RegionName AS '区域(部门)名称'
		                                ,T_ST_RegionMeter.F_MeterID AS '区域(部门)包含仪表代码'
		                                ,F_MeterName AS '仪表名称'
		                                ,T_ST_RegionMeter.F_Operator AS '运算公式'
		                                ,T_ST_RegionMeter.F_Rate AS '百分率' 
                                  FROM T_ST_MeterUseInfo
	                                INNER JOIN T_ST_RegionMeter ON T_ST_RegionMeter.F_MeterID=T_ST_MeterUseInfo.F_MeterID
	                                INNER JOIN T_ST_Region ON T_ST_Region.F_RegionID=T_ST_RegionMeter.F_RegionID
                                  ORDER BY T_ST_Region.F_BuildID ,T_ST_Region.F_RegionID,T_ST_RegionMeter.F_MeterID ";

            DataTable DT = new DataTable();
            DT = SQLHelper.GetDataTable(SQLString);

            return DT;

        }

        public static int CheckData(string BuildID, string MeterID)
        {
            string SQLString = @" SELECT ISNULL((SELECT TOP(1) 1 
                                    FROM T_ST_MeterUseInfo 
                                    WHERE F_BuildID='" + BuildID + @"' AND F_MeterID='" + MeterID + @"' ), 0)  ";

            object rows= SQLHelper.GetSingle(SQLString);
            int str= Convert.ToInt16(rows);

            return str;

        }


    }
}
