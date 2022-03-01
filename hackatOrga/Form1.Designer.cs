
namespace hackatOrga
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AjoutEvenement = new System.Windows.Forms.Button();
            this.btn_AjoutHackathon = new System.Windows.Forms.Button();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.cbx_hackathons = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AjoutEvenement
            // 
            this.btn_AjoutEvenement.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_AjoutEvenement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AjoutEvenement.Location = new System.Drawing.Point(522, 203);
            this.btn_AjoutEvenement.Name = "btn_AjoutEvenement";
            this.btn_AjoutEvenement.Size = new System.Drawing.Size(143, 97);
            this.btn_AjoutEvenement.TabIndex = 0;
            this.btn_AjoutEvenement.Text = "Ajouter un événement";
            this.btn_AjoutEvenement.UseVisualStyleBackColor = false;
            this.btn_AjoutEvenement.Click += new System.EventHandler(this.btn_AjoutEvenement_Click);
            // 
            // btn_AjoutHackathon
            // 
            this.btn_AjoutHackathon.BackColor = System.Drawing.Color.LightGreen;
            this.btn_AjoutHackathon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AjoutHackathon.Location = new System.Drawing.Point(328, 203);
            this.btn_AjoutHackathon.Name = "btn_AjoutHackathon";
            this.btn_AjoutHackathon.Size = new System.Drawing.Size(143, 97);
            this.btn_AjoutHackathon.TabIndex = 1;
            this.btn_AjoutHackathon.Text = "Ajouter un hackathon";
            this.btn_AjoutHackathon.UseVisualStyleBackColor = false;
            this.btn_AjoutHackathon.Click += new System.EventHandler(this.btn_AjoutHackathon_Click);
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_imprimer.Location = new System.Drawing.Point(139, 203);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(143, 97);
            this.btn_imprimer.TabIndex = 2;
            this.btn_imprimer.Text = "Imprimer la liste des participants pour le hackathon";
            this.btn_imprimer.UseVisualStyleBackColor = false;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // cbx_hackathons
            // 
            this.cbx_hackathons.FormattingEnabled = true;
            this.cbx_hackathons.Location = new System.Drawing.Point(139, 165);
            this.cbx_hackathons.Name = "cbx_hackathons";
            this.cbx_hackathons.Size = new System.Drawing.Size(143, 23);
            this.cbx_hackathons.TabIndex = 4;
            this.cbx_hackathons.Text = "Choisir un hackathon";
            this.cbx_hackathons.SelectedIndexChanged += new System.EventHandler(this.cbx_hackathons_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenue sur Hackat\'Orga";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_hackathons);
            this.Controls.Add(this.btn_imprimer);
            this.Controls.Add(this.btn_AjoutHackathon);
            this.Controls.Add(this.btn_AjoutEvenement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AjoutEvenement;
        private System.Windows.Forms.Button btn_AjoutHackathon;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.ComboBox cbx_hackathons;
        private System.Windows.Forms.Label label1;
    }
}

