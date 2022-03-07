using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.P5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB190006
{
    public partial class frmStudentSeminarski : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        private StudentiPredmeti studentpredmeti;
        int brojacSlika = 0;

        public frmStudentSeminarski()
        {
            InitializeComponent();
        }

        public frmStudentSeminarski(StudentiPredmeti studentpredmeti) : this()
        {
            this.studentpredmeti = studentpredmeti;
        }

        private void frmStudentSeminarski_Load(object sender, EventArgs e)
        {
            lblStudent.Text = studentpredmeti.Student.ToString();
            lblPredmet.Text = studentpredmeti.Predmet.Naziv.ToString();
            UcitajSlike();
        }

        private void UcitajSlike()
        {
           if (studentpredmeti.Predmet.SlikeSeminarskih.Count() != 0)
            {
                var prva = studentpredmeti.Predmet.SlikeSeminarskih[brojacSlika];
                pbPrikazSlika.Image = ImageHelper.FromByteToImage(prva.Slika);
                PrikaziDatumOpis(prva.DatumDodavanja, prva.Opis);
            }
        }

        private void PrikaziDatumOpis(DateTime datum, string opis)
        {
            lblDatum.Text = datum.ToString("dd.MM.yyyy HH:mm");
            lblOpis.Text = opis;
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var zapis = new PredmetiSeminarski()
                {
                    Student = studentpredmeti.Student,
                    Predmet = studentpredmeti.Predmet,
                    Slika = ImageHelper.FromImageToByte(pbSlika.Image),
                    Opis = txtOpis.Text,
                    DatumDodavanja = DateTime.Now
                };
                studentpredmeti.Predmet.SlikeSeminarskih.Add(zapis);
                _baza.SaveChanges();
                MessageBox.Show("Uspjesno dodano!","Obavijest");
                OcistiPolja();
                UcitajSlike();
            }
        }

        private void OcistiPolja()
        {
            pbSlika.Image = null;
            txtOpis.Clear();
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu(txtOpis, err, Poruke.ObaveznaVrijednost);
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            int brojac = brojacSlika - 1;
            if (brojac >= 0)
            {
                brojacSlika--;
                var prva = studentpredmeti.Predmet.SlikeSeminarskih[brojacSlika];
                pbPrikazSlika.Image = ImageHelper.FromByteToImage(prva.Slika);
                PrikaziDatumOpis(prva.DatumDodavanja, prva.Opis);
            }
            else
            {
                MessageBox.Show("Nema više slika","Obavijest");
            }
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            int brojac = brojacSlika + 1;
            if (brojac < studentpredmeti.Predmet.SlikeSeminarskih.Count())
            {
                brojacSlika++;
                var prva = studentpredmeti.Predmet.SlikeSeminarskih[brojacSlika];
                pbPrikazSlika.Image = ImageHelper.FromByteToImage(prva.Slika);
                PrikaziDatumOpis(prva.DatumDodavanja, prva.Opis);
            }
            else
            {
                MessageBox.Show("Nema više slika", "Obavijest");
            }
        }
    }
}
