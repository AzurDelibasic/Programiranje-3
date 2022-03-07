using DLWMS.WinForms.DB;
using DLWMS.WinForms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB190006
{
    public partial class frmPretraga : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        List<StudentiPredmeti> _studentPredmet;
        int filterOcjena;

        public frmPretraga()
        {
            InitializeComponent();
            dgvStudentiPredmeti.AutoGenerateColumns = false;
            txtGenerisani.ScrollBars = ScrollBars.Vertical;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            cbStudent.DataSource = _baza.Studenti.ToList();
        }

        private void UcitajPodatke()
        {
            dgvStudentiPredmeti.DataSource = null;
            dgvStudentiPredmeti.DataSource = Filtriraj();
        }

        private List<StudentiPredmeti> Filtriraj()
        {
            _studentPredmet = _baza.StudentiPredmeti.Where(x => x.Ocjena >= filterOcjena).ToList();
            this.Text = $"Ukupno zapisa: {_studentPredmet.Count}";
            return _studentPredmet;
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbMinOcjena.Text))
            {
                filterOcjena = int.Parse(cbMinOcjena.SelectedItem.ToString());
                UcitajPodatke();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var frm = new frmIzvjestaj(_studentPredmet);
            frm.ShowDialog();
        }

        private void dgvStudentiPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentpredmeti = dgvStudentiPredmeti.Rows[e.RowIndex].DataBoundItem as StudentiPredmeti;
            if (e.ColumnIndex == 5)
            {
                var frmStudentSeminarski = new frmStudentSeminarski(studentpredmeti);
                frmStudentSeminarski.ShowDialog();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbStudent.Text) && !string.IsNullOrEmpty(txtBrojOcjena.Text))
            {
                int brojOcjena = int.Parse(txtBrojOcjena.Text);
                var rand = new Random();
                for (int i = 0; i < brojOcjena; i++)
                {
                    Thread.Sleep(100);
                    var noviZapis = new StudentiPredmeti()
                    {
                        Student = cbStudent.SelectedItem as Student,
                        Predmet = _baza.Predmeti.ToList().ElementAt(rand.Next(1, 4)),
                        Ocjena = rand.Next(6, 11),
                        DatumPolaganja = DateTime.Now
                    };
                    _baza.StudentiPredmeti.Add(noviZapis);
                    Action akcija = () => txtGenerisani.Text += $"Za {cbStudent.SelectedItem as Student} dodat polozeni -> {noviZapis.Predmet} Ocjena({noviZapis.Ocjena}) {Environment.NewLine}";
                    BeginInvoke(akcija);
                }
                _baza.SaveChanges();
                UcitajPodatke();
                MessageBox.Show("Dodavanje predmeta zavrseno!","Obavijest");
            }
            else
            {
                MessageBox.Show("Jedno od polja Vam je prazno!", "Obavijest");
            }
        }
    }
}
