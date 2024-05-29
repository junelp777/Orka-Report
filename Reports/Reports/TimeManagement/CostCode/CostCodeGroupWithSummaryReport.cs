using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Reports.TimeManagement.CostCode
{
    public partial class CostCodeGroupWithSummaryReport : DevExpress.XtraReports.UI.XtraReport
    {
        public CostCodeGroupWithSummaryReport(CostCodeReportDTO costcodeDto)
        {
            InitializeComponent();
            ProcessReport(costcodeDto);
        }

        private void ProcessReport(CostCodeReportDTO costcodeDto)
        {
            List<CostCodeReportDTO> _ccDatasource = new();
            _ccDatasource.Add(costcodeDto);

            this.DataSource = _ccDatasource;

            departmentLbl1.Text = costcodeDto.DepartmentName;
            dateRangeLbl1.Text = costcodeDto.DateRange;
            costcodeTypelbl1.Text = costcodeDto.CostType + ":";
            costcodeIdsLbl1.Text = costcodeDto.IDs;

            departmentLbl.Text = costcodeDto.DepartmentName;
            dateRangeLbl.Text = costcodeDto.DateRange;
            costcodeTypelbl.Text = costcodeDto.CostType + ":";
            costcodeIdsLbl.Text = costcodeDto.IDs;

         
            //sub report
            XRSubreport subReport = this.FindControl("xrSubreport1", true) as XRSubreport;
            XtraReport reportSource = subReport.ReportSource as XtraReport;
            (reportSource.DataSource as ObjectDataSource).DataSource = costcodeDto.CostCodeSummaryReportDTO;



        }
    }
}
