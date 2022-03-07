using DLWMS.WinForms.BrojIndeksa;
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
        private List<StudentiIspitiScan> skenovi;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(List<StudentiIspitiScan> skenovi) : this()
        {
            this.skenovi = skenovi;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource();
            var rpc = new ReportParameterCollection();
            var tbl = new dsStudentiSkenovi.SkenoviDataTable();
            foreach (var s in skenovi)
            {
                var red = tbl.NewSkenoviRow();
                red.Predmet = s.Predmet.ToString();
                red.Napomena = s.Napomena;
                red.Varanje = s.Varanje == true ? "Da" : "Ne";
                tbl.Rows.Add(red);
            }
            rds.Name = "dsStudentiSkenovi";
            rds.Value = "tbl";

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
