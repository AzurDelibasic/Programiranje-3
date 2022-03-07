
namespace DLWMS.WinForms.BrojIndeksa
{
    partial class frmScanIspita
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.dgvStudentScan = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varanje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Scan = new System.Windows.Forms.DataGridViewImageColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentScan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled ispita za studenta:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(164, 26);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 20);
            this.lblStudent.TabIndex = 1;
            // 
            // dgvStudentScan
            // 
            this.dgvStudentScan.AllowUserToAddRows = false;
            this.dgvStudentScan.AllowUserToDeleteRows = false;
            this.dgvStudentScan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentScan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Napomena,
            this.Varanje,
            this.Scan,
            this.Brisi});
            this.dgvStudentScan.Location = new System.Drawing.Point(30, 63);
            this.dgvStudentScan.Name = "dgvStudentScan";
            this.dgvStudentScan.ReadOnly = true;
            this.dgvStudentScan.Size = new System.Drawing.Size(559, 189);
            this.dgvStudentScan.TabIndex = 2;
            this.dgvStudentScan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentScan_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(499, 21);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj scan";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(499, 261);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Napomena
            // 
            this.Napomena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // Varanje
            // 
            this.Varanje.DataPropertyName = "Varanje";
            this.Varanje.HeaderText = "Varanje";
            this.Varanje.Name = "Varanje";
            this.Varanje.ReadOnly = true;
            // 
            // Scan
            // 
            this.Scan.DataPropertyName = "Scan";
            this.Scan.HeaderText = "Scan ispita";
            this.Scan.Name = "Scan";
            this.Scan.ReadOnly = true;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "";
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Briši";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // frmScanIspita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 291);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvStudentScan);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmScanIspita";
            this.Text = "frmScanIspita";
            this.Load += new System.EventHandler(this.frmScanIspita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.DataGridView dgvStudentScan;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Varanje;
        private System.Windows.Forms.DataGridViewImageColumn Scan;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}