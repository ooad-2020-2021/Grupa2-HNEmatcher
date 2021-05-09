using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAlgorithm.Models
{
    public class Chat
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public RegistrovaniKorisnik Korisnik1 { get; set; }
        public RegistrovaniKorisnik Korisnik2 { get; set; }
        [NotMapped]
        public List<Poruka> Poruke { get; set; }
        public bool PotvrdaAdministratora { get; set; }
    }
}
