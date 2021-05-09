using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAlgorithm.Models
{
    public class Pitanja
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Pitanje { get; set; }
        public Odgovori Odgovor { get; set; }
    }
}
