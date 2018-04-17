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
        public static DataTable ExportBaseData()
        {
            string SQLString = @"SELECT  F_BuildID AS '建筑编码','上级区域编码' = '','区域编码' = ''
	                              ,'区域名称' = '',F_MeterID AS '区域包含仪表代码',F_MeterName AS '仪表名称'
	                              ,'运算公式' = '加' ,'百分率' = '100'
                              FROM[EMS].[dbo].[T_ST_MeterUseInfo]
                              ORDER BY F_BuildID ,F_MeterID" ;

            DataTable DT = new DataTable();
            DT=SQLHelper.GetDataTable(SQLString);

            return DT;

        }

       
    }
}
