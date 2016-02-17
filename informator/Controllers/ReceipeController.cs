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
            ViewBag.ID = ID;


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
        public ActionResult Submit()
        {
            
            return View("RecipeSubmit");

        }
        [HttpPost]
        public ActionResult Submit(RecipeDetailsModel insert)
        {
            if (ModelState.IsValid)
            {
                int id = ro.AddRecipe(insert);
                return RedirectToAction("FullDetails", new { id = id });
            }
            else
            {
                return View("RecipeSubmit");
            }

        }

        [HttpPost]
        public ActionResult Edit(int id, RecipeDetailsModel edit)
        {


            ro.EditRecipe(id,edit);
            return RedirectToAction("FullDetails", new { id = id });

        }




    }
}