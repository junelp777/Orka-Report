using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var rpt = new Reports.Test.Report1())
            {
                
                List<Reports.Test.Class1> model  =new List<Reports.Test.Class1>();

                model.Add(new Reports.Test.Class1()
                {
                    Id = 1,
                    Name = "Test",
                    Gender = "male"
                }
                );

                model.Add(new Reports.Test.Class1()
                {
                    Id = 2,
                    Name = "Test2",
                    Gender = "Femail"
                }
               );

                model.Add(new Reports.Test.Class1()
                {
                    Id = 3,
                    Name = "Test3",
                    Gender = "males"
                }
               );

                rpt.DataSource = model;
                rpt.ExportToXlsx("C:\\JUNEL\\sample.xlsx");



            }
        }
    }
}
