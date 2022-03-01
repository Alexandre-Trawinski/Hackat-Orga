
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
            this.SuspendLayout();
            // 
            // btn_AjoutEvenement
            // 
            this.btn_AjoutEvenement.Location = new System.Drawing.Point(522, 203);
            this.btn_AjoutEvenement.Name = "btn_AjoutEvenement";
            this.btn_AjoutEvenement.Size = new System.Drawing.Size(143, 97);
            this.btn_AjoutEvenement.TabIndex = 0;
            this.btn_AjoutEvenement.Text = "Ajouter une événement";
            this.btn_AjoutEvenement.UseVisualStyleBackColor = true;
            this.btn_AjoutEvenement.Click += new System.EventHandler(this.btn_AjoutEvenement_Click);
            // 
            // btn_AjoutHackathon
            // 
            this.btn_AjoutHackathon.Location = new System.Drawing.Point(328, 203);
            this.btn_AjoutHackathon.Name = "btn_AjoutHackathon";
            this.btn_AjoutHackathon.Size = new System.Drawing.Size(143, 97);
            this.btn_AjoutHackathon.TabIndex = 1;
            this.btn_AjoutHackathon.Text = "Ajouter un hackathon";
            this.btn_AjoutHackathon.UseVisualStyleBackColor = true;
            this.btn_AjoutHackathon.Click += new System.EventHandler(this.btn_AjoutHackathon_Click);
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Location = new System.Drawing.Point(139, 203);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(143, 97);
            this.btn_imprimer.TabIndex = 2;
            this.btn_imprimer.Text = "Imprimer";
            this.btn_imprimer.UseVisualStyleBackColor = true;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // cbx_hackathons
            // 
            this.cbx_hackathons.FormattingEnabled = true;
            this.cbx_hackathons.Location = new System.Drawing.Point(139, 43);
            this.cbx_hackathons.Name = "cbx_hackathons";
            this.cbx_hackathons.Size = new System.Drawing.Size(526, 23);
            this.cbx_hackathons.TabIndex = 4;
            this.cbx_hackathons.SelectedIndexChanged += new System.EventHandler(this.cbx_hackathons_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbx_hackathons);
            this.Controls.Add(this.btn_imprimer);
            this.Controls.Add(this.btn_AjoutHackathon);
            this.Controls.Add(this.btn_AjoutEvenement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AjoutEvenement;
        private System.Windows.Forms.Button btn_AjoutHackathon;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.ComboBox cbx_hackathons;
    }
}

