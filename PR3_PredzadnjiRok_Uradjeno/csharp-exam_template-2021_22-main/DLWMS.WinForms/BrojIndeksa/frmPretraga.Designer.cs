
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
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.dgvStudentiPolozeni = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolozeniPredmeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispiti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNajboljiProsjek = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.lblSamoglasnici = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPolozeni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ili prezime:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(108, 33);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(468, 20);
            this.txtImePrezime.TabIndex = 1;
            this.txtImePrezime.TextChanged += new System.EventHandler(this.txtImePrezime_TextChanged);
            // 
            // dgvStudentiPolozeni
            // 
            this.dgvStudentiPolozeni.AllowUserToAddRows = false;
            this.dgvStudentiPolozeni.AllowUserToDeleteRows = false;
            this.dgvStudentiPolozeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentiPolozeni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.PolozeniPredmeti,
            this.BrojPolozenih,
            this.Prosjek,
            this.Ispiti});
            this.dgvStudentiPolozeni.Location = new System.Drawing.Point(30, 68);
            this.dgvStudentiPolozeni.Name = "dgvStudentiPolozeni";
            this.dgvStudentiPolozeni.ReadOnly = true;
            this.dgvStudentiPolozeni.Size = new System.Drawing.Size(546, 162);
            this.dgvStudentiPolozeni.TabIndex = 2;
            this.dgvStudentiPolozeni.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentiPolozeni_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "Student";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // PolozeniPredmeti
            // 
            this.PolozeniPredmeti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PolozeniPredmeti.DataPropertyName = "Polozeni";
            this.PolozeniPredmeti.HeaderText = "Polozeni predmeti";
            this.PolozeniPredmeti.Name = "PolozeniPredmeti";
            this.PolozeniPredmeti.ReadOnly = true;
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.DataPropertyName = "BrojPolozenih";
            this.BrojPolozenih.HeaderText = "Broj polozenih";
            this.BrojPolozenih.Name = "BrojPolozenih";
            this.BrojPolozenih.ReadOnly = true;
            // 
            // Prosjek
            // 
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            // 
            // Ispiti
            // 
            this.Ispiti.HeaderText = "";
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.ReadOnly = true;
            this.Ispiti.Text = "Ispiti";
            this.Ispiti.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prosjek prikazanih ocjena:";
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(164, 247);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(0, 13);
            this.lblProsjek.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Najbolji prosjek ostvario:";
            // 
            // lblNajboljiProsjek
            // 
            this.lblNajboljiProsjek.AutoSize = true;
            this.lblNajboljiProsjek.Location = new System.Drawing.Point(434, 247);
            this.lblNajboljiProsjek.Name = "lblNajboljiProsjek";
            this.lblNajboljiProsjek.Size = new System.Drawing.Size(0, 13);
            this.lblNajboljiProsjek.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 291);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 63);
            this.textBox1.TabIndex = 7;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(501, 372);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(75, 23);
            this.btnGenerisi.TabIndex = 8;
            this.btnGenerisi.Text = "Generisi info";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // lblSamoglasnici
            // 
            this.lblSamoglasnici.AutoSize = true;
            this.lblSamoglasnici.Location = new System.Drawing.Point(35, 359);
            this.lblSamoglasnici.Name = "lblSamoglasnici";
            this.lblSamoglasnici.Size = new System.Drawing.Size(0, 13);
            this.lblSamoglasnici.TabIndex = 9;
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 414);
            this.Controls.Add(this.lblSamoglasnici);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNajboljiProsjek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStudentiPolozeni);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label1);
            this.Name = "frmPretraga";
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.frmPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPolozeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.DataGridView dgvStudentiPolozeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNajboljiProsjek;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolozeniPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewButtonColumn Ispiti;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Label lblSamoglasnici;
    }
}