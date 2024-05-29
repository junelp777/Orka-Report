using DevExpress.Office.Utils;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace Reports.ProjectManagement.ChangeOrder
{
    public partial class ChangerOrderPDFReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ChangerOrderPDFReport(List<ChangerOrderDTOReport> data)
        {
            InitializeComponent();


            var nocOthersCount = data.Select(x => x.nocOthers.Count()).FirstOrDefault();
            if (nocOthersCount == 0)
            {
                DetailReport.Visible = false;
            }

            DataSource = data;
        }

    }
}
