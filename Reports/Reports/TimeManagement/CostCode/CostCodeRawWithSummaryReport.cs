using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Reports.TimeManagement.CostCode
{
    public partial class CostCodeRawWithSummaryReport : DevExpress.XtraReports.UI.XtraReport
    {
        public CostCodeRawWithSummaryReport(CostCodeReportDTO costcodeDto)
        {
            InitializeComponent();
            ProcessReport(costcodeDto);
        }

        private void ProcessReport(CostCodeReportDTO costcodeDto)
        {
            List<CostCodeReportDTO> _ccDatasource = new();
            _ccDatasource.Add(costcodeDto);

            this.DataSource = _ccDatasource;

            XRSubreport subReport = this.FindControl("xrSubreport1", true) as XRSubreport;
            XtraReport reportSource = subReport.ReportSource as XtraReport;
            (reportSource.DataSource as ObjectDataSource).DataSource = costcodeDto.CostCodeSummaryReportDTO;


            //}
        }
    }
}
