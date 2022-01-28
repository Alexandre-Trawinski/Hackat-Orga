using System;
using System.Collections.Generic;

#nullable disable

namespace hackatOrga.Models
{
    public partial class Participant
    {
        public Participant()
        {
            InscriptionHackathons = new HashSet<InscriptionHackathon>();
        }

        public int IdParticipant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Password { get; set; }
        public string Portfolio { get; set; }

        public virtual ICollection<InscriptionHackathon> InscriptionHackathons { get; set; }
    }
}
