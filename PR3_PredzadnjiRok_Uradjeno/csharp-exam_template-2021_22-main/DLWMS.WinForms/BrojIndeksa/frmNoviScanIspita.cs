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

namespace DLWMS.WinForms.BrojIndeksa
{
    public partial class frmNoviScanIspita : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        private StudentiIspitiScan scan;
        private Student student;
        bool pregled = false;

        public frmNoviScanIspita()
        {
            InitializeComponent();
        }

        public frmNoviScanIspita(StudentiIspitiScan scan) : this()
        {
            this.scan = scan;
            pregled = true;
        }

        public frmNoviScanIspita(Student student) : this()
        {
            this.student = student;
        }

        private void frmNoviScanIspita_Load(object sender, EventArgs e)
        {
            if (pregled)
            {
                cbPredmet.Enabled = false;
                cbPredmet.Text = scan.Predmet.ToString();
                txtNapomena.Enabled = false;
                txtNapomena.Text = scan.Napomena;
                chbVaranje.Enabled = false;
                chbVaranje.Checked = scan.Varanje;
                pbSlika.Enabled = false;
                pbSlika.Image = ImageHelper.FromByteToImage(scan.Scan);
                btnSpasi.Enabled = false;
            }
            else
            {
                UcitajPredmete();
            }
        }

        private void UcitajPredmete()
        {
            cbPredmet.DataSource = _baza.Predmeti.ToList();
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var noviZapis = new StudentiIspitiScan
                {
                    Student = student,
                    Napomena = txtNapomena.Text,
                    Predmet = cbPredmet.SelectedItem as Predmeti,
                    Varanje = chbVaranje.Checked,
                    Scan = ImageHelper.FromImageToByte(pbSlika.Image)
                };
                _baza.StudentiIspitiScan.Add(noviZapis);
                _baza.SaveChanges();
                Close();
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(cbPredmet, err, Poruke.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu(txtNapomena, err, Poruke.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost);
        }
    }
}
