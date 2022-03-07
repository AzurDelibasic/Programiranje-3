using DLWMS.WinForms.DB;
using DLWMS.WinForms.Reports;
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
    public partial class frmScanIspita : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        private Student student;

        public frmScanIspita()
        {
            InitializeComponent();
            dgvStudentScan.AutoGenerateColumns = false;
        }

        public frmScanIspita(Student student) : this()
        {
            this.student = student;
        }

        private void frmScanIspita_Load(object sender, EventArgs e)
        {
            lblStudent.Text = student.ToString();
            UcitajSkenove();
        }

        private void UcitajSkenove()
        {
            dgvStudentScan.DataSource = _baza.StudentiIspitiScan.Where(x => x.Student.Id == student.Id).ToList();
        }

        private void dgvStudentScan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var scan = dgvStudentScan.Rows[e.RowIndex].DataBoundItem as StudentiIspitiScan;
            if (e.ColumnIndex == 4)
            {
                if(MessageBox.Show("Da li ste sigurni da zelite izbrisati ovaj zapis?","Obavijest",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    _baza.StudentiIspitiScan.Remove(scan);
                    _baza.SaveChanges();
                    UcitajSkenove();
                }
            }
            else
            {
                var forma = new frmNoviScanIspita(scan);
                forma.ShowDialog();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var forma = new frmNoviScanIspita(student);
            forma.ShowDialog();
            UcitajSkenove();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var skenovi = dgvStudentScan.DataSource as List<StudentiIspitiScan>;
            var forma = new frmIzvjestaj(skenovi);
            forma.ShowDialog();
        }
    }
}
