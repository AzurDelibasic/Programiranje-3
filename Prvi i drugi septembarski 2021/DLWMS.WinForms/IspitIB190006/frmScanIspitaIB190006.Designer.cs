
namespace DLWMS.WinForms.IspitIB190006
{
    partial class frmScanIspitaIB190006
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
            this.dgvScan = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varanje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Scan = new System.Windows.Forms.DataGridViewImageColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDodajScan = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled ispita za studenta:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(158, 32);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 22);
            this.lblStudent.TabIndex = 1;
            // 
            // dgvScan
            // 
            this.dgvScan.AllowUserToAddRows = false;
            this.dgvScan.AllowUserToDeleteRows = false;
            this.dgvScan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Napomena,
            this.Varanje,
            this.Scan,
            this.Brisi});
            this.dgvScan.Location = new System.Drawing.Point(24, 65);
            this.dgvScan.Name = "dgvScan";
            this.dgvScan.ReadOnly = true;
            this.dgvScan.Size = new System.Drawing.Size(548, 178);
            this.dgvScan.TabIndex = 2;
            this.dgvScan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScan_CellContentClick);
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
            this.Scan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "";
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Briši";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // btnDodajScan
            // 
            this.btnDodajScan.Location = new System.Drawing.Point(460, 36);
            this.btnDodajScan.Name = "btnDodajScan";
            this.btnDodajScan.Size = new System.Drawing.Size(112, 23);
            this.btnDodajScan.TabIndex = 3;
            this.btnDodajScan.Text = "Dodaj scan ispita";
            this.btnDodajScan.UseVisualStyleBackColor = true;
            this.btnDodajScan.Click += new System.EventHandler(this.btnDodajScan_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(460, 249);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(112, 23);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // frmScanIspitaIB190006
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 282);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnDodajScan);
            this.Controls.Add(this.dgvScan);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmScanIspitaIB190006";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studenti Ispiti - SCANOVI";
            this.Load += new System.EventHandler(this.frmScanIspitaIB190006_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.DataGridView dgvScan;
        private System.Windows.Forms.Button btnDodajScan;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Varanje;
        private System.Windows.Forms.DataGridViewImageColumn Scan;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}