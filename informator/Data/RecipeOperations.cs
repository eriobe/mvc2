using informator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace informator.Data
{
    public class RecipeOperations
    {
        private static List<RecipeDetailsModel> Recipes = new List<RecipeDetailsModel>
        {
            new RecipeDetailsModel
            {
                Name = "Pasta and Pesto",
                Summary = "Very simple, and yet very tasty! Hardly any effort.",
                Ingredients = "Pasta, Pesto",
                CookingTimeInMinutes = 15,
                Instructions = "Bring water to the boil. Cook the pasta for 10 minutes, then drain it. Add pesto."
            },
            new RecipeDetailsModel
            {
                Name = "Tasty Fried Rice",
                Summary = "An easy rice base, good for adding extra flavors to.",
                Ingredients = "Rice, Eggs, Curry Powder, Coriander, Mint",
                CookingTimeInMinutes = 20,
                Instructions = "Boil the rice. Whisk the eggs, and then fry them into an omlette. Mix curry powder, coriander and mint in water to make a sauce. Transfer rice to a frying pan with hot oil, cut the omlette into small slices and add it, pour in the sauce and stir the lot together. Serve with mango chutney and/or sambal oelek as you prefer."
            },
        };

        public RecipeDetailsModel GetRecipe(int id)
        {
            return id < Recipes.Count ? Recipes[id] : null;
        }
    }
}