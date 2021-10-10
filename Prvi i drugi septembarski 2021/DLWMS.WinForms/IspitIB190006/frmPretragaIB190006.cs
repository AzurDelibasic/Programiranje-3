using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIB190006
{
    public partial class frmPretragaIB190006 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        string _filter;
        List<string> _samoglasnici = new List<string> { "a","e","i","o","u"};
        List<string> _znakovi = new List<string> { "?", "!", "<", ">", "*" };
        public frmPretragaIB190006()
        {
            InitializeComponent();
            dgvStudentiPredmeti.AutoGenerateColumns = false;
        }

        private void frmPretragaIB190006_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente(List<StudentiPolozeniPredmeti> spp = null)
        {
            dgvStudentiPredmeti.DataSource = null;
            dgvStudentiPredmeti.DataSource = spp ?? UcitajSve();
            if ((dgvStudentiPredmeti.DataSource as List<StudentiPolozeniPredmeti>).Count != 0)
            {
                lblProsjek.Text = $"{Math.Round((dgvStudentiPredmeti.DataSource as List<StudentiPolozeniPredmeti>).Average(x => x.ProsjekPolozenih),2)}";
                lblNajveciProsjek.Text = $"{NajveciProsjek()}";
            }
            else
            {
                lblProsjek.Text = "0";
                lblNajveciProsjek.Text = "NOT SET";
            }
        }

        private string NajveciProsjek()
        {
            var dgv = dgvStudentiPredmeti.DataSource as List<StudentiPolozeniPredmeti>;
            int MAXindex = 0;
            double MAXavg = 0;
            if (dgv.Count == 0)
                return "0";
            for (int i = 0; i < dgv.Count; i++)
            {
                if (dgv[i].ProsjekPolozenih > MAXavg)
                {
                    MAXavg = dgv[i].ProsjekPolozenih;
                    MAXindex = i;
                }
            }
            return $"{dgv[MAXindex].Student}";
        }

        private List<StudentiPolozeniPredmeti> UcitajSve()
        {
            var spp = new List<StudentiPolozeniPredmeti>();
            var studenti = _baza.StudentiPredmeti.ToList().Select(x => x.Student).Distinct().ToList();
            for (int i = 0; i < studenti.Count(); i++)
            {
                spp.Add(new StudentiPolozeniPredmeti()
                {
                    Student = studenti[i],
                    Predmeti = string.Join(";", _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == studenti[i].Id).Select(x => x.Predmet.Naziv).ToList()),
                    BrojPolozenih = _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == studenti[i].Id).Count(),
                    ProsjekPolozenih = _baza.StudentiPredmeti.ToList().Where(x=> x.Student.Id == studenti[i].Id).Average(x=>x.Ocjena)
                }) ;
            }
            return spp;
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            _filter = txtImePrezime.Text.ToLower();
            if (string.IsNullOrEmpty(_filter))
                UcitajStudente();
            else
                Filtriraj();
        }

        private void Filtriraj()
        {
            var spp = new List<StudentiPolozeniPredmeti>();
            var studenti = _baza.StudentiPredmeti.Where(x => x.Student.Ime.ToLower().Contains(_filter) || x.Student.Prezime.ToLower().Contains(_filter)).ToList().Select(x => x.Student).Distinct().ToList();
            for (int i = 0; i < studenti.Count; i++)
            {
                spp.Add(new StudentiPolozeniPredmeti
                {
                    Student = studenti[i],
                    Predmeti = string.Join(";", _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == studenti[i].Id).Select(x => x.Predmet.Naziv).ToList()),
                    BrojPolozenih = _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == studenti[i].Id).Count(),
                    ProsjekPolozenih = _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == studenti[i].Id).Average(x => x.Ocjena)
                });
            }
            UcitajStudente(spp);
        }

        private void dgvStudentiPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var student = (dgvStudentiPredmeti.Rows[e.RowIndex].DataBoundItem as StudentiPolozeniPredmeti).Student;
                frmScanIspitaIB190006 frm = new frmScanIspitaIB190006(student);
                frm.ShowDialog();
            }
        }

        private async void btnThread_Click(object sender, EventArgs e)
        {
            var tekst = txtThread.Text.ToLower();
            int samoglasnici = 0;
            int suglasnici = 0;
            int znakovi = 0;
            await Task.Run(() =>
            {
                samoglasnici = tekst.Where(x => _samoglasnici.Contains(x.ToString())).Count();
                znakovi = tekst.Where(x => _znakovi.Contains(x.ToString())).Count();
                suglasnici = tekst.Length - samoglasnici - znakovi;
            });
            Action action = new Action(() => lblSam.Text = samoglasnici.ToString());
            Action action2 = new Action(() => lblSug.Text = suglasnici.ToString());
            Action action3 = new Action(() => lblZnak.Text = znakovi.ToString());
            BeginInvoke(action);
            BeginInvoke(action2);
            BeginInvoke(action3);
        }
    }
}
