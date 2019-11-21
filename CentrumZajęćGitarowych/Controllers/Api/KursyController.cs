using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using AutoMapper;
using CentrumZajęćGitarowych.Models;
using CentrumZajęćGitarowych.ModelsDto;

namespace CentrumZajęćGitarowych.Controllers.Api
{
    public class KursyController : ApiController
    {
        private ApplicationDbContext _context;

        public KursyController()
        {
            _context = new ApplicationDbContext();
        }


        // GET /api/kursy
        public IEnumerable<KursDto> PobierzKursy()
        {
            return _context.Kursy.ToList().Select(Mapper.Map<Kurs, KursDto>);
        }

        // GET /api/kursy/1
        public IHttpActionResult PobierzKurs(int id)
        {
            var kurs = _context.Kursy.SingleOrDefault(k => k.Id == id);

            if (kurs == null)
                return NotFound();

            return Ok(Mapper.Map<Kurs, KursDto>(kurs));
        }

        // POST /api/kursy
        [HttpPost]
        public IHttpActionResult StwórzKurs(KursDto kursDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var kurs = Mapper.Map<KursDto, Kurs>(kursDto);
            _context.Kursy.Add(kurs);
            _context.SaveChanges();

            kursDto.Id = kurs.Id;

            return Created(new Uri(Request.RequestUri + "/" + kurs.Id), kursDto);
        }
        // PUT /api/kursy/1
        [HttpPut]
        public void UaktualnijKurs(int id, KursDto kursDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var kursWBazieDanych = _context.Kursy.SingleOrDefault(k => k.Id == id);

            if (kursWBazieDanych == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map<KursDto, Kurs>(kursDto, kursWBazieDanych);

            _context.SaveChanges();

        }

        // DELETE /api/kursy/1
        [HttpDelete]
        public void UsuńKurs(int id)
        {
            var kursWBazieDanych = _context.Kursy.SingleOrDefault(k => k.Id == id);

            if (kursWBazieDanych == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Kursy.Remove(kursWBazieDanych);
            _context.SaveChanges();
        }

    }
}
