using DLWMS.WinForms.Entiteti;
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
        private List<StudentiPredmeti> listaStudenata;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(List<StudentiPredmeti> listaStudenata) : this()
        {
            this.listaStudenata = listaStudenata;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource();
            var rpc = new ReportParameterCollection();
            var tbl = new dsPolozeniPredmeti.PolozeniPredmetiDataTable();
            rpc.Add(new ReportParameter("ProsjecnaOcjena", Math.Round(listaStudenata.Average(o => o.Ocjena),2).ToString()));
            //this.reportViewer1.RefreshReport();

            foreach(var s in listaStudenata)
            {
                var red = tbl.NewPolozeniPredmetiRow();
                red.ImePrezime = s.Student.ToString();
                red.Predmet = s.Predmet.ToString();
                red.Datum = s.DatumPolaganja.ToString("dd.MM.yyyy HH:mm");
                red.Ocjena = s.Ocjena;
                tbl.AddPolozeniPredmetiRow(red);
            }
            rds.Value = tbl;
            rds.Name = "dsPolozeniPredmeti";
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
