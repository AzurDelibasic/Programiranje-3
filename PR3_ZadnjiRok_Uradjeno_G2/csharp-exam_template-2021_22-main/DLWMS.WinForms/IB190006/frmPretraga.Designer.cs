
namespace DLWMS.WinForms.IB190006
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
            this.cbMinOcjena = new System.Windows.Forms.ComboBox();
            this.dgvStudentiPredmeti = new System.Windows.Forms.DataGridView();
            this.Rb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seminarski = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojOcjena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtGenerisani = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimalna ocjena:";
            // 
            // cbMinOcjena
            // 
            this.cbMinOcjena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinOcjena.FormattingEnabled = true;
            this.cbMinOcjena.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbMinOcjena.Location = new System.Drawing.Point(120, 33);
            this.cbMinOcjena.Name = "cbMinOcjena";
            this.cbMinOcjena.Size = new System.Drawing.Size(77, 21);
            this.cbMinOcjena.TabIndex = 1;
            // 
            // dgvStudentiPredmeti
            // 
            this.dgvStudentiPredmeti.AllowUserToAddRows = false;
            this.dgvStudentiPredmeti.AllowUserToDeleteRows = false;
            this.dgvStudentiPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentiPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rb,
            this.ImePrezime,
            this.Predmet,
            this.Datum,
            this.Ocjena,
            this.Seminarski});
            this.dgvStudentiPredmeti.Location = new System.Drawing.Point(25, 70);
            this.dgvStudentiPredmeti.Name = "dgvStudentiPredmeti";
            this.dgvStudentiPredmeti.ReadOnly = true;
            this.dgvStudentiPredmeti.Size = new System.Drawing.Size(496, 174);
            this.dgvStudentiPredmeti.TabIndex = 2;
            this.dgvStudentiPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentiPredmeti_CellContentClick);
            // 
            // Rb
            // 
            this.Rb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Rb.DataPropertyName = "Id";
            this.Rb.HeaderText = "Rb";
            this.Rb.Name = "Rb";
            this.Rb.ReadOnly = true;
            this.Rb.Width = 46;
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "Student";
            this.ImePrezime.HeaderText = "Ime Prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "DatumPolaganja";
            this.Datum.HeaderText = "Datum polaganja";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Width = 66;
            // 
            // Seminarski
            // 
            this.Seminarski.HeaderText = "";
            this.Seminarski.Name = "Seminarski";
            this.Seminarski.ReadOnly = true;
            this.Seminarski.Text = "Seminarski";
            this.Seminarski.UseColumnTextForButtonValue = true;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(215, 31);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(75, 23);
            this.btnFiltriraj.TabIndex = 3;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(446, 260);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dodavanje ocjena";
            // 
            // txtBrojOcjena
            // 
            this.txtBrojOcjena.Location = new System.Drawing.Point(36, 300);
            this.txtBrojOcjena.Name = "txtBrojOcjena";
            this.txtBrojOcjena.Size = new System.Drawing.Size(100, 20);
            this.txtBrojOcjena.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj ocjena:";
            // 
            // cbStudent
            // 
            this.cbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudent.Location = new System.Drawing.Point(36, 345);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(100, 21);
            this.cbStudent.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Student:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(139, 322);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "DODAJ =>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtGenerisani
            // 
            this.txtGenerisani.Location = new System.Drawing.Point(224, 286);
            this.txtGenerisani.Multiline = true;
            this.txtGenerisani.Name = "txtGenerisani";
            this.txtGenerisani.Size = new System.Drawing.Size(209, 80);
            this.txtGenerisani.TabIndex = 11;
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 378);
            this.Controls.Add(this.txtGenerisani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrojOcjena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.dgvStudentiPredmeti);
            this.Controls.Add(this.cbMinOcjena);
            this.Controls.Add(this.label1);
            this.Name = "frmPretraga";
            this.Text = "frmPretraga";
            this.Load += new System.EventHandler(this.frmPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMinOcjena;
        private System.Windows.Forms.DataGridView dgvStudentiPredmeti;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Seminarski;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojOcjena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtGenerisani;
    }
}