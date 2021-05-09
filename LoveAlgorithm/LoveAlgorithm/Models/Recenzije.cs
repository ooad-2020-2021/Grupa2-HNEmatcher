using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAlgorithm.Models
{
    public class Recenzije
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Komentar { get; set; }
        public double Ocjena { get; set; }
        public RegistrovaniKorisnik Korisnik1 { get; set; }
    }
}
