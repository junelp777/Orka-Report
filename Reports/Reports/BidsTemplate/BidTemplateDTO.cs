using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Reports.BidsTemplate
{
    public class BidTemplateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public bool IsVoided { get; set; }
        //public int? CreatedBy { get; set; }
        //public int? LastModifiedBy { get; set; }
        //public string? CreatedByName { get; set; }
        //public string? LastModifiedByName { get; set; }
        //public int ProvisionCount { get; set; } = 0;
        //public int ContentCount { get; set; } = 0;
        public List<BidTemplateProvisionsDTO>? BidTemplateProvisions { get; set; }  //get No of provisions and No fo Contents
       
    }

    public class BidTemplateProvisionsDTO
    {
        public int Id { get; set; }
        //public int TemplateId { get; set; }
        //public int OrderNo { get; set; }
        public string Name { get; set; }
        //public bool IsIncluded { get; set; }
        //public int Order { get; set; }
        public List<BidTemplateProvisionContentsDTO>? BidTemplateProvisionContents { get; set; }

    }

    public class BidTemplateProvisionContentsDTO
    {
        public int Id { get; set; }
        public int ProvisionId { get; set; }
        //public int OrderNo { get; set; }
        public string Description { get; set; }
        public bool isHastHtmlTag { get; set; } = false;
        //public bool IsIncluded { get; set; }
        //public bool IsMultiline { get; set; }
        //public int Order { get; set; }
    }
}
