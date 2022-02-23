﻿
using System;

namespace hackatOrga
{
    partial class Ajout
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
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblHeureDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblHeureFin = new System.Windows.Forms.Label();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lbldateLimite = new System.Windows.Forms.Label();
            this.lblNbrePlaces = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.gbxHoraires = new System.Windows.Forms.GroupBox();
            this.dtpHeureFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHeureDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpLimite = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.gbxAdresse = new System.Windows.Forms.GroupBox();
            this.tbxCodePostal = new System.Windows.Forms.TextBox();
            this.tbxVille = new System.Windows.Forms.TextBox();
            this.tbxRue = new System.Windows.Forms.TextBox();
            this.tbxLieu = new System.Windows.Forms.TextBox();
            this.tbxTheme = new System.Windows.Forms.TextBox();
            this.tbxImage = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.nmNbPlaces = new System.Windows.Forms.NumericUpDown();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblEchec = new System.Windows.Forms.Label();
            this.gbxHoraires.SuspendLayout();
            this.gbxAdresse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNbPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(8, 29);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(87, 15);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "Date de début :";
            // 
            // lblHeureDebut
            // 
            this.lblHeureDebut.AutoSize = true;
            this.lblHeureDebut.Location = new System.Drawing.Point(8, 124);
            this.lblHeureDebut.Name = "lblHeureDebut";
            this.lblHeureDebut.Size = new System.Drawing.Size(95, 15);
            this.lblHeureDebut.TabIndex = 1;
            this.lblHeureDebut.Text = "Heure de début :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(8, 76);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(70, 15);
            this.lblDateFin.TabIndex = 2;
            this.lblDateFin.Text = "Date de fin :";
            // 
            // lblHeureFin
            // 
            this.lblHeureFin.AutoSize = true;
            this.lblHeureFin.Location = new System.Drawing.Point(8, 173);
            this.lblHeureFin.Name = "lblHeureFin";
            this.lblHeureFin.Size = new System.Drawing.Size(78, 15);
            this.lblHeureFin.TabIndex = 3;
            this.lblHeureFin.Text = "Heure de fin :";
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Location = new System.Drawing.Point(10, 45);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(35, 15);
            this.lblLieu.TabIndex = 4;
            this.lblLieu.Text = "Lieu :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(10, 87);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(33, 15);
            this.lblRue.TabIndex = 5;
            this.lblRue.Text = "Rue :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(10, 137);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(35, 15);
            this.lblVille.TabIndex = 6;
            this.lblVille.Text = "Ville :";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(10, 185);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(76, 15);
            this.lblCodePostal.TabIndex = 7;
            this.lblCodePostal.Text = "Code postal :";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(491, 43);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(49, 15);
            this.lblTheme.TabIndex = 8;
            this.lblTheme.Text = "Thème :";
            // 
            // lbldateLimite
            // 
            this.lbldateLimite.AutoSize = true;
            this.lbldateLimite.Location = new System.Drawing.Point(8, 219);
            this.lbldateLimite.Name = "lbldateLimite";
            this.lbldateLimite.Size = new System.Drawing.Size(139, 15);
            this.lbldateLimite.TabIndex = 9;
            this.lbldateLimite.Text = "Date limite d\'inscription :";
            // 
            // lblNbrePlaces
            // 
            this.lblNbrePlaces.AutoSize = true;
            this.lblNbrePlaces.Location = new System.Drawing.Point(491, 88);
            this.lblNbrePlaces.Name = "lblNbrePlaces";
            this.lblNbrePlaces.Size = new System.Drawing.Size(109, 15);
            this.lblNbrePlaces.TabIndex = 10;
            this.lblNbrePlaces.Text = "Nombre de places :";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(494, 136);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(78, 15);
            this.lblImage.TabIndex = 11;
            this.lblImage.Text = "Image (URL) :";
            this.lblImage.Click += new System.EventHandler(this.lblImage_Click);
            // 
            // gbxHoraires
            // 
            this.gbxHoraires.Controls.Add(this.dtpHeureFin);
            this.gbxHoraires.Controls.Add(this.dtpHeureDebut);
            this.gbxHoraires.Controls.Add(this.dtpLimite);
            this.gbxHoraires.Controls.Add(this.dtp_Fin);
            this.gbxHoraires.Controls.Add(this.dtpDebut);
            this.gbxHoraires.Controls.Add(this.lblDateDebut);
            this.gbxHoraires.Controls.Add(this.lblHeureDebut);
            this.gbxHoraires.Controls.Add(this.lblDateFin);
            this.gbxHoraires.Controls.Add(this.lblHeureFin);
            this.gbxHoraires.Controls.Add(this.lbldateLimite);
            this.gbxHoraires.Location = new System.Drawing.Point(12, 12);
            this.gbxHoraires.Name = "gbxHoraires";
            this.gbxHoraires.Size = new System.Drawing.Size(414, 251);
            this.gbxHoraires.TabIndex = 12;
            this.gbxHoraires.TabStop = false;
            this.gbxHoraires.Text = "Horaires";
            // 
            // dtpHeureFin
            // 
            this.dtpHeureFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeureFin.Location = new System.Drawing.Point(162, 165);
            this.dtpHeureFin.Name = "dtpHeureFin";
            this.dtpHeureFin.Size = new System.Drawing.Size(200, 23);
            this.dtpHeureFin.TabIndex = 14;
            // 
            // dtpHeureDebut
            // 
            this.dtpHeureDebut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeureDebut.Location = new System.Drawing.Point(162, 118);
            this.dtpHeureDebut.Name = "dtpHeureDebut";
            this.dtpHeureDebut.Size = new System.Drawing.Size(200, 23);
            this.dtpHeureDebut.TabIndex = 13;
            this.dtpHeureDebut.Value = new System.DateTime(2022, 2, 22, 13, 14, 0, 0);
            this.dtpHeureDebut.ValueChanged += new System.EventHandler(this.dtpHeureDebut_ValueChanged);
            // 
            // dtpLimite
            // 
            this.dtpLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLimite.Location = new System.Drawing.Point(162, 213);
            this.dtpLimite.Name = "dtpLimite";
            this.dtpLimite.Size = new System.Drawing.Size(200, 23);
            this.dtpLimite.TabIndex = 12;
            // 
            // dtp_Fin
            // 
            this.dtp_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fin.Location = new System.Drawing.Point(162, 70);
            this.dtp_Fin.Name = "dtp_Fin";
            this.dtp_Fin.Size = new System.Drawing.Size(200, 23);
            this.dtp_Fin.TabIndex = 11;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(162, 23);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 23);
            this.dtpDebut.TabIndex = 10;
            this.dtpDebut.ValueChanged += new System.EventHandler(this.dtpDebut_ValueChanged);
            // 
            // gbxAdresse
            // 
            this.gbxAdresse.Controls.Add(this.tbxCodePostal);
            this.gbxAdresse.Controls.Add(this.tbxVille);
            this.gbxAdresse.Controls.Add(this.tbxRue);
            this.gbxAdresse.Controls.Add(this.tbxLieu);
            this.gbxAdresse.Controls.Add(this.lblLieu);
            this.gbxAdresse.Controls.Add(this.lblRue);
            this.gbxAdresse.Controls.Add(this.lblVille);
            this.gbxAdresse.Controls.Add(this.lblCodePostal);
            this.gbxAdresse.Location = new System.Drawing.Point(12, 294);
            this.gbxAdresse.Name = "gbxAdresse";
            this.gbxAdresse.Size = new System.Drawing.Size(414, 227);
            this.gbxAdresse.TabIndex = 13;
            this.gbxAdresse.TabStop = false;
            this.gbxAdresse.Text = "Adresse";
            // 
            // tbxCodePostal
            // 
            this.tbxCodePostal.Location = new System.Drawing.Point(105, 182);
            this.tbxCodePostal.Name = "tbxCodePostal";
            this.tbxCodePostal.Size = new System.Drawing.Size(280, 23);
            this.tbxCodePostal.TabIndex = 11;
            // 
            // tbxVille
            // 
            this.tbxVille.Location = new System.Drawing.Point(105, 134);
            this.tbxVille.Name = "tbxVille";
            this.tbxVille.Size = new System.Drawing.Size(280, 23);
            this.tbxVille.TabIndex = 10;
            // 
            // tbxRue
            // 
            this.tbxRue.Location = new System.Drawing.Point(105, 84);
            this.tbxRue.Name = "tbxRue";
            this.tbxRue.Size = new System.Drawing.Size(280, 23);
            this.tbxRue.TabIndex = 9;
            // 
            // tbxLieu
            // 
            this.tbxLieu.Location = new System.Drawing.Point(105, 42);
            this.tbxLieu.Name = "tbxLieu";
            this.tbxLieu.Size = new System.Drawing.Size(280, 23);
            this.tbxLieu.TabIndex = 8;
            // 
            // tbxTheme
            // 
            this.tbxTheme.Location = new System.Drawing.Point(570, 38);
            this.tbxTheme.Name = "tbxTheme";
            this.tbxTheme.Size = new System.Drawing.Size(385, 23);
            this.tbxTheme.TabIndex = 12;
            // 
            // tbxImage
            // 
            this.tbxImage.Location = new System.Drawing.Point(570, 133);
            this.tbxImage.Name = "tbxImage";
            this.tbxImage.Size = new System.Drawing.Size(385, 23);
            this.tbxImage.TabIndex = 15;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(625, 336);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(143, 52);
            this.btnEnregistrer.TabIndex = 16;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // nmNbPlaces
            // 
            this.nmNbPlaces.Location = new System.Drawing.Point(625, 88);
            this.nmNbPlaces.Name = "nmNbPlaces";
            this.nmNbPlaces.Size = new System.Drawing.Size(120, 23);
            this.nmNbPlaces.TabIndex = 18;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSuccess.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblSuccess.Location = new System.Drawing.Point(570, 446);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(246, 25);
            this.lblSuccess.TabIndex = 19;
            this.lblSuccess.Text = "Hackathon crée avec succès";
            // 
            // lblEchec
            // 
            this.lblEchec.AutoSize = true;
            this.lblEchec.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEchec.ForeColor = System.Drawing.Color.Red;
            this.lblEchec.Location = new System.Drawing.Point(532, 476);
            this.lblEchec.Name = "lblEchec";
            this.lblEchec.Size = new System.Drawing.Size(337, 25);
            this.lblEchec.TabIndex = 20;
            this.lblEchec.Text = "Echec lors de la création du hackathon\r\n";
            // 
            // Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 593);
            this.Controls.Add(this.lblEchec);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.nmNbPlaces);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.tbxImage);
            this.Controls.Add(this.tbxTheme);
            this.Controls.Add(this.gbxAdresse);
            this.Controls.Add(this.gbxHoraires);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblNbrePlaces);
            this.Controls.Add(this.lblTheme);
            this.Name = "Ajout";
            this.Text = "Ajout";
            this.gbxHoraires.ResumeLayout(false);
            this.gbxHoraires.PerformLayout();
            this.gbxAdresse.ResumeLayout(false);
            this.gbxAdresse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNbPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dtpHeureDebut_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblImage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblHeureDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblHeureFin;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lbldateLimite;
        private System.Windows.Forms.Label lblNbrePlaces;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.GroupBox gbxHoraires;
        private System.Windows.Forms.DateTimePicker dtpLimite;
        private System.Windows.Forms.DateTimePicker dtp_Fin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.GroupBox gbxAdresse;
        private System.Windows.Forms.TextBox tbxCodePostal;
        private System.Windows.Forms.TextBox tbxVille;
        private System.Windows.Forms.TextBox tbxRue;
        private System.Windows.Forms.TextBox tbxLieu;
        private System.Windows.Forms.TextBox tbxTheme;
        private System.Windows.Forms.TextBox tbxImage;
        private System.Windows.Forms.DateTimePicker dtpHeureFin;
        private System.Windows.Forms.DateTimePicker dtpHeureDebut;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.NumericUpDown nmNbPlaces;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblEchec;
    }
}