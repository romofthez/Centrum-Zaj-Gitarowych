using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CentrumZajęćGitarowych.Models
{
    public class Kurs
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Nazwa { get; set; }
        public StopieńZaawansowania StopieńZaawansowania { get; set; }

        [Display(Name = "Stopień Zaawansowania")]
        public byte StopieńZaawansowaniaId { get; set; }
    }
}
