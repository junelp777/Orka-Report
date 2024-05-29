using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.ProjectManagement.ChangeOrder
{
    public class ChangerOrderDTOReport
    {
        public int Id { get; set; }
        public string ChangeOrderNo { get; set; } = string.Empty;
        public DateTime ChangeOrderDate { get; set; } = DateTime.Now.Date;
        public string CustomerReference { get; set; } = string.Empty;
        public string WorkRequired { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Details { get; set; } = string.Empty;
        public string Details2 { get; set; } = string.Empty;
        public string Details3 { get; set; } = string.Empty;
        public bool IsBillable { get; set; }
        public bool IsCompleted { get; set; }
        public decimal ExeStdPrice { get; set; }
        public decimal ExeStdHours { get; set; }
        public decimal TotalExeStd => ExeStdPrice * ExeStdHours;
        public decimal ExePrmPrice { get; set; }
        public decimal ExePrmHours { get; set; }
        public decimal TotalExePrm => ExePrmPrice * ExePrmHours;
        public decimal SpmStdPrice { get; set; }
        public decimal SpmStdHours { get; set; }
        public decimal TotalSpmStd => SpmStdPrice * SpmStdHours;
        public decimal SpmPrmPrice { get; set; }
        public decimal SpmPrmHours { get; set; }
        public decimal TotalSpmPrm => SpmPrmPrice * SpmPrmHours;
        public decimal PmStdPrice { get; set; }
        public decimal PmStdHours { get; set; }
        public decimal TotalPmStd => PmStdPrice * PmStdHours;
        public decimal PmPrmPrice { get; set; }
        public decimal PmPrmHours { get; set; }
        public decimal TotalPmPrm => PmPrmPrice * PmPrmHours;
        public decimal PlStdPrice { get; set; }
        public decimal PlStdHours { get; set; }
        public decimal TotalPlStd => PlStdPrice * PlStdHours;
        public decimal PlPrmPrice { get; set; }
        public decimal PlPrmHours { get; set; }
        public decimal TotalPlPrm => PlPrmPrice * PlPrmHours;
        public decimal MdlStdPrice { get; set; }
        public decimal MdlStdHours { get; set; }
        public decimal TotalMdlStd => MdlStdPrice * MdlStdHours;
        public decimal MdlPrmPrice { get; set; }
        public decimal MdlPrmHours { get; set; }
        public decimal TotalMdlPrm => MdlPrmPrice * MdlPrmHours;
        public decimal EdtStdPrice { get; set; }
        public decimal EdtStdHours { get; set; }
        public decimal TotalEdtStd => EdtStdPrice * EdtStdHours;
        public decimal EdtPrmPrice { get; set; }
        public decimal EdtPrmHours { get; set; }
        public decimal TotalEdtPrm => EdtPrmPrice * EdtPrmHours;
        public decimal DocStdPrice { get; set; }
        public decimal DocStdHours { get; set; }
        public decimal TotalDocStd => DocStdPrice * DocStdHours;
        public decimal DocPrmPrice { get; set; }
        public decimal DocPrmHours { get; set; }
        public decimal TotalDocPrm => DocPrmPrice * DocPrmHours;
        public List<NocOtherDTOReport>? nocOthers { get; set; } = new();
        public decimal totalNocOthers => nocOthers.Sum(x => x.Price);
        public decimal totalHours => ExeStdHours + ExePrmHours + SpmStdHours + SpmPrmHours + PmStdHours + PmPrmHours + PlStdHours + PlPrmHours
            + MdlStdHours + MdlPrmHours + EdtStdHours + EdtPrmHours + DocStdHours + DocPrmHours;
        public decimal ChangeOrderTotal => TotalExeStd + TotalExePrm + TotalSpmStd + TotalSpmPrm + TotalPmStd + TotalPmPrm
            + TotalPlStd + TotalPlPrm + TotalMdlStd + TotalMdlPrm + TotalEdtStd + TotalEdtPrm + TotalDocStd + TotalDocPrm + totalNocOthers;
        public decimal TotalCost => TotalExeStd + TotalExePrm + TotalSpmStd + TotalSpmPrm + TotalPmStd + TotalPmPrm
         + TotalPlStd + TotalPlPrm + TotalMdlStd + TotalMdlPrm + TotalEdtStd + TotalEdtPrm + TotalDocStd + TotalDocPrm;
        public POJobDTOReport? Job { get; set; }
        //public GenericClassDTO? Status { get; set; }
        //public GenericClassDTO? CustomerStatus { get; set; }
        //public GenericClassDTO? Subline { get; set; }
        //public List<ChangeOrderAttachmentDTO>? ChangeOrderAttachments { get; set; }
        public int? SublineID { get; set; }
        public decimal EstimatedHours { get; set; } = 0;
        public decimal ApprovedHours { get; set; } = 0;
    }

    public class NocOtherDTOReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        //public PurchaseOrderDTO? PurchaseOrder { get; set; }
        //public PurchaseOrderDTO? RevisedPurchaseOrder { get; set; }

    }

    public class POJobDTOReport
    {
        public int Id { get; set; }
        public string CustomNumber { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string GeneralContractor { get; set; }
        public string ProjectSiteAddress { get; set; }
        //public GenericClassDTO? Customer { get; set; }
        public decimal ExeStdPrice { get; set; }
        public decimal ExePrmPrice { get; set; }
        public decimal SpmStdPrice { get; set; }
        public decimal SpmPrmPrice { get; set; }
        public decimal PmStdPrice { get; set; }
        public decimal PmPrmPrice { get; set; }
        public decimal PlStdPrice { get; set; }
        public decimal PlPrmPrice { get; set; }
        public decimal MdlStdPrice { get; set; }
        public decimal MdlPrmPrice { get; set; }
        public decimal EdtStdPrice { get; set; }
        public decimal EdtPrmPrice { get; set; }
        public decimal DocStdPrice { get; set; }
        public decimal DocPrmPrice { get; set; }
    }
}
