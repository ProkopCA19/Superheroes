using Superheroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheroes.Controllers
{
    public class SuperheroController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Superhero
        public ActionResult Index()
        {
            var superHeroList = db.Superhero.ToList();
            return View(superHeroList);
        }

        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.Superhero, "ID", "Name", "AlterEgo", "PrimarySuperHeroAbility", "SecondarySuperheroAbility", "Catchphrase");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID, Name, AlterEgo, PrimarySuperheroAbility, SecondarySuperheroAbility, Catchphrase")] Superhero superhero)
        {
            if (ModelState.IsValid)
            {
                db.Superhero.Add(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.Superhero, "ID", "Name", "AlterEgo", "PrimarySuperheroAbility", "SecondarySuperheroAblility", "Catchphrase");
            return View(superhero);
        }

        public ActionResult Delete()
        {

        }

        public ActionResult Edit()
        {

        }


        



    }
}