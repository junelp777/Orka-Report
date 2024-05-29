using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Reports.TimeManagement.CostCode
{
    public partial class CostCodeRawReport : DevExpress.XtraReports.UI.XtraReport
    {
        public CostCodeRawReport(CostCodeReportDTO costcodeDto)
        {
            InitializeComponent();
            ProcessReport(costcodeDto);
        }

        private void ProcessReport(CostCodeReportDTO costcodeDto)
        {
            List<CostCodeReportDTO> _ccDatasource = new();
            _ccDatasource.Add(costcodeDto);

            this.DataSource = _ccDatasource;

           // xrSubreport1.Visible = false;
           // if (Convert.ToBoolean(invoiceHeader.IsIncludeHistory))
           //{
           // xrSubreport1.Visible = true;

            //sub report
            //XRSubreport subReport = this.FindControl("xrSubreport1", true) as XRSubreport;
            //XtraReport reportSource = subReport.ReportSource as XtraReport;
            //(reportSource.DataSource as ObjectDataSource).DataSource = costcodeSummaryDataSource;


            //}
        }
    }
}
