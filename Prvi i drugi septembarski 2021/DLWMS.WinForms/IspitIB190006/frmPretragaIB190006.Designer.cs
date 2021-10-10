
namespace DLWMS.WinForms.IspitIB190006
{
    partial class frmPretragaIB190006
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
            this.dgvStudentiPredmeti = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProsjekPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispiti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNajveciProsjek = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThread = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThread = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSam = new System.Windows.Forms.Label();
            this.lblSug = new System.Windows.Forms.Label();
            this.lblZnak = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ili prezime:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(108, 29);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(455, 20);
            this.txtImePrezime.TabIndex = 1;
            this.txtImePrezime.TextChanged += new System.EventHandler(this.txtImePrezime_TextChanged);
            // 
            // dgvStudentiPredmeti
            // 
            this.dgvStudentiPredmeti.AllowUserToAddRows = false;
            this.dgvStudentiPredmeti.AllowUserToDeleteRows = false;
            this.dgvStudentiPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentiPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Predmeti,
            this.BrojPolozenih,
            this.ProsjekPolozenih,
            this.Ispiti});
            this.dgvStudentiPredmeti.Location = new System.Drawing.Point(36, 65);
            this.dgvStudentiPredmeti.Name = "dgvStudentiPredmeti";
            this.dgvStudentiPredmeti.ReadOnly = true;
            this.dgvStudentiPredmeti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentiPredmeti.Size = new System.Drawing.Size(527, 150);
            this.dgvStudentiPredmeti.TabIndex = 2;
            this.dgvStudentiPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentiPredmeti_CellContentClick);
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Predmeti
            // 
            this.Predmeti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmeti.DataPropertyName = "Predmeti";
            this.Predmeti.HeaderText = "Položeni predmeti";
            this.Predmeti.Name = "Predmeti";
            this.Predmeti.ReadOnly = true;
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.DataPropertyName = "BrojPolozenih";
            this.BrojPolozenih.HeaderText = "Broj položenih";
            this.BrojPolozenih.Name = "BrojPolozenih";
            this.BrojPolozenih.ReadOnly = true;
            // 
            // ProsjekPolozenih
            // 
            this.ProsjekPolozenih.DataPropertyName = "ProsjekPolozenih";
            this.ProsjekPolozenih.HeaderText = "Prosjek položenih";
            this.ProsjekPolozenih.Name = "ProsjekPolozenih";
            this.ProsjekPolozenih.ReadOnly = true;
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
            this.label2.Location = new System.Drawing.Point(33, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prosjek prikazanih ocjena:";
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(170, 232);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(0, 13);
            this.lblProsjek.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Najveći prosjek ostvario:";
            // 
            // lblNajveciProsjek
            // 
            this.lblNajveciProsjek.AutoSize = true;
            this.lblNajveciProsjek.Location = new System.Drawing.Point(422, 232);
            this.lblNajveciProsjek.Name = "lblNajveciProsjek";
            this.lblNajveciProsjek.Size = new System.Drawing.Size(0, 13);
            this.lblNajveciProsjek.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Threading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unesite sadržaj:";
            // 
            // txtThread
            // 
            this.txtThread.Location = new System.Drawing.Point(36, 301);
            this.txtThread.Multiline = true;
            this.txtThread.Name = "txtThread";
            this.txtThread.Size = new System.Drawing.Size(524, 93);
            this.txtThread.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(93, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(463, 2);
            this.label6.TabIndex = 10;
            // 
            // btnThread
            // 
            this.btnThread.Location = new System.Drawing.Point(487, 416);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(75, 23);
            this.btnThread.TabIndex = 11;
            this.btnThread.Text = "Generiši info";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sadržaj:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Samoglasnika:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Suglasnika:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Znakova:";
            // 
            // lblSam
            // 
            this.lblSam.AutoSize = true;
            this.lblSam.Location = new System.Drawing.Point(175, 401);
            this.lblSam.Name = "lblSam";
            this.lblSam.Size = new System.Drawing.Size(0, 13);
            this.lblSam.TabIndex = 16;
            // 
            // lblSug
            // 
            this.lblSug.AutoSize = true;
            this.lblSug.Location = new System.Drawing.Point(161, 421);
            this.lblSug.Name = "lblSug";
            this.lblSug.Size = new System.Drawing.Size(0, 13);
            this.lblSug.TabIndex = 17;
            // 
            // lblZnak
            // 
            this.lblZnak.AutoSize = true;
            this.lblZnak.Location = new System.Drawing.Point(152, 443);
            this.lblZnak.Name = "lblZnak";
            this.lblZnak.Size = new System.Drawing.Size(0, 13);
            this.lblZnak.TabIndex = 18;
            // 
            // frmPretragaIB190006
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 480);
            this.Controls.Add(this.lblZnak);
            this.Controls.Add(this.lblSug);
            this.Controls.Add(this.lblSam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtThread);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNajveciProsjek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStudentiPredmeti);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB190006";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.frmPretragaIB190006_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.DataGridView dgvStudentiPredmeti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNajveciProsjek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProsjekPolozenih;
        private System.Windows.Forms.DataGridViewButtonColumn Ispiti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThread;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThread;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSam;
        private System.Windows.Forms.Label lblSug;
        private System.Windows.Forms.Label lblZnak;
    }
}