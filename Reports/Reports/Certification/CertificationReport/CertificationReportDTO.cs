using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Certification.CertificationReport
{
    public class CertificationReportDTO
    {
        public string DateToday { get; set; } = DateTime.Now.ToString("MMMM dd, yyyy");
        public List<EmployeeDetails> ManagementEmployees { get; set; }
        public List<EmployeeDetails> ProductionEmployees { get; set; }
        public List<EmployeeDetails> ProductionResignedEmployees { get; set; }
    }
    public class EmployeeDetails
    {
        public string Name { get; set; }
        public string? Initials { get; set; }
        public string Experience { get; set; }
        public string Degree { get; set; }
        public string Position { get; set; }
    }
}
