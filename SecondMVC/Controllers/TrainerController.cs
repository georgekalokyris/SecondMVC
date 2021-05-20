using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondMVC.Models;

namespace SecondMVC.Controllers
{
    public class TrainerController : Controller
    {
        // GET: Trainer
        public ActionResult Index()
        {
            Trainer T1 = new Trainer() { FirstName = "Hector", LastName = "Gkatsos" , Subject="Abc"};
            Trainer T2 = new Trainer() { FirstName = "George", LastName = "Kalok" ,Subject="efg"};
            Trainer T3 = new Trainer() { FirstName = "George", LastName = "Papad" ,Subject="hij"};

            List<Trainer> trainers = new List<Trainer>() { T1, T2, T3 };

            return View(trainers);
        }
    }
}