using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.HRPortal.EmployeePoints
{
    public class EmployeePointsReportDTO
    {
        public DateTime EffectivityDate { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string RE { get; set; }
        public string HeadName { get; set; }
        public string HeadTitle { get; set; }
        public string EmployeeTitle { get; set; }
        public decimal Points { get; set; }
        public string Details { get; set; }

    }
}
