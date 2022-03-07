
namespace DLWMS.WinForms.BrojIndeksa
{
    partial class frmPretraga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtmDo = new System.Windows.Forms.DateTimePicker();
            this.cbOcjena = new System.Windows.Forms.ComboBox();
            this.cbZnak = new System.Windows.Forms.ComboBox();
            this.dgvPregled = new System.Windows.Forms.DataGridView();
            this.btnCovid = new System.Windows.Forms.Button();
            this.lblBrojStudenata = new System.Windows.Forms.Label();
            this.lblProsjecnaOcjena = new System.Windows.Forms.Label();
            this.Indeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaStudija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ocjena:";
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(41, 23);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(200, 20);
            this.dtpOd.TabIndex = 3;
            // 
            // dtmDo
            // 
            this.dtmDo.Location = new System.Drawing.Point(288, 23);
            this.dtmDo.Name = "dtmDo";
            this.dtmDo.Size = new System.Drawing.Size(200, 20);
            this.dtmDo.TabIndex = 4;
            // 
            // cbOcjena
            // 
            this.cbOcjena.FormattingEnabled = true;
            this.cbOcjena.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbOcjena.Location = new System.Drawing.Point(554, 21);
            this.cbOcjena.Name = "cbOcjena";
            this.cbOcjena.Size = new System.Drawing.Size(42, 21);
            this.cbOcjena.TabIndex = 5;
            // 
            // cbZnak
            // 
            this.cbZnak.FormattingEnabled = true;
            this.cbZnak.Items.AddRange(new object[] {
            "<",
            ">",
            "=",
            "<=",
            ">="});
            this.cbZnak.Location = new System.Drawing.Point(613, 21);
            this.cbZnak.Name = "cbZnak";
            this.cbZnak.Size = new System.Drawing.Size(42, 21);
            this.cbZnak.TabIndex = 6;
            // 
            // dgvPregled
            // 
            this.dgvPregled.AllowUserToAddRows = false;
            this.dgvPregled.AllowUserToDeleteRows = false;
            this.dgvPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indeks,
            this.Ime,
            this.Prezime,
            this.GodinaStudija,
            this.Aktivan,
            this.Polozeni});
            this.dgvPregled.Location = new System.Drawing.Point(24, 58);
            this.dgvPregled.Name = "dgvPregled";
            this.dgvPregled.ReadOnly = true;
            this.dgvPregled.Size = new System.Drawing.Size(631, 203);
            this.dgvPregled.TabIndex = 7;
            // 
            // btnCovid
            // 
            this.btnCovid.Location = new System.Drawing.Point(580, 271);
            this.btnCovid.Name = "btnCovid";
            this.btnCovid.Size = new System.Drawing.Size(75, 23);
            this.btnCovid.TabIndex = 8;
            this.btnCovid.Text = "COVID";
            this.btnCovid.UseVisualStyleBackColor = true;
            // 
            // lblBrojStudenata
            // 
            this.lblBrojStudenata.AutoSize = true;
            this.lblBrojStudenata.Location = new System.Drawing.Point(25, 267);
            this.lblBrojStudenata.Name = "lblBrojStudenata";
            this.lblBrojStudenata.Size = new System.Drawing.Size(81, 13);
            this.lblBrojStudenata.TabIndex = 9;
            this.lblBrojStudenata.Text = "Broj studenata: ";
            // 
            // lblProsjecnaOcjena
            // 
            this.lblProsjecnaOcjena.AutoSize = true;
            this.lblProsjecnaOcjena.Location = new System.Drawing.Point(25, 284);
            this.lblProsjecnaOcjena.Name = "lblProsjecnaOcjena";
            this.lblProsjecnaOcjena.Size = new System.Drawing.Size(95, 13);
            this.lblProsjecnaOcjena.TabIndex = 10;
            this.lblProsjecnaOcjena.Text = "Prosjecna ocjena: ";
            // 
            // Indeks
            // 
            this.Indeks.DataPropertyName = "Indeks";
            this.Indeks.HeaderText = "Indeks";
            this.Indeks.Name = "Indeks";
            this.Indeks.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // GodinaStudija
            // 
            this.GodinaStudija.DataPropertyName = "GodinaStudija";
            this.GodinaStudija.HeaderText = "Godina studija";
            this.GodinaStudija.Name = "GodinaStudija";
            this.GodinaStudija.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            // 
            // Polozeni
            // 
            this.Polozeni.HeaderText = "Polozeni";
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.ReadOnly = true;
            this.Polozeni.Text = "Polozeni";
            this.Polozeni.UseColumnTextForButtonValue = true;
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 302);
            this.Controls.Add(this.lblProsjecnaOcjena);
            this.Controls.Add(this.lblBrojStudenata);
            this.Controls.Add(this.btnCovid);
            this.Controls.Add(this.dgvPregled);
            this.Controls.Add(this.cbZnak);
            this.Controls.Add(this.cbOcjena);
            this.Controls.Add(this.dtmDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPretraga";
            this.Text = "frmPretraga";
            this.Load += new System.EventHandler(this.frmPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtmDo;
        private System.Windows.Forms.ComboBox cbOcjena;
        private System.Windows.Forms.ComboBox cbZnak;
        private System.Windows.Forms.DataGridView dgvPregled;
        private System.Windows.Forms.Button btnCovid;
        private System.Windows.Forms.Label lblBrojStudenata;
        private System.Windows.Forms.Label lblProsjecnaOcjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaStudija;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewButtonColumn Polozeni;
    }
}