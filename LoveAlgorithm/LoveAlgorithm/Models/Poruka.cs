using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAlgorithm.Models
{
    public class Poruka
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public RegistrovaniKorisnik Primalac { get; set; }
        public RegistrovaniKorisnik Posiljalac { get; set; }
        public string PorukaTxt { get; set; }
    }
}
