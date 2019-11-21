using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CentrumZajęćGitarowych.Models;
using CentrumZajęćGitarowych.ModelsDto;

namespace CentrumZajęćGitarowych.App_Start
{
    public class ProfilMapowania : Profile
    {
        public ProfilMapowania()
        {
            Mapper.CreateMap<Kurs, KursDto>();
            Mapper.CreateMap<KursDto, Kurs>();
        }
    }
}
