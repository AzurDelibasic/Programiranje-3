using DLWMS.WinForms.IB190006;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Reports
{
    public partial class frmIzvjestaj : Form
    {
        private List<StudentiPredmeti> studentPredmet;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(List<StudentiPredmeti> studentPredmet) : this()
        {
            this.studentPredmet = studentPredmet;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource();
            var rpc = new ReportParameterCollection();
            var tbl = new dsStudentiPredmeti.StudentiPredmetiDataTable();
            rpc.Add(new ReportParameter("BrojPolozenih", studentPredmet.Count().ToString()));
            rpc.Add(new ReportParameter("ProsjecnaOcjena", Math.Round(studentPredmet.Average(x => x.Ocjena),2).ToString()));
            foreach (var s in studentPredmet)
            {
                var red = tbl.NewStudentiPredmetiRow();
                red.Id = s.Id.ToString();
                red.ImePrezime = s.Student.ToString();
                red.Predmet = s.Predmet.ToString();
                red.Datum = s.DatumPolaganja.ToString("dd.MM.yyyy HH:mm");
                red.Ocjena = s.Ocjena.ToString();
                tbl.AddStudentiPredmetiRow(red);
            }
            rds.Value = tbl;
            rds.Name = "dsStudentiPredmeti";
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
