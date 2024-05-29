using DevExpress.Office.Utils;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
//using DevExpress.XtraPrinting;


namespace Reports.Certification.CertificationReport
{
    public partial class Certification : DevExpress.XtraReports.UI.XtraReport
    {
        public Certification(List<CertificationReportDTO> certificationDTO)
        {
            InitializeComponent();

            this.DataSource = certificationDTO;

            foreach (var cert in certificationDTO)
            {
                if (cert.ProductionResignedEmployees.Count == 0 || cert.ProductionResignedEmployees == null)
                {
                    ResignedEmployeesTable.Visible = false;
                }
                else
                {
                    ResignedEmployeesTable.Visible = true;
                }

                break;
            }
        }

        public byte[] CertificationData()
        {
            //DocxExportOptions DocxExportOptions = new DocxExportOptions()
            //{
            //    ExportMode = DocxExportMode.SingleFile
            //};
            MemoryStream ms = new MemoryStream();
            ExportToDocx(ms);

            return ms.ToArray();
        }

    }
}
