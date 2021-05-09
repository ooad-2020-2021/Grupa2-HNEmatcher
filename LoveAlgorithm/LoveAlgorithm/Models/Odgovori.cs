using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAlgorithm.Models
{
    public enum Odgovori
    {
        [Display(Name = "Da")]
        DA,
        [Display(Name = "Ne")]
        NE
    }
}
