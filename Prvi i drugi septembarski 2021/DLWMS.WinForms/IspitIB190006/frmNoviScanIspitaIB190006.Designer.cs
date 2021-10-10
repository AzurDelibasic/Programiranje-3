
namespace DLWMS.WinForms.IspitIB190006
{
    partial class frmNoviScanIspitaIB190006
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
            this.cbPredmeti = new System.Windows.Forms.ComboBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.chbVaranje = new System.Windows.Forms.CheckBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.ofdScan = new System.Windows.Forms.OpenFileDialog();
            this.pbScan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predmet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Napomena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Slika:";
            // 
            // cbPredmeti
            // 
            this.cbPredmeti.FormattingEnabled = true;
            this.cbPredmeti.Location = new System.Drawing.Point(33, 60);
            this.cbPredmeti.Name = "cbPredmeti";
            this.cbPredmeti.Size = new System.Drawing.Size(210, 21);
            this.cbPredmeti.TabIndex = 3;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(33, 107);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(210, 199);
            this.txtNapomena.TabIndex = 4;
            // 
            // chbVaranje
            // 
            this.chbVaranje.AutoSize = true;
            this.chbVaranje.Location = new System.Drawing.Point(33, 328);
            this.chbVaranje.Name = "chbVaranje";
            this.chbVaranje.Size = new System.Drawing.Size(104, 17);
            this.chbVaranje.TabIndex = 6;
            this.chbVaranje.Text = "Varanje na ispitu";
            this.chbVaranje.UseVisualStyleBackColor = true;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(376, 324);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 7;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // ofdScan
            // 
            this.ofdScan.FileName = "openFileDialog1";
            // 
            // pbScan
            // 
            this.pbScan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbScan.Location = new System.Drawing.Point(263, 60);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(188, 246);
            this.pbScan.TabIndex = 5;
            this.pbScan.TabStop = false;
            this.pbScan.Click += new System.EventHandler(this.pbScan_Click);
            // 
            // frmNoviScanIspitaIB190006
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 364);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.chbVaranje);
            this.Controls.Add(this.pbScan);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.cbPredmeti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNoviScanIspitaIB190006";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scan ispita";
            this.Load += new System.EventHandler(this.frmNoviScanIspitaIB190006_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPredmeti;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.PictureBox pbScan;
        private System.Windows.Forms.CheckBox chbVaranje;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.OpenFileDialog ofdScan;
    }
}