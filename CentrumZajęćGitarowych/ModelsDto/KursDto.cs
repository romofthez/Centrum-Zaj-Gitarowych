using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CentrumZajęćGitarowych.Models;

namespace CentrumZajęćGitarowych.ModelsDto
{
    public class KursDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nazwa { get; set; }
        
        public byte StopieńZaawansowaniaId { get; set; }
    }
}
