using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.TimeManagement.CostCode
{
    public class CostCodeReportDTO
    {
        public string DepartmentName { get; set; }
        public string CostType { get; set; }
        public string ReportType { get; set; }
        public string IDs { get; set; }
        public string DateRange { get; set; }
        public bool IsHasSummary { get; set; }
        public List<CostCodeDetailReportDTO>? CostCodeDetailReportDTO { get; set; }
        public List<CostCodeDetailReportDTO>? CostCodeSummaryReportDTO { get; set; }
    }

    public class CostCodeDetailReportDTO
    {
        public DateTime TimeLogDate { get; set; }
        public decimal WorkHours { get; set; }
        public string CostCodeName { get; set; }
    }

    public enum ReportType
    { 
      Raw,
      Group
    }
 }
