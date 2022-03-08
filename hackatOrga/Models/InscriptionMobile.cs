using System;
using System.Collections.Generic;

#nullable disable

namespace hackatOrga.Models
{
    public partial class InscriptionMobile
    {
        public int Id { get; set; }
        public int IdEvenement { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
    }
}
