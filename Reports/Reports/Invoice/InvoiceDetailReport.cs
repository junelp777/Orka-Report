using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;

namespace Reports.Invoice
{
    public partial class InvoiceDetailReport : DevExpress.XtraReports.UI.XtraReport
    {
        private string prefix = "$";
        public InvoiceDetailReport(InvoiceHeaderReport invoiceHeader, List<InvoiceHistory> invoiceHistoryData)
        {
            InitializeComponent();

            lblCompanyUserName.Text = invoiceHeader.companyUserAddress.CompanyName;
            lblCompanyUserAddress.Text = invoiceHeader.companyUserAddress.Address;
            citystatelbl.Text = invoiceHeader.companyUserAddress.City+ ", "+ invoiceHeader.companyUserAddress.State + " " + invoiceHeader.companyUserAddress.Zip;
            //ziplbl.Text = invoiceHeader.companyUserAddress.Zip;
            lblcontact.Text =  invoiceHeader.companyUserAddress.ContactNo;
            lblEmail.Text =  invoiceHeader.companyUserAddress.Email;


            lblCustomerName.Text = invoiceHeader.CustomerName;
            lblCustomerAddress.Text = invoiceHeader.Address1;
            lblcust_citystatezip.Text =  invoiceHeader.City + ", " + invoiceHeader.StateProvince + " " + invoiceHeader.ZipCode;

            lblCustomerContact.Text = invoiceHeader.CustomerContactPerson;
            lblCustomerEmail.Text = invoiceHeader.CustomerEmail;

            lblJobname.Text = invoiceHeader.JobName;
            lblPoNumber.Text = invoiceHeader.PONumber;
            lblInvoiceNo.Text = invoiceHeader.InvoiceNo;
            lblDateIssued.Text = Convert.ToDateTime(invoiceHeader.DateIssued).ToString("MM-dd-yyyy");
            lblDueDate.Text = Convert.ToDateTime(invoiceHeader.DueDate).ToString("MM-dd-yyyy");
            lblNetAmount.Text = prefix + Convert.ToDecimal(invoiceHeader.NetAmount).ToString("N2");

           // lblPreviousAmount.Text =prefix + (Convert.ToDecimal(invoiceHeader.PreviousInvoice) == 0 ? "0.00" : Convert.ToDecimal(invoiceHeader.PreviousInvoice).ToString("N2"));
            lblThisInvoice.Text = invoiceHeader.ThisInvoice;

            lblTotal.Text = prefix + Convert.ToDecimal(invoiceHeader.Total).ToString("N2");
            lblTax.Text = prefix + Convert.ToDecimal(invoiceHeader.Tax).ToString("N2");
            lblDetailNetAmount.Text =prefix + Convert.ToDecimal(invoiceHeader.NetAmount).ToString("N2");


            JobHistoryLabel.Visible = false;
            TableGrandTotal.Visible = false;
            TableJoblineHeader.Visible = false;
            table2.Visible =false;
            if (Convert.ToBoolean(invoiceHeader.IsIncludeHistory) && (invoiceHistoryData.Count > 0 && invoiceHistoryData != null))
            {
                JobHistoryLabel.Visible = true;
                TableGrandTotal.Visible = true;
                TableJoblineHeader.Visible = true;
                table2.Visible =true;

                // var summary = GetSummary(invoiceHistoryData);

                sumAmount.Text = prefix+Convert.ToDecimal(invoiceHistoryData.Select(x => x.Amount).Sum()).ToString("N2");
                sumPaid.Text = prefix+Convert.ToDecimal(invoiceHistoryData.Select(x => x.Paid).Sum()).ToString("N2");
                sumBalance.Text = prefix+Convert.ToDecimal(invoiceHistoryData.Select(x => x.Balance).Sum()).ToString("N2");
            }
            else
            {
                // JobHistoryLabel.Text= "No Data: [Job Invoicing History]";
            }
            //invoiceHistorySubreport.Visible = false;
            //if (Convert.ToBoolean(invoiceHeader.IsIncludeHistory))
            //{
            //    invoiceHistorySubreport.Visible = true;

            //    //sub report
            //    XRSubreport subReport = this.FindControl("invoiceHistorySubreport", true) as XRSubreport;
            //    XtraReport reportSource = subReport.ReportSource as XtraReport;
            //    (reportSource.DataSource as ObjectDataSource).DataSource = invoiceHistoryData;
            //}


        }

        private List<SummaryDetail> GetSummary(IReadOnlyList<InvoiceHistory> invoiceHistory)
        {

            var result = from d in invoiceHistory
                         group d by new
                         {
                             d.DateIssued

                         } into dep
                         select new SummaryDetail() { Amount = Convert.ToDecimal(dep.Sum(x => x.Amount)), Paid =Convert.ToDecimal(dep.Sum(x => x.Paid)), Balance =Convert.ToDecimal(dep.Sum(x => x.Balance)) };

            return result.ToList();
        }


        private class SummaryDetail
        {
            public decimal Amount { get; set; }
            public decimal Paid { get; set; }
            public decimal Balance { get; set; }
        }

    }

  
}
