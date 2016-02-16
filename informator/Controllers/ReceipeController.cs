using informator.Data;
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
        private IRecipeOperations ro;

        public ReceipeController(IRecipeOperations ro)
        {
            this.ro = ro;
        }
        // GET: Receipe
        public ActionResult FullDetails(int ID)
        {
            //ViewBag.Beskrivning = "Ett smaskigt recept";
            //var Model = new ReceptInformationModels()
            //{
            //    Namn = "Nåt gött",
            //    Beskrivning = "Det här ska var en längre text"

            //};


            var ro = new RecipeOperations();
            var recipe = ro.GetRecipe(ID);
            if (recipe != null)
                return View(recipe);
            else
                return HttpNotFound();
        }
        public ActionResult Index()
        {
            //throw new NotImplementedException();
            return View(ro.GetAllRecipes());

        }
    }
}