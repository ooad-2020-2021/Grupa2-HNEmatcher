using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAlgorithm.Models
{
    public enum PolKorisnika
    {
        [Display(Name = "Musko")]
        MUSKO,
        [Display(Name = "Zensko")]
        ZENSKO
    }
}
