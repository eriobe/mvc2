using informator.DB;
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
        public ActionResult FullDetails(int ID)
        {
            //ViewBag.Beskrivning = "Ett smaskigt recept";
            //var Model = new ReceptInformationModels()
            //{
            //    Namn = "Nåt gött",
            //    Beskrivning = "Det här ska var en längre text"

            //};
            var DB = new ReceptDB();
            var Model = DB.GetRecepieDetails(ID);
            if(Model.Equals(null))
            {
                return null;
            }
            return View(Model);
        }
    }
}