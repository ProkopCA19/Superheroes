using Superheroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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




        public ActionResult Delete(int? ID)
        {
            var superhero = db.Superhero.Where(s=>s.ID == ID).FirstOrDefault();
            if (superhero == null)
            {
                
                return View("Not Found");
            } 
            else
            {
                return View(superhero);
            }
        
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            var superheroToDelete = db.Superhero.Where(s=>s.ID ==ID).FirstOrDefault();
            db.Superhero.Remove(superheroToDelete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }




        public ActionResult Details(int ID)
        {

            var superHeroDetails = db.Superhero.Where(s => s.ID == ID).FirstOrDefault();
            return View(superHeroDetails);

        }


        public ActionResult Edit(int? ID)
        {
            var superheroToEdit = db.Superhero.Where(s => s.ID == ID).FirstOrDefault();
            if (superheroToEdit == null)
            {

                return View("Not Found");
            }
            else
            {
                return View(superheroToEdit);
            }

        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID, Name, AlterEgo, PrimarySuperheroAbility, SecondarySuperheroAbility, Catchphrase")]Superhero superheroToEdit)
        {
            var Hero = db.Superhero.Where(s => s.ID == superheroToEdit.ID).FirstOrDefault();
            Hero.Name = superheroToEdit.Name;
            Hero.AlterEgo = superheroToEdit.AlterEgo;
            Hero.PrimarySuperheroAbility = superheroToEdit.PrimarySuperheroAbility;
            Hero.SecondarySuperheroAbility = superheroToEdit.SecondarySuperheroAbility;
            Hero.Catchphrase = superheroToEdit.Catchphrase;
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }

    }
}