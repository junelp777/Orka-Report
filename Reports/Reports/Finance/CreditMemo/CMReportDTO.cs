using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Finance.CreditMemo
{
    public class CMReportDTO
    {
        public string HeaderAddress1 { get; set; }
        public string HeaderAddress2 { get; set; }
        public string Customer { get; set; }
        public string CMNO { get; set; }
        public string Date { get; set; }
        public string Detail { get; set; }
        public decimal Amount { get; set; }

    }
}
