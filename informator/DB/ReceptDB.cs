using informator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace informator.DB
{
    public class ReceptDB
    {
        private static List<RecipeDetailsModel> Recept = new List<RecipeDetailsModel> {
        new RecipeDetailsModel {
            Name = "JoGl",
            Summary = "Det är gott med jordgubbsglass"
        }

        };
        public RecipeDetailsModel GetRecepieDetails(int ID)
        {
            return ID < Recept.Count ? Recept[ID] : null;
        }
    }
}