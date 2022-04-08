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
                typeEvent = "Conférence";
                
            }
            if (radioAtelier.Checked==true) 
            {
                typeEvent = "Atelier";
            }
            var HeureDebut = new TimeSpan(dtpDebut.Value.Hour, dtpFin.Value.Minute,0);
            var HeureFin = new TimeSpan(dtpFin.Value.Hour, dtpFin.Value.Minute,0);
            var duree = HeureFin.Subtract(HeureDebut);
            int nbPlaces = Decimal.ToInt32(nmPlaces.Value);
            string intervenantNom;
            string intervenantEmail;
            if (cbxInter.Checked == true)
            {
                intervenantNom = tbIntervenantNom.Text;
                intervenantEmail = tbIntervenantEmail.Text;
            }
            else
            {
                intervenantEmail = null;
                intervenantNom = cbIntervenant.Text;
            }
            // On converti l'image en byte[] pour être conforme au type de la table 
            string base64img;
            using (System.Drawing.Image image = pbEvent.Image)
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    base64img = Convert.ToBase64String(imageBytes);

                }
            }
            Evenement newEvenement = new Evenement()
            {
                Libelle = tbLibelle.Text,
                Date = dtDate.Value,
                HeureDebut = HeureDebut,
                Duree = duree,
                Salle = tbSalle.Text,
                NbParticipants = nbPlaces,
                Intervenant = intervenantNom,
                EmailIntervenant = intervenantEmail,
                IdHackathon = cbHackathons.SelectedIndex,
                Image = base64img,
                Type = typeEvent
            };
            cnx.Evenements.Add(newEvenement);
            cnx.SaveChanges();
            lbEventSucces.Visible = true;
        }

        private void AjoutEvent_Load(object sender, EventArgs e)
        {
            bdatrawinski1Context cnx = new bdatrawinski1Context();
            var hackathons = cnx.Hackathons.OrderBy(h => h.Theme).ToList();
            hackathons.Insert(0, new Hackathon() { IdHackathon = 0, Theme = " - Choisir un Hackathon - " });
            cbHackathons.DataSource = hackathons;
            cbHackathons.DisplayMember = "theme";
            cbHackathons.ValueMember = "idHackathon";
            cbHackathons.ValueMember = "inscriptionHackathons";

            //var item1 = cnx.Evenements.OrderBy(t => t.Intervenant).Where(t => t.Intervenant != null).ToList();
            //item1.Insert(0, new Evenement() { EmailIntervenant = "", Intervenant = "- Choisir un intervenant -" });
            cbIntervenant.DataSource = cnx.Evenements.OrderBy(t => t.Intervenant).Where(t => t.Intervenant != null).ToList();

            cbIntervenant.DisplayMember = "intervenant";
            cbIntervenant.ValueMember = "emailIntervenant";
            this.tbImgEvent.Click += new System.EventHandler(this.pbEvent_Click);
            this.tbImgEvent.Enter += new System.EventHandler(this.pbEvent_Click);
        }

        private void radioConf_CheckedChanged(object sender, EventArgs e)
        {
            if (radioConf.Checked == true)
            {
                nmPlaces.Enabled = false;
                tbIntervenantNom.Enabled = true;
                tbIntervenantEmail.Enabled = true;
                cbIntervenant.Enabled = true;
                cbxInter.Enabled = true;
            }
        }

        private void radioAtelier_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAtelier.Checked == true)
            {
                tbIntervenantNom.Enabled = false;
                nmPlaces.Enabled = true;
                tbIntervenantEmail.Enabled = false;
                cbIntervenant.Enabled = false;
                cbxInter.Enabled = false;
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
                    pbEvent.SizeMode = PictureBoxSizeMode.StretchImage;
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
