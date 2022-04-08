
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajout));
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
            this.dtpLimite = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.gbxAdresse = new System.Windows.Forms.GroupBox();
            this.tbxCodePostal = new System.Windows.Forms.TextBox();
            this.tbxVille = new System.Windows.Forms.TextBox();
            this.tbxRue = new System.Windows.Forms.TextBox();
            this.tbxLieu = new System.Windows.Forms.TextBox();
            this.tbxTheme = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.nmNbPlaces = new System.Windows.Forms.NumericUpDown();
            this.pbHackathon = new System.Windows.Forms.PictureBox();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.lbSucces = new System.Windows.Forms.Label();
            this.dtpHeureDebut = new System.Windows.Forms.DateTimePicker();
            this.gbxHoraires.SuspendLayout();
            this.gbxAdresse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNbPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHackathon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateDebut
            // 
            resources.ApplyResources(this.lblDateDebut, "lblDateDebut");
            this.lblDateDebut.Name = "lblDateDebut";
            // 
            // lblHeureDebut
            // 
            resources.ApplyResources(this.lblHeureDebut, "lblHeureDebut");
            this.lblHeureDebut.Name = "lblHeureDebut";
            // 
            // lblDateFin
            // 
            resources.ApplyResources(this.lblDateFin, "lblDateFin");
            this.lblDateFin.Name = "lblDateFin";
            // 
            // lblHeureFin
            // 
            resources.ApplyResources(this.lblHeureFin, "lblHeureFin");
            this.lblHeureFin.Name = "lblHeureFin";
            // 
            // lblLieu
            // 
            resources.ApplyResources(this.lblLieu, "lblLieu");
            this.lblLieu.Name = "lblLieu";
            // 
            // lblRue
            // 
            resources.ApplyResources(this.lblRue, "lblRue");
            this.lblRue.Name = "lblRue";
            // 
            // lblVille
            // 
            resources.ApplyResources(this.lblVille, "lblVille");
            this.lblVille.Name = "lblVille";
            // 
            // lblCodePostal
            // 
            resources.ApplyResources(this.lblCodePostal, "lblCodePostal");
            this.lblCodePostal.Name = "lblCodePostal";
            // 
            // lblTheme
            // 
            resources.ApplyResources(this.lblTheme, "lblTheme");
            this.lblTheme.Name = "lblTheme";
            // 
            // lbldateLimite
            // 
            resources.ApplyResources(this.lbldateLimite, "lbldateLimite");
            this.lbldateLimite.Name = "lbldateLimite";
            // 
            // lblNbrePlaces
            // 
            resources.ApplyResources(this.lblNbrePlaces, "lblNbrePlaces");
            this.lblNbrePlaces.Name = "lblNbrePlaces";
            // 
            // lblImage
            // 
            resources.ApplyResources(this.lblImage, "lblImage");
            this.lblImage.Name = "lblImage";
            this.lblImage.Click += new System.EventHandler(this.lblImage_Click);
            // 
            // gbxHoraires
            // 
            this.gbxHoraires.Controls.Add(this.dtpHeureDebut);
            this.gbxHoraires.Controls.Add(this.dtpHeureFin);
            this.gbxHoraires.Controls.Add(this.dtpLimite);
            this.gbxHoraires.Controls.Add(this.dtp_Fin);
            this.gbxHoraires.Controls.Add(this.dtpDebut);
            this.gbxHoraires.Controls.Add(this.lblDateDebut);
            this.gbxHoraires.Controls.Add(this.lblHeureDebut);
            this.gbxHoraires.Controls.Add(this.lblDateFin);
            this.gbxHoraires.Controls.Add(this.lblHeureFin);
            this.gbxHoraires.Controls.Add(this.lbldateLimite);
            resources.ApplyResources(this.gbxHoraires, "gbxHoraires");
            this.gbxHoraires.Name = "gbxHoraires";
            this.gbxHoraires.TabStop = false;
            // 
            // dtpHeureFin
            // 
            this.dtpHeureFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dtpHeureFin, "dtpHeureFin");
            this.dtpHeureFin.Name = "dtpHeureFin";
            // 
            // dtpLimite
            // 
            this.dtpLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpLimite, "dtpLimite");
            this.dtpLimite.Name = "dtpLimite";
            // 
            // dtp_Fin
            // 
            this.dtp_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtp_Fin, "dtp_Fin");
            this.dtp_Fin.Name = "dtp_Fin";
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpDebut, "dtpDebut");
            this.dtpDebut.Name = "dtpDebut";
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
            resources.ApplyResources(this.gbxAdresse, "gbxAdresse");
            this.gbxAdresse.Name = "gbxAdresse";
            this.gbxAdresse.TabStop = false;
            // 
            // tbxCodePostal
            // 
            resources.ApplyResources(this.tbxCodePostal, "tbxCodePostal");
            this.tbxCodePostal.Name = "tbxCodePostal";
            // 
            // tbxVille
            // 
            resources.ApplyResources(this.tbxVille, "tbxVille");
            this.tbxVille.Name = "tbxVille";
            // 
            // tbxRue
            // 
            resources.ApplyResources(this.tbxRue, "tbxRue");
            this.tbxRue.Name = "tbxRue";
            // 
            // tbxLieu
            // 
            resources.ApplyResources(this.tbxLieu, "tbxLieu");
            this.tbxLieu.Name = "tbxLieu";
            // 
            // tbxTheme
            // 
            resources.ApplyResources(this.tbxTheme, "tbxTheme");
            this.tbxTheme.Name = "tbxTheme";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.LightGreen;
            resources.ApplyResources(this.btnEnregistrer, "btnEnregistrer");
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // nmNbPlaces
            // 
            resources.ApplyResources(this.nmNbPlaces, "nmNbPlaces");
            this.nmNbPlaces.Name = "nmNbPlaces";
            // 
            // pbHackathon
            // 
            this.pbHackathon.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.pbHackathon, "pbHackathon");
            this.pbHackathon.Name = "pbHackathon";
            this.pbHackathon.TabStop = false;
            this.pbHackathon.Click += new System.EventHandler(this.pbHackathon_Click);
            // 
            // txtImg
            // 
            resources.ApplyResources(this.txtImg, "txtImg");
            this.txtImg.Name = "txtImg";
            // 
            // lbSucces
            // 
            resources.ApplyResources(this.lbSucces, "lbSucces");
            this.lbSucces.ForeColor = System.Drawing.Color.Green;
            this.lbSucces.Name = "lbSucces";
            // 
            // dtpHeureDebut
            // 
            this.dtpHeureDebut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dtpHeureDebut, "dtpHeureDebut");
            this.dtpHeureDebut.Name = "dtpHeureDebut";
            // 
            // Ajout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSucces);
            this.Controls.Add(this.txtImg);
            this.Controls.Add(this.pbHackathon);
            this.Controls.Add(this.nmNbPlaces);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.tbxTheme);
            this.Controls.Add(this.gbxAdresse);
            this.Controls.Add(this.gbxHoraires);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblNbrePlaces);
            this.Controls.Add(this.lblTheme);
            this.DoubleBuffered = true;
            this.Name = "Ajout";
            this.Load += new System.EventHandler(this.Ajout_Load);
            this.gbxHoraires.ResumeLayout(false);
            this.gbxHoraires.PerformLayout();
            this.gbxAdresse.ResumeLayout(false);
            this.gbxAdresse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNbPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHackathon)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpHeureFin;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.NumericUpDown nmNbPlaces;
        private System.Windows.Forms.PictureBox pbHackathon;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.Label lbSucces;
        private System.Windows.Forms.DateTimePicker dtpHeureDebut;
    }
}