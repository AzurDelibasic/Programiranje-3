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
        string filter = "";
        List<string> samoglasnici = new List<string> { "a", "e", "i", "o", "u" };
        List<string> znakovi = new List<string> { "?", "!", ":", ";", "." };

        public frmPretraga()
        {
            InitializeComponent();
            dgvStudentiPolozeni.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void UcitajPodatke(List<StudentiPolozeniPrikaz> spp = null)
        {
            dgvStudentiPolozeni.DataSource = null;
            dgvStudentiPolozeni.DataSource = spp ?? UcitajSve();
            if ((dgvStudentiPolozeni.DataSource as List<StudentiPolozeniPrikaz>).Count != 0)
            {
                lblProsjek.Text = $"{Math.Round((dgvStudentiPolozeni.DataSource as List<StudentiPolozeniPrikaz>).Average(x => x.Prosjek),2)}";
                lblNajboljiProsjek.Text = $"{NajboljiStudent()}";
            }
            else
            {
                lblProsjek.Text = "0";
                lblNajboljiProsjek.Text = "NOT SET";
            }
        }

        private object NajboljiStudent()
        {
            var studenti = dgvStudentiPolozeni.DataSource as List<StudentiPolozeniPrikaz>;
            int maxIndex = 0;
            double maxProsjek = 0;
            if (studenti.Count != 0)
            {
                for (int i = 0; i < studenti.Count; i++)
                {
                    if (studenti[i].Prosjek > maxProsjek)
                    {
                        maxProsjek = studenti[i].Prosjek;
                        maxIndex = i;
                    }
                }
            }
            return $"{studenti[maxIndex].Student}";
        }


        private List<StudentiPolozeniPrikaz> UcitajSve()
        {
            var spp = new List<StudentiPolozeniPrikaz>();
            var student = _baza.StudentiPredmeti.ToList().Select(x => x.Student).Distinct().ToList();
            for (int i = 0; i < student.Count; i++)
            {
                spp.Add(new StudentiPolozeniPrikaz
                {
                    Student = student[i],
                    Polozeni = string.Join("; ", _baza.StudentiPredmeti.ToList().Where(x=>x.Student.Id == student[i].Id).Select(x=>x.Predmet.Naziv).ToList()),
                    Prosjek = Math.Round(_baza.StudentiPredmeti.ToList().Where(x=>x.Student.Id == student[i].Id).Average(x=>x.Ocjena),2),
                    BrojPolozenih = _baza.StudentiPredmeti.ToList().Where(x=>x.Student.Id == student[i].Id).Count()
                });
            }
            return spp;
        }



        private void Filtriraj()
        {
            var spp = new List<StudentiPolozeniPrikaz>();
            var student = _baza.StudentiPredmeti.Where(x => x.Student.Ime.ToLower().Contains(filter) || x.Student.Prezime.ToLower().Contains(filter) || filter == "").ToList().Select(x=>x.Student).Distinct().ToList();
            for (int i = 0; i < student.Count; i++)
            {
                spp.Add(new StudentiPolozeniPrikaz
                {
                    Student = student[i],
                    Polozeni = string.Join("; ", _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == student[i].Id).Select(x => x.Predmet.Naziv).ToList()),
                    Prosjek = _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == student[i].Id).Average(x => x.Ocjena),
                    BrojPolozenih = _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == student[i].Id).Count()
                });
            }
            UcitajPodatke(spp);
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            filter = txtImePrezime.Text.ToLower();
            Filtriraj();
        }

        private void dgvStudentiPolozeni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = (dgvStudentiPolozeni.Rows[e.RowIndex].DataBoundItem as StudentiPolozeniPrikaz).Student;
            if (e.ColumnIndex == 4)
            {
                var forma = new frmScanIspita(student);
                forma.ShowDialog();
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text.ToLower();
            int brjSamoglas = 0;
            int brjSuglas = 0;
            int brjZnak = 0;
            await Task.Run(() =>
            {
                brjSamoglas = text.Where(x => samoglasnici.Contains(x.ToString())).Count();
                brjZnak = text.Where(x => znakovi.Contains(x.ToString())).Count();
                brjSuglas = text.Length - brjSamoglas - brjZnak;
            });
            Action akcija = new Action(() =>
            lblSamoglasnici.Text = $"Sadrzaj info {Environment.NewLine}" + $"Samoglasnici: {brjSamoglas.ToString()}" +
            $"{Environment.NewLine}Suglasnici: {brjSuglas.ToString()}"+
            $"{Environment.NewLine}Znakovi: {brjZnak.ToString()}");
            BeginInvoke(akcija);
        }
    }
}
