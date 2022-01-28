using System;
using System.Collections.Generic;

#nullable disable

namespace hackatOrga.Models
{
    public partial class Evenement
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan HeureDebut { get; set; }
        public TimeSpan Duree { get; set; }
        public string Salle { get; set; }
        public int? NbParticipants { get; set; }
        public string Intervenant { get; set; }
        public int IdHackathon { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }

        public virtual Hackathon IdHackathonNavigation { get; set; }
    }
}
