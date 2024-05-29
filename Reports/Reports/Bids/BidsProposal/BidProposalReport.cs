using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Reports.Bids.BidsProposal
{
    public partial class BidProposalReport : DevExpress.XtraReports.UI.XtraReport
    {
        public BidProposalReport(List<PriceSettingDTO> priceSetting, List<BidProposalDTO> proposalDTO)
        {
            InitializeComponent();

            this.DataSource = proposalDTO;

            //sub report
            XRSubreport subReport = this.FindControl("PriceSettingSubreport", true) as XRSubreport;
            XtraReport reportSource = subReport.ReportSource as XtraReport;
            (reportSource.DataSource as ObjectDataSource).DataSource = priceSetting;
        }

    }
}
