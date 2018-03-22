using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVSTool.Mode
{
    /// <summary>
    /// 区域划分
    /// </summary>
    public class Region
    {
        public string RegionID { get; set; }
        public string BuildID { get; set; }
        public string RegionParentID { get; set; }
        public string RegionName { get; set; }
    }

    /// <summary>
    /// 每个区域包含的仪表
    /// </summary>
    public class RegionMeter
    {
        public string EntryID { get; set; }
        public string RegionID { get; set; }
        public string MeterID { get; set; }
        public string Operator { get; set; }
        public string Rate { get; set; }
    }

    public class RegionInput
    {
        public string BuildID { get; set; }
        public string RegionID { get; set; }
        public string RegionParentID { get; set; }
        public string RegionName { get; set; }
        public string MeterID { get; set; }
        public string MeterName { get; set; }
        public string Operator { get; set; }
        public string Rate { get; set; }
    }
}
