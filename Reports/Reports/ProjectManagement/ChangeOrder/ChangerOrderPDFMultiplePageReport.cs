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
    public partial class ChangerOrderPDFMultiplePageReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ChangerOrderPDFMultiplePageReport(List<ChangerOrderDTOReport> data)
        {
            InitializeComponent();


            var nocOthersCount = data.Select(x => x.nocOthers.Count()).FirstOrDefault();
            if (nocOthersCount == 0)
            {
                DetailReport.Visible = false;
            }

            var checkDetails3 = data.Select(x => x.Details3).FirstOrDefault();
            if (string.IsNullOrEmpty(checkDetails3))
            {
                detailPage3.Visible = false;
            }

            DataSource = data;
        }

    }
}
