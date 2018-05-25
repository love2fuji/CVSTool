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
        /// <summary>
        /// 导出原来配置的部门信息
        /// </summary>
        /// <returns></returns>
        public static DataTable ExportDepartmentData(string buildID)
        {
            string SQLString = @"SELECT T_ST_DepartmentInfo.F_BuildID AS '建筑编码'
		                                ,F_DepartParentID AS '上级区域(部门)编码'
		                                ,T_ST_DepartmentInfo.F_DepartmentID AS '区域(部门)编码'
		                                ,T_ST_DepartmentInfo.F_DepartmentName AS '区域(部门)名称'
		                                ,T_ST_DepartmentMeter.F_MeterID AS '包含仪表代码'
		                                ,F_MeterName AS '仪表名称'
		                                ,T_ST_DepartmentMeter.F_Operator AS '运算公式'
		                                ,T_ST_DepartmentMeter.F_Rate AS '百分率' 
                                  FROM T_ST_MeterUseInfo
	                                INNER JOIN T_ST_DepartmentMeter ON T_ST_DepartmentMeter.F_MeterID=T_ST_MeterUseInfo.F_MeterID
	                                INNER JOIN T_ST_DepartmentInfo ON T_ST_DepartmentInfo.F_DepartmentID=T_ST_DepartmentMeter.F_DepartmentID
                                    WHERE T_ST_DepartmentInfo.F_BuildID='" + buildID + @"'
                                  ORDER BY T_ST_DepartmentInfo.F_BuildID ,T_ST_DepartmentInfo.F_DepartmentID,T_ST_DepartmentMeter.F_MeterID";

            DataTable DT = new DataTable();
            DT=SQLHelper.GetDataTable(SQLString);

            return DT;

        }


        /// <summary>
        /// 导出原来配置的区域信息
        /// </summary>
        /// <returns></returns>
        public static DataTable ExportRegionData(string buildID)
        {
            string SQLString = @" SELECT T_ST_Region.F_BuildID AS '建筑编码'
		                                ,F_RegionParentID AS '上级区域(部门)编码'
		                                ,T_ST_Region.F_RegionID AS '区域(部门)编码'
		                                ,T_ST_Region.F_RegionName AS '区域(部门)名称'
		                                ,T_ST_RegionMeter.F_MeterID AS '包含仪表代码'
		                                ,F_MeterName AS '仪表名称'
		                                ,T_ST_RegionMeter.F_Operator AS '运算公式'
		                                ,T_ST_RegionMeter.F_Rate AS '百分率' 
                                  FROM T_ST_MeterUseInfo
	                                INNER JOIN T_ST_RegionMeter ON T_ST_RegionMeter.F_MeterID=T_ST_MeterUseInfo.F_MeterID
	                                INNER JOIN T_ST_Region ON T_ST_Region.F_RegionID=T_ST_RegionMeter.F_RegionID
                                    WHERE T_ST_Region.F_BuildID='" + buildID + @"'
                                  ORDER BY T_ST_Region.F_BuildID ,T_ST_Region.F_RegionID,T_ST_RegionMeter.F_MeterID ";

            DataTable DT = new DataTable();
            DT = SQLHelper.GetDataTable(SQLString);

            return DT;

        }

        /// <summary>
        /// 导出基础数据
        /// </summary>
        /// <returns></returns>
        public static DataTable ExportBaseData(string buildID)
        {
            string SQLString = @"SELECT F_BuildID AS '建筑编码'
		                                ,null AS '上级区域(部门)编码'
		                                ,null AS '区域(部门)编码'
		                                ,null AS '区域(部门)名称'
		                                ,F_MeterID AS '包含仪表代码'
		                                ,F_MeterName AS '仪表名称'
		                                ,'加' AS '运算公式'
		                                ,100 AS '百分率' 
                                    FROM T_ST_MeterUseInfo  
                                    WHERE F_BuildID='"+ buildID + @"'                            
                                    ORDER BY F_BuildID ,F_MeterID ";

            DataTable DT = new DataTable();
            DT = SQLHelper.GetDataTable(SQLString);

            return DT;

        }

        public static DataTable ExportEnergyData(string buildID)
        {
            string SQLString = @"SELECT	T_ST_CircuitMeterInfo.F_BuildID AS '建筑代码',F_CircuitID AS '本级支路代码'
		                                ,F_ParentID AS '上级支路代码',F_CircuitName AS '支路名称'
		                                ,CASE WHEN F_MainCircuit='TRUE' THEN 1 ELSE 0 END  AS '主回路',T_ST_CircuitMeterInfo.F_MeterID AS '仪表代码'
		                                ,F_CircuitName AS '仪表名称',F_MeterCode AS '仪表代号'
		                                ,F_MeterAddr1 AS '仪表地址',F_MeterProdName AS '监测仪表产品名称'
		                                ,F_MeterModel AS '仪表型号',F_MeterType AS '仪表类型'
		                                ,T_ST_CircuitMeterInfo.F_EnergyItemCode AS '仪表测量的分类能耗'
		                                ,NULL AS '分项能耗',F_CollectionName AS '采集器名称',NULL AS '实时曲线点位'				
                                  FROM T_ST_CircuitMeterInfo
                                  INNER JOIN T_ST_MeterUseInfo ON T_ST_MeterUseInfo.F_MeterID = T_ST_CircuitMeterInfo.F_MeterID
                                  INNER JOIN T_ST_MeterProdInfo ON T_ST_MeterProdInfo.F_MeterProdID = T_ST_MeterUseInfo.F_MeterProdID
                                  INNER JOIN T_ST_DataCollectionInfo ON T_ST_DataCollectionInfo.F_CollectionID = T_ST_MeterUseInfo.F_CollectionID 
                                  WHERE T_ST_CircuitMeterInfo.F_BuildID = '" + buildID + @"'";

            DataTable DT = new DataTable();
            DT = SQLHelper.GetDataTable(SQLString);

            return DT;

        }


        public static DataTable GetBuildInfo()
        {
            string SQLString = @"SELECT  F_BuildID,F_BuildName
                                FROM T_BD_BuildBaseInfo";

            DataTable dt = SQLHelper.GetDataTable(SQLString);
            return dt;
        }


        public static Dictionary<string,string> GetBuildInfoDic()
        {
            Dictionary<string, string> buildInfoDic = new Dictionary<string, string>();
            string SQLString = @"SELECT  F_BuildID,F_BuildName
                                FROM T_BD_BuildBaseInfo";

            DataTable dt = SQLHelper.GetDataTable(SQLString);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string BuildID =row["F_BuildID"].ToString();
                    string BuildName = row["F_BuildName"].ToString();
                    buildInfoDic.Add(BuildID, BuildName);
                }
            }

            return buildInfoDic;
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
