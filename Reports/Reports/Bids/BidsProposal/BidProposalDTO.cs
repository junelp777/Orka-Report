using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Bids.BidsProposal
{
    public class BidProposalDTO
    {
        public string Date { get; set; }
        public string BidNo { get; set; }
        public int RevisionNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerContacts { get; set; }  // concat as newline 
        public string JobName { get; set; }
        public string? JobLocation { get; set; }
        public string DrawingNotes { get; set; }
        public string CompanyBackground { get; set; }
        public List<BidTemplateProvisionsDTO>? ProposalProvisions { get; set; }
    }

    public class BidTemplateProvisionsDTO
    {
        public int Id { get; set; }
        public string ProvisionName { get; set; }
        public List<BidTemplateProvisionContentsDTO>? ProposalProvisionContents { get; set; }

    }

    public class BidTemplateProvisionContentsDTO
    {
        public int Id { get; set; }
        public int ProvisionId { get; set; }
        public string ContentDescription { get; set; }
        public bool isHastHtmlTag { get; set; } = false;
    }



    public class CustomerContact 
    {
    
        public string ContactPerson { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
    }
    public class PriceSettingDTO
    {
        public string Name { get; set; }
        public List<PriceSettingDTODescription>? Description { get; set; }
    }

    public class PriceSettingDTODescription
    {
        public string Description { get; set; }
    }

}
