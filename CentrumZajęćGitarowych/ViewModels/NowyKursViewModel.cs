using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CentrumZajęćGitarowych.Models;

namespace CentrumZajęćGitarowych.ViewModels
{
    public class NowyKursViewModel
    {
        public IEnumerable<StopieńZaawansowania> StopnieZaawansowania { get; set; }

        public Kurs Kurs { get; set; }

        public string Tytuł
        {
            get
            {
                if (Kurs != null && Kurs.Id != 0)
                    return "Edytuj Kurs";

                return "Nowy Kurs";
            }
        }
    }
}