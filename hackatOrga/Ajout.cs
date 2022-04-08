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
using MySql.Data.MySqlClient;

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
            FileStream fs;
            BinaryReader br;
            string FileName = txtImg.Text;
            byte[] ImageData;
            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            var HeureDebut = new TimeSpan(0,dtpHeureDebut.Value.Hour, dtpHeureFin.Value.Minute);
            var HeureFin = new TimeSpan(0, dtpHeureFin.Value.Hour, dtpHeureFin.Value.Minute);
            int nbPlaces = Decimal.ToInt32(nmNbPlaces.Value);

            
            string base64Img;
            using (System.Drawing.Image image = pbHackathon.Image)
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    base64Img = Convert.ToBase64String(imageBytes);
                    
                }
            }

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
                Image = base64Img
            };
            cnx.Hackathons.Add(newHackathon);
            cnx.SaveChanges();
            lbSucces.Visible = true;
            
            
        }

        private void pbHackathon_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif;*.gif";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pbHackathon.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtImg.Text = openFileDialog1.FileName;
                    pbHackathon.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Ajout_Load(object sender, EventArgs e)
        {
            this.txtImg.Click += new System.EventHandler(this.pbHackathon_Click);
            this.txtImg.Enter += new System.EventHandler(this.pbHackathon_Click);
        }
    }
}
