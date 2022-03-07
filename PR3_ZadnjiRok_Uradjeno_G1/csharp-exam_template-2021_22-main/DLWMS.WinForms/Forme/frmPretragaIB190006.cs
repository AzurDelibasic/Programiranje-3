using DLWMS.WinForms.DB;
using DLWMS.WinForms.Entiteti;
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

namespace DLWMS.WinForms.Forme
{
    public partial class frmPretragaIB190006 : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        List<StudentiPredmeti> listaStudenata;
        string filter = "";
        public frmPretragaIB190006()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmPretragaIB190006_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = Filtriraj();
        }

        private List<StudentiPredmeti> Filtriraj()
        {
            listaStudenata = _db.StudentiPredmeti.Where(p => filter == "" || p.Predmet.Naziv.ToLower().Contains(filter)).ToList();
            this.Text = $"Ukupno zapisa: {listaStudenata.Count()}";
            return listaStudenata;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            filter = txtPretraga.Text.ToLower();
            UcitajPodatke();
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            var frmIzvjestaj = new Reports.frmIzvjestaj(listaStudenata);
            frmIzvjestaj.ShowDialog();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var zapis = dgvStudenti.Rows[e.RowIndex].DataBoundItem as StudentiPredmeti;
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Da li ste sigurni da zelite izbrisati ovaj zapis?", "Obavijest", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _db.StudentiPredmeti.Remove(zapis);
                    _db.SaveChanges();
                    UcitajPodatke();
                }
            }
            if (e.ColumnIndex == 5)
            {
                Form frm = new frmSlikeIB190006(zapis);
                frm.ShowDialog();
            }
        }

        private async void btnSuma_Click(object sender, EventArgs e)
        {
            var odBroja = int.Parse(txtOdBroja.Text);
            var doBroja = int.Parse(txtDoBroja.Text);
            double suma = 0;
            await Task.Run(() =>
            {
                if (txtOdBroja.Text != "" && txtDoBroja.Text != "")
                {
                    for (int i = odBroja; i <= doBroja; i++)
                    {
                        Thread.Sleep(50);
                        suma += i;
                    }
                }
            });
            Action akcija = () => txtSuma.Text = suma.ToString();
            BeginInvoke(akcija);
        }
    }
}
