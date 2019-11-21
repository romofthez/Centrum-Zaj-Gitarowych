using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CentrumZajęćGitarowych.Models;
using System.Data.Entity;
using System.Web.Configuration;
using CentrumZajęćGitarowych.ViewModels;

namespace CentrumZajęćGitarowych.Controllers
{
    public class KursyController : Controller
    {
        private ApplicationDbContext _context;

        public KursyController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize(Roles = "Nauczyciel")]
        public ActionResult Nowy()
        {
            
            var stopnieZaawansowania = _context.StopnieZaawansowania.ToList();
            var modelWidoku = new NowyKursViewModel
            {
                Kurs = new Kurs(),
                StopnieZaawansowania = stopnieZaawansowania
            };


            return View(modelWidoku);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Nauczyciel")]
        public ActionResult Stwórz(Kurs kurs)
        {
            if (!ModelState.IsValid)
            {
                var modelWidoku = new NowyKursViewModel
                {
                    Kurs = kurs,
                    StopnieZaawansowania = _context.StopnieZaawansowania.ToList()
                };

                return View("Nowy", modelWidoku);
            }

            if (kurs.Id == 0)
                _context.Kursy.Add(kurs);
            else
            {
                var kursWBazieDanych = _context.Kursy.Single(k => k.Id == kurs.Id);
                kursWBazieDanych.Nazwa = kurs.Nazwa;
                kursWBazieDanych.StopieńZaawansowaniaId = kurs.StopieńZaawansowaniaId;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Kursy");
        }

        [Authorize(Roles = "Nauczyciel")]
        public ActionResult Edytuj(int id)
        {
            var kurs = _context.Kursy.SingleOrDefault(k => k.Id == id);

            if (kurs == null)
                return HttpNotFound();

            var modelWidoku = new NowyKursViewModel
            {
                Kurs = kurs,
                StopnieZaawansowania = _context.StopnieZaawansowania.ToList()
            };

            return View("Nowy", modelWidoku);
        }


        public ActionResult Index()
        {
            var kursy = _context.Kursy.Include(k => k.StopieńZaawansowania).ToList();

            if (User.IsInRole("Nauczyciel"))
                return View("Index", kursy);
            else
                return View("DoOdczytuIndex", kursy);
        }

        public ActionResult Szczegóły(int id)
        {
            var kurs = _context.Kursy.SingleOrDefault(k => k.Id == id);

            if (kurs == null)
                return HttpNotFound();

            return View(kurs);
        }




        // GET: Kursy/Losowy
        public ActionResult Losowy()
        {
            var kurs = new Kurs() {Nazwa = "Zajęcia z gitary akustycznej"};
            return View(kurs);
        }
    }
}