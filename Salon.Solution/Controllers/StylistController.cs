using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Salon.Controllers
{
    public class StylistsController : Controller
    {
        private readonly SalonContext _db;

        public StylistsController(SalonContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Stylist> model = _db.Stylists.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

           [HttpPost]
        public ActionResult Create(Stylist stylist)
        {
            _db.Stylists.Add(stylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            thisStylist.Clients = _db.Clients.Where(client => client.StylistId == id).ToList();
            return View(thisStylist);
        }

        public ActionResult Edit(int id)
        {
            var thisStylist = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == id);
            ViewBag.StylistId = new SelectList(_db.Clients, "ClientId", "Name");
            return View(thisStylist);
        }

        [HttpPost]
        public ActionResult Edit(Stylist stylist)
        {
            _db.Entry(stylist).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}