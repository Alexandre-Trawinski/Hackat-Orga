using hackatOrga.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hackatOrga
{
    public partial class Ajout : Form
    {
        public Ajout()
        {
            InitializeComponent();
        }

        private void dtpDebut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            var HeureDebut = new TimeSpan(0,dtpHeureDebut.Value.Hour, dtpHeureFin.Value.Minute);
            var HeureFin = new TimeSpan(0, dtpHeureFin.Value.Hour, dtpHeureFin.Value.Minute);
            int nbPlaces = Decimal.ToInt32(nmNbPlaces.Value);
            bdatrawinski1Context cnx = new bdatrawinski1Context();
            Hackathon newHackathon = new Hackathon()
            {
                DateDebut = dtpDebut.Value,
                HeureDebut = HeureDebut,
                DateFin = dtp_Fin.Value,
                HeureFin = HeureFin,
                Lieu = tbxLieu.Text,
                Rue = tbxRue.Text,
                Ville = tbxVille.Text,
                CodePostal = tbxCodePostal.Text,
                Theme = tbxTheme.Text,
                DateLimite = dtpLimite.Value,
                NbPlaces = nbPlaces,
                Image = tbxImage.Text
            };
            cnx.Hackathons.Add(newHackathon);
            cnx.SaveChanges();
            
            
        }
    }
}
