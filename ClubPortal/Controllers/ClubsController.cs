using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClubPortal.Models;
using ClubPortal.DAL;

namespace ClubPortal.Controllers
{
    public class ClubsController : Controller
    {
        private ClubContext db = new ClubContext();

        // GET: Clubs
        public ActionResult Index()
        {
            var clubs = db.Clubs.ToList();
            return View(clubs);
        }

        public ActionResult Details(int? id)
        {
            Club club = db.Clubs.Find(id);

            if (club == null)
            {
                return HttpNotFound();
            }

            return View(club);
        }

        [HttpPost]
        public ActionResult Details(Club club)
        {
            var existingClub = db.Clubs.Where(c => c.ID == club.ID).FirstOrDefault();

            existingClub.Name = club.Name;
            existingClub.Eliminated = club.Eliminated;
            existingClub.Country = club.Country;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
