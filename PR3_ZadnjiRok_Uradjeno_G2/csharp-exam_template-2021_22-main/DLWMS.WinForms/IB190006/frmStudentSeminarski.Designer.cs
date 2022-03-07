
namespace DLWMS.WinForms.IB190006
{
    partial class frmStudentSeminarski
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbPrikazSlika = new System.Windows.Forms.PictureBox();
            this.btnDesno = new System.Windows.Forms.Button();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrikazSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(276, 24);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 25);
            this.lblStudent.TabIndex = 0;
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmet.Location = new System.Drawing.Point(276, 60);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(0, 25);
            this.lblPredmet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Slika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis:";
            // 
            // pbSlika
            // 
            this.pbSlika.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbSlika.Location = new System.Drawing.Point(56, 131);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(118, 124);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 4;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(233, 131);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(202, 91);
            this.txtOpis.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(360, 232);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbPrikazSlika
            // 
            this.pbPrikazSlika.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbPrikazSlika.Location = new System.Drawing.Point(233, 315);
            this.pbPrikazSlika.Name = "pbPrikazSlika";
            this.pbPrikazSlika.Size = new System.Drawing.Size(116, 148);
            this.pbPrikazSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrikazSlika.TabIndex = 7;
            this.pbPrikazSlika.TabStop = false;
            // 
            // btnDesno
            // 
            this.btnDesno.Location = new System.Drawing.Point(379, 380);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(75, 23);
            this.btnDesno.TabIndex = 8;
            this.btnDesno.Text = "==>";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // btnLijevo
            // 
            this.btnLijevo.Location = new System.Drawing.Point(134, 380);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(75, 23);
            this.btnLijevo.TabIndex = 9;
            this.btnLijevo.Text = "<==";
            this.btnLijevo.UseVisualStyleBackColor = true;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(257, 475);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 13);
            this.lblDatum.TabIndex = 10;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(257, 505);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(0, 13);
            this.lblOpis.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prikaz slika";
            // 
            // frmStudentSeminarski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 552);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnLijevo);
            this.Controls.Add(this.btnDesno);
            this.Controls.Add(this.pbPrikazSlika);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.lblStudent);
            this.Name = "frmStudentSeminarski";
            this.Text = "frmStudentSeminarski";
            this.Load += new System.EventHandler(this.frmStudentSeminarski_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrikazSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.PictureBox pbPrikazSlika;
        private System.Windows.Forms.Label label3;
    }
}