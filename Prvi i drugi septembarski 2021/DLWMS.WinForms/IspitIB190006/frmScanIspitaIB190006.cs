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
    public partial class frmScanIspitaIB190006 : Form
    {
        private Student _student;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        public frmScanIspitaIB190006()
        {
            InitializeComponent();
            dgvScan.AutoGenerateColumns = false;
        }
        public frmScanIspitaIB190006(Student student) : this()
        {
            _student = student;
        }

        private void frmScanIspitaIB190006_Load(object sender, EventArgs e)
        {
            lblStudent.Text = _student.ToString();
            UcitajSkenove();
        }

        private void UcitajSkenove()
        {
            dgvScan.DataSource = null;   
            dgvScan.DataSource = _baza.StudentiIspitiScan.Where(x => x.Student.Id == _student.Id).ToList();
        }

        private void btnDodajScan_Click(object sender, EventArgs e)
        {
            frmNoviScanIspitaIB190006 frm = new frmNoviScanIspitaIB190006(_student);
            frm.ShowDialog();
            UcitajSkenove();
        }

        private void dgvScan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var scan = dgvScan.Rows[e.RowIndex].DataBoundItem as StudentiIspitiScan;
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Da li želite obrisati ovaj scan?", "!?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _baza.StudentiIspitiScan.Remove(scan);
                    _baza.SaveChanges();
                    UcitajSkenove();
                }
            }
            else
            {
                frmNoviScanIspitaIB190006 frm = new frmNoviScanIspitaIB190006(scan);
                frm.ShowDialog();
            }
        }
    }
}
