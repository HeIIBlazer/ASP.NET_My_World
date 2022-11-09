using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyWorld.Models;

namespace MyWorld.Controllers
{
    public class CountryCityController : Controller
    {
        private MyWorldContext db = new MyWorldContext();

        // GET: CountryCity
        public ActionResult Index()
        {
            return View(db.Countries.ToList());
        }

        // GET: CountryCity/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Country country = db.Countries.Find(id);
            country = db.Countries.Include(t => t.Cities).FirstOrDefault(t => t.Id == id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        [ChildActionOnly]

        public ActionResult CitiesInCountry(int id)
        {
            var countryCities = db.Cities.Where(p => p.CountryId == id);
            return PartialView(countryCities);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
