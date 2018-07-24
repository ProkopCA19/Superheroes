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


            return View();
        }


        public ActionResult Create()
        {
            ViewBag.SuperheroID = new SelectList(db.Superhero, "ID", "Name", "AlterEgo", "PrimarySuperheroAbility", "SecondarySuperheroAbility", "Catchphrase");
            return ViewBag();
        }

        public ActionResult Delete()
        {

        }

        public ActionResult Edit()
        {

        }


        



    }
}