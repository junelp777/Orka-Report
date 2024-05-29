using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.ProjectManagement.Rfi
{
    public class RfiReport
    {
        public string Date { get; set; }
        public string JobNo { get; set; }
        public string LtcJobNo { get; set; }
        public string JobName { get; set; }
        public string CompanyName { get; set; }
        public string PmName { get; set; }
        public string CustomerName { get; set; }
        public string ContactPersonName { get; set; }
        public string RfiNo { get; set; }
        public string? SeqNo { get; set; }
        public string? CC { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public string CompanyAddress { get; set; }
        public string HeaderCaption { get; set; }
        public string Type { get; set; } // RFI # | LOI #
        public List<Responses>? Reply { get; set; }
        //public string? Reply { get; set; }
    }

    public class Responses
    {
        public string RecipientName { get; set; }
        public string Message { get; set; }
        public string Indent { get; set; }
    }
}
