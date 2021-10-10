using DLWMS.WinForms.Entiteti;
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
    public partial class frmNoviScanIspitaIB190006 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        StudentiIspitiScan _sken;
        Student _student;
        bool _view = false;
        public frmNoviScanIspitaIB190006()
        {
            InitializeComponent();
        }
        public frmNoviScanIspitaIB190006(StudentiIspitiScan sken) : this()
        {
            _sken = sken;
            _view = true;
        }
        public frmNoviScanIspitaIB190006(Student student) : this()
        {
            _student = student;
        }

        private void frmNoviScanIspitaIB190006_Load(object sender, EventArgs e)
        {
            if (_view)
            {
                cbPredmeti.Text = _sken.Predmet.ToString();
                cbPredmeti.Enabled = false;
                txtNapomena.Text = _sken.Napomena;
                txtNapomena.Enabled = false;
                chbVaranje.Checked = _sken.Varanje;
                chbVaranje.Enabled = false;
                //pbScan.Image = ImageHelper.FromByteToImage(_sken.Scan);
                pbScan.Enabled = false;
                btnSpasi.Enabled = false;
            }
            else
            {
                UcitajPredmete();
            }
        }

        private void UcitajPredmete()
        {
            cbPredmeti.DataSource = _baza.Predmet.ToList();
        }

        private void pbScan_Click(object sender, EventArgs e)
        {
            if (ofdScan.ShowDialog() == DialogResult.OK)
            {
                pbScan.Image = Image.FromFile(ofdScan.FileName);
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            _baza.StudentiIspitiScan.Add(new StudentiIspitiScan
            {
                Student = _student as Student,
                Predmet = cbPredmeti.SelectedItem as Predmet,
                Napomena = txtNapomena.Text,
                //Scan = ImageHelper.FromImageToByte(pbScan.Image),
                Varanje = chbVaranje.Checked
            }) ;
            _baza.SaveChanges();
            Close();
        }
    }
}