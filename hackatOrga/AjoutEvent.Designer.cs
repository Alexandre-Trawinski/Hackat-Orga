
namespace hackatOrga
{
    partial class AjoutEvent
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
            this.cbHackathons = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.tbImg = new System.Windows.Forms.TextBox();
            this.tbSalle = new System.Windows.Forms.TextBox();
            this.tbIntervenant = new System.Windows.Forms.TextBox();
            this.nmPlaces = new System.Windows.Forms.NumericUpDown();
            this.radioConf = new System.Windows.Forms.RadioButton();
            this.radioAtelier = new System.Windows.Forms.RadioButton();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHackathons
            // 
            this.cbHackathons.FormattingEnabled = true;
            this.cbHackathons.Location = new System.Drawing.Point(61, 76);
            this.cbHackathons.Name = "cbHackathons";
            this.cbHackathons.Size = new System.Drawing.Size(121, 23);
            this.cbHackathons.TabIndex = 0;
            this.cbHackathons.SelectedIndexChanged += new System.EventHandler(this.cbHackathon_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFin);
            this.groupBox1.Controls.Add(this.dtpDebut);
            this.groupBox1.Controls.Add(this.dtDate);
            this.groupBox1.Location = new System.Drawing.Point(54, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horaires";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Heure de fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Heure de début :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date :";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFin.Location = new System.Drawing.Point(124, 173);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 23);
            this.dtpFin.TabIndex = 2;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDebut.Location = new System.Drawing.Point(124, 102);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 23);
            this.dtpDebut.TabIndex = 1;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(124, 37);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 23);
            this.dtDate.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Choisissez le hackathon :";
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(624, 75);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(100, 23);
            this.tbLibelle.TabIndex = 3;
            // 
            // tbImg
            // 
            this.tbImg.Location = new System.Drawing.Point(645, 178);
            this.tbImg.Name = "tbImg";
            this.tbImg.Size = new System.Drawing.Size(100, 23);
            this.tbImg.TabIndex = 4;
            this.tbImg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbSalle
            // 
            this.tbSalle.Location = new System.Drawing.Point(624, 126);
            this.tbSalle.Name = "tbSalle";
            this.tbSalle.Size = new System.Drawing.Size(100, 23);
            this.tbSalle.TabIndex = 5;
            // 
            // tbIntervenant
            // 
            this.tbIntervenant.Location = new System.Drawing.Point(657, 356);
            this.tbIntervenant.Name = "tbIntervenant";
            this.tbIntervenant.Size = new System.Drawing.Size(100, 23);
            this.tbIntervenant.TabIndex = 6;
            // 
            // nmPlaces
            // 
            this.nmPlaces.Location = new System.Drawing.Point(691, 307);
            this.nmPlaces.Name = "nmPlaces";
            this.nmPlaces.Size = new System.Drawing.Size(120, 23);
            this.nmPlaces.TabIndex = 7;
            // 
            // radioConf
            // 
            this.radioConf.AutoSize = true;
            this.radioConf.Location = new System.Drawing.Point(624, 253);
            this.radioConf.Name = "radioConf";
            this.radioConf.Size = new System.Drawing.Size(86, 19);
            this.radioConf.TabIndex = 8;
            this.radioConf.TabStop = true;
            this.radioConf.Text = "Conférence";
            this.radioConf.UseVisualStyleBackColor = true;
            this.radioConf.CheckedChanged += new System.EventHandler(this.radioConf_CheckedChanged);
            // 
            // radioAtelier
            // 
            this.radioAtelier.AutoSize = true;
            this.radioAtelier.Location = new System.Drawing.Point(716, 253);
            this.radioAtelier.Name = "radioAtelier";
            this.radioAtelier.Size = new System.Drawing.Size(59, 19);
            this.radioAtelier.TabIndex = 9;
            this.radioAtelier.TabStop = true;
            this.radioAtelier.Text = "Atelier";
            this.radioAtelier.UseVisualStyleBackColor = true;
            this.radioAtelier.CheckedChanged += new System.EventHandler(this.radioAtelier_CheckedChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(624, 439);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(120, 49);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Libelle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Image (URL)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Salle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombre de places";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(567, 359);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Intervenant";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(567, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Type";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // AjoutEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 556);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.radioAtelier);
            this.Controls.Add(this.radioConf);
            this.Controls.Add(this.nmPlaces);
            this.Controls.Add(this.tbIntervenant);
            this.Controls.Add(this.tbSalle);
            this.Controls.Add(this.tbImg);
            this.Controls.Add(this.tbLibelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbHackathons);
            this.Name = "AjoutEvent";
            this.Text = "Ajouter un événement";
            this.Load += new System.EventHandler(this.AjoutEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHackathons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.TextBox tbImg;
        private System.Windows.Forms.TextBox tbSalle;
        private System.Windows.Forms.TextBox tbIntervenant;
        private System.Windows.Forms.NumericUpDown nmPlaces;
        private System.Windows.Forms.RadioButton radioConf;
        private System.Windows.Forms.RadioButton radioAtelier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}