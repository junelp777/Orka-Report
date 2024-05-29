
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Spreadsheet;


namespace Reports.TimeManagement.CostCode
{
    public partial class CostCodeGroupReport : DevExpress.XtraReports.UI.XtraReport
    {
        public CostCodeGroupReport(CostCodeReportDTO costcodeDto)
        {
            InitializeComponent();
            ProcessReport(costcodeDto);

            //Workbook book1 = new Workbook();
        }

        private void ProcessReport(CostCodeReportDTO costcodeDto)
        {
            List<CostCodeReportDTO> _ccDatasource = new();
            _ccDatasource.Add(costcodeDto);

            this.DataSource = _ccDatasource;

            departmentLbl.Text = costcodeDto.DepartmentName;
            dateRangeLbl.Text = costcodeDto.DateRange;
            costcodeTypelbl.Text = costcodeDto.CostType + ":";
            costcodeIdsLbl.Text = costcodeDto.IDs;

            ////sub report
            //XRSubreport subReport = this.FindControl("xrSubreport1", true) as XRSubreport;
            //XtraReport reportSource = subReport.ReportSource as XtraReport;
            //(reportSource.DataSource as ObjectDataSource).DataSource = costcodeDto.CostCodeSummaryReportDTO;

            

        }
    }
}
