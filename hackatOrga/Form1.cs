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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {
            bdatrawinski1Context cnx = new bdatrawinski1Context();

            if (cbx_hackathons.SelectedIndex != 0)
            {
                //On récupère le hackathon choisi dans la liste
                Hackathon unHackathon = (Hackathon)cbx_hackathons.SelectedItem;
                int idHackathon = unHackathon.IdHackathon;
            }

            //iTextSharp.LGPLv2.Core
            //Création d'un document
             Document unDocument = new Document();
             FileStream doc = new FileStream("C:\\Users\\tfavreau\\Documents\\listeParticipants.pdf", FileMode.Create);
             PdfWriter.GetInstance(unDocument, doc);
             unDocument.Open();

             //Paragraphe centré avec une police de 14 et du gras
             iTextSharp.text.Font myFont = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD);
             Paragraph titre = new Paragraph("Liste des participants", myFont);
             titre.Alignment = Element.ALIGN_CENTER;
             titre.SpacingAfter = 12;
             unDocument.Add(titre);

             //Création d'un tableau
             PdfPTable tableau = new PdfPTable(9);

            List<int> lesInscriptions = new List<int>();
            //on cherche si ce participant est inscrit au hackathon
            foreach (InscriptionHackathon i in cnx.InscriptionHackathons.ToList())
            {
                if (cbx_hackathons.SelectedIndex == i.IdHackathon)
                {
                    lesInscriptions.Add(i.IdParticipant);
                }
            }

            foreach (Participant c in cnx.Participants.ToList())
            {
                foreach (int p in lesInscriptions)
                {
                    if (p == c.IdParticipant)
                    {
                        tableau.AddCell(c.Nom);
                        tableau.AddCell(c.Prenom);
                        tableau.AddCell(c.DateNaissance.ToString("dd/MM/yyyy"));
                        tableau.AddCell(c.Rue);
                        tableau.AddCell(c.Ville);
                        tableau.AddCell(c.CodePostal);
                        tableau.AddCell(c.Mail);
                        tableau.AddCell(c.Tel);
                        tableau.AddCell(c.Portfolio);
                    }
                }
            }

            unDocument.Add(tableau);


            //Enregistrement du fichier
            unDocument.Close();
            System.Diagnostics.Process.Start("C:\\Users\\tfavreau\\Documents\\listeParticipants.pdf");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bdatrawinski1Context cnx = new bdatrawinski1Context();

            cbx_hackathons.DataSource = cnx.Hackathons.OrderBy(cli => cli.Theme).ToList();
            cbx_hackathons.DisplayMember = "theme";
            cbx_hackathons.ValueMember = "idHackathon";
            cbx_hackathons.ValueMember = "inscriptionHackathons";
        }

        private void lbx_hackathons_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbx_hackathons_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_AjoutHackathon_Click(object sender, EventArgs e)
        {
            Ajout ajoutHackathon = new Ajout();
            ajoutHackathon.ShowDialog();
        }

        private void btn_AjoutEvenement_Click(object sender, EventArgs e)
        {
            AjoutEvent ajoutEvent = new AjoutEvent();
            ajoutEvent.ShowDialog();
        }
    }
}
