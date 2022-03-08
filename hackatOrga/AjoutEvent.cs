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
using MySql.Data.MySqlClient;
using System.IO;

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
            FileStream fs;
            BinaryReader br;
            string FileName = tbImgEvent.Text;
            byte[] ImageData;
            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
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
            var HeureDebut = new TimeSpan(dtpDebut.Value.Hour, dtpFin.Value.Minute,0);
            var HeureFin = new TimeSpan(dtpFin.Value.Hour, dtpFin.Value.Minute,0);
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
                Image = ImageData,
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
            this.tbImgEvent.Click += new System.EventHandler(this.pbEvent_Click);
            this.tbImgEvent.Enter += new System.EventHandler(this.pbEvent_Click);
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

        private void pbEvent_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    tbImgEvent.Text = openFileDialog1.FileName;
                    pbEvent.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
