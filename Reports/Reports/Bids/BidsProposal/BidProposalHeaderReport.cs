using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Reports.Bids.BidsProposal
{
    public partial class BidProposalHeaderReport : DevExpress.XtraReports.UI.XtraReport
    {
        public BidProposalHeaderReport(List<BidProposalDTO> proposalDTO)
        {
            InitializeComponent();

            this.DataSource = proposalDTO;
        }

    }
}
