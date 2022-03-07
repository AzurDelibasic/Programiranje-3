using DLWMS.WinForms.DB;
using DLWMS.WinForms.Entiteti;
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

namespace DLWMS.WinForms.Forme
{
    public partial class frmSlikeIB190006 : Form
    {
        private StudentiPredmeti _student;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        int brojacSlika = 0;


        public frmSlikeIB190006()
        {
            InitializeComponent();
        }

        public frmSlikeIB190006(StudentiPredmeti zapis) : this()
        {
            this._student = zapis;
            this.Text = zapis.Student.ToString();
        }

        private void frmSlikeIB190006_Load(object sender, EventArgs e)
        {
            UcitajSlike();
        }

        private void UcitajSlike()
        {
            if (_student.Student.SlikeStudenta.Count() != 0)
            {
                var prvaSlika = ImageHelper.FromByteToImage(_student.Student.SlikeStudenta[brojacSlika].Slika);
                pbPrikaz.Image = prvaSlika;
                UcitajDatumOpis(_student.Student.SlikeStudenta[brojacSlika].Datum, _student.Student.SlikeStudenta[brojacSlika].Opis);
            }
        }

        private void UcitajDatumOpis(DateTime datum, string opis)
        {
            lblDatum.Text = datum.ToString("dd.MM.yyyy");
            lblOpis.Text = opis;
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var novaSlika = new StudentiSlike()
                {
                    Student = _student.Student,
                    Datum = DateTime.Now,
                    Opis = txtOpis.Text,
                    Slika = ImageHelper.FromImageToByte(pbSlika.Image)
                };
                _baza.StudentiSlike.Add(novaSlika);
                _baza.SaveChanges();
                Ocisti();
                UcitajSlike();
                MessageBox.Show("Uspjesno dodana slika!","Obavijest");
            }
        }

        private void Ocisti()
        {
            txtOpis.Clear();
            pbSlika.Image = null;
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtOpis, err, Poruke.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost);
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            btnDesno.Enabled = true;
            var brojac = brojacSlika - 1;
            if (brojac >= 0)
            {
                brojacSlika--;
                var prvaSlika = ImageHelper.FromByteToImage(_student.Student.SlikeStudenta[brojacSlika].Slika);
                pbPrikaz.Image = prvaSlika;
                UcitajDatumOpis(_student.Student.SlikeStudenta[brojacSlika].Datum, _student.Student.SlikeStudenta[brojacSlika].Opis);
            }
            else
            {
                btnLijevo.Enabled = false;
            }
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            btnLijevo.Enabled = true;
            var brojac = brojacSlika + 1;
            if (brojac < _student.Student.SlikeStudenta.Count())
            {
                brojacSlika++;
                var prvaSlika = ImageHelper.FromByteToImage(_student.Student.SlikeStudenta[brojacSlika].Slika);
                pbPrikaz.Image = prvaSlika;
                UcitajDatumOpis(_student.Student.SlikeStudenta[brojacSlika].Datum, _student.Student.SlikeStudenta[brojacSlika].Opis);
            }
            else
            {
                btnDesno.Enabled = false;
            }
        }
    }
}
