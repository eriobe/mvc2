using informator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace informator.Controllers
{
    public class ReceipeController : Controller
    {
        // GET: Receipe
        public ActionResult FullDetails()
        {
            //ViewBag.Beskrivning = "Ett smaskigt recept";
            var Model = new ReceptInformationModels()
            {
                Namn = "Nåt gött"
            };
            return View(Model);
        }
    }
}