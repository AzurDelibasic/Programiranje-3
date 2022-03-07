using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.BrojIndeksa
{
    public partial class frmPretraga : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        public frmPretraga()
        {
            InitializeComponent();
            dgvPregled.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente(List<Student> filtriraniStudenti = null)
        {
            dgvPregled.DataSource = null;
            dgvPregled.DataSource = filtriraniStudenti ?? _baza.Studenti.ToList();
            if (dgvPregled.RowCount != 0)
            {
                lblBrojStudenata.Text += dgvPregled.RowCount.ToString();
            }
            else
            {
                lblBrojStudenata.Text += "0";
                lblProsjecnaOcjena.Text += "NOT SET";
            }
        }
    }
}
