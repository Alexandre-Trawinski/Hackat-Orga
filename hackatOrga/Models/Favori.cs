using System;
using System.Collections.Generic;

#nullable disable

namespace hackatOrga.Models
{
    public partial class Favori
    {
        public int IdFavoris { get; set; }
        public int IdHackathon { get; set; }
        public int IdParticipant { get; set; }

        public virtual Hackathon IdHackathonNavigation { get; set; }
        public virtual Participant IdParticipantNavigation { get; set; }
    }
}
