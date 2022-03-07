
namespace DLWMS.WinForms.Forme
{
    partial class frmSlikeIB190006
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
            this.components = new System.ComponentModel.Container();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPrikaz = new System.Windows.Forms.PictureBox();
            this.btnDesno = new System.Windows.Forms.Button();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbSlika
            // 
            this.pbSlika.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbSlika.Location = new System.Drawing.Point(39, 32);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(125, 123);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 0;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(180, 32);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(306, 86);
            this.txtOpis.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(402, 128);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj Sliku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pogledaj slike";
            // 
            // pbPrikaz
            // 
            this.pbPrikaz.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbPrikaz.Location = new System.Drawing.Point(209, 200);
            this.pbPrikaz.Name = "pbPrikaz";
            this.pbPrikaz.Size = new System.Drawing.Size(166, 166);
            this.pbPrikaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrikaz.TabIndex = 4;
            this.pbPrikaz.TabStop = false;
            // 
            // btnDesno
            // 
            this.btnDesno.Location = new System.Drawing.Point(390, 271);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(75, 23);
            this.btnDesno.TabIndex = 5;
            this.btnDesno.Text = "==>";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // btnLijevo
            // 
            this.btnLijevo.Location = new System.Drawing.Point(114, 271);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(75, 23);
            this.btnLijevo.TabIndex = 6;
            this.btnLijevo.Text = "<==";
            this.btnLijevo.UseVisualStyleBackColor = true;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(247, 375);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 13);
            this.lblDatum.TabIndex = 7;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(247, 402);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(0, 13);
            this.lblOpis.TabIndex = 8;
            // 
            // frmSlikeIB190006
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 461);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnLijevo);
            this.Controls.Add(this.btnDesno);
            this.Controls.Add(this.pbPrikaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.pbSlika);
            this.Name = "frmSlikeIB190006";
            this.Text = "Slike";
            this.Load += new System.EventHandler(this.frmSlikeIB190006_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.PictureBox pbPrikaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}