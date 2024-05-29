using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Invoice
{
    public class InvoiceHeaderReport
    {
        public string CustomerName { get; set; }
        public string CustomerContactPerson { get; set; }
        public string CustomerEmail { get; set; }
        public CompanyUserAddress? companyUserAddress { get; set; }
        public string? JobName { get; set; }
        public string? PONumber { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DateIssued { get; set; }
        public string? NetAmount { get; set; }
        public string? PreviousInvoice { get; set; }
        public string? Total { get; set; }

        public string? Tax { get; set; }
        public string? Net { get; set; }
        public string? ThisInvoice { get; set; }

        public string? Address1 { get; set; }
        public string? Address2 { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }

        public string? StateProvince { get; set; }

        public string? ZipCode { get; set; }

        public bool? IsIncludeHistory { get; set; }
    }

    public class CompanyUserAddress
    {
        public string? CompanyName { get; set; }
        public string? Address { get; set; }
        public string? ContactNo { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }

    }


    public class InvoiceDetailDatasource
    {
        public List<JobLine>? jobLine { get; set; }
        public List<InvoiceHistory>? invoiceHistory { get; set; }  

    }
    public class JobLine
    {
        public List<JobLineData>? jobLine { get; set; }
        public List<InvoiceHistory>? invoiceHistory { get; set; }
   
    }
    public class JobLineData
    {
        public string Name { get; set; }
        public decimal? BudgetPrice { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal PreviouslyInvoiced { get; set; }
    }

    public class InvoiceHistory
    {
        public DateTime? DateIssued { get; set; }
        public string? InvoiceNo { get; set; }
        public string? JoblineName { get; set; }
        public string? SublineName { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Balance { get; set; }
        public string StatusID { get; set; }

    }
}
