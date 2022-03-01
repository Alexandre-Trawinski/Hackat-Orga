using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hackatOrga.Models;

namespace hackatOrga
{
    public partial class AjoutEvent : Form
    {
        public AjoutEvent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbHackathon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bdatrawinski1Context cnx = new bdatrawinski1Context();
            if (cbHackathons.SelectedIndex != 0)
            {
                //On récupère l'id du hackathon choisi dans la liste
                Hackathon unHackathon = (Hackathon)cbHackathons.SelectedItem;
                int idHackathon = unHackathon.IdHackathon;
            }
            string typeEvent="";
            if (radioConf.Checked==true) 
            {
                
            }
            if (radioAtelier.Checked==true) 
            { 
                
            }
            var HeureDebut = new TimeSpan(0, dtpDebut.Value.Hour, dtpFin.Value.Minute);
            var HeureFin = new TimeSpan(0, dtpFin.Value.Hour, dtpFin.Value.Minute);
            var duree = HeureFin.Subtract(HeureDebut);
            int nbPlaces = Decimal.ToInt32(nmPlaces.Value);
            Evenement newEvenement = new Evenement()
            {
                Libelle = tbLibelle.Text,
                Date = dtDate.Value,
                HeureDebut = HeureDebut,
                Duree = duree,
                Salle = tbSalle.Text,
                NbParticipants = nbPlaces,
                Intervenant = tbIntervenant.Text,
                IdHackathon = cbHackathons.SelectedIndex,
                Image = tbImg.Text,
                Type = typeEvent
            };
            cnx.Evenements.Add(newEvenement);
            cnx.SaveChanges();
        }

        private void AjoutEvent_Load(object sender, EventArgs e)
        {
            bdatrawinski1Context cnx = new bdatrawinski1Context();

            cbHackathons.DataSource = cnx.Hackathons.OrderBy(cli => cli.Theme).ToList();
            cbHackathons.DisplayMember = "theme";
            cbHackathons.ValueMember = "idHackathon";
            cbHackathons.ValueMember = "inscriptionHackathons";
        }

        private void radioConf_CheckedChanged(object sender, EventArgs e)
        {
            if (radioConf.Checked == true)
            {
                string typeEvent = "Conférence";
                nmPlaces.Enabled = false;
                tbIntervenant.Enabled = true;
            }
        }

        private void radioAtelier_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAtelier.Checked == true)
            {
                string typeEvent = "Atelier";
                tbIntervenant.Enabled = false;
                nmPlaces.Enabled = true;
            }
        }
    }
}
