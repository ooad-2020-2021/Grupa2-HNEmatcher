using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAlgorithm.Models
{
    public class RegistrovaniKorisnik : Profil
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"/(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}",
            ErrorMessage = "Lozinka mora da sadrži bar jedno malo slovo, jedno veliko slovo i jedan broj i mora biti duža od 8 karaktera!")]
        public string Lozinka{ get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Grad { get; set; }
        public string Drzava { get; set; }
        [Required]
        public DateTime DatumRodjenja { get; set; }
        public string Opis { get; set; }
        public string KorisnickiPodaci { get; set; }
        [NotMapped]
        public List<RegistrovaniKorisnik> ListaMatcheva { get; set; }
        [NotMapped]
        public List<Pitanja> Obrazac { get; set; }
        [NotMapped]
        public List<String> Zahtjev { get; set; }
        [Required]
        public PolKorisnika Pol { get; set; }
    }
}
