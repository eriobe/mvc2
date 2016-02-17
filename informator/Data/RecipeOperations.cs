using informator.Controllers;
using informator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace informator.Data
{
    public class RecipeOperations : IRecipeOperations
    {
        //private static List<RecipeDetailsModel> Recipes = new List<RecipeDetailsModel>
        //{
        //    new RecipeDetailsModel
        //    {
        //        Name = "Pasta and Pesto",
        //        Summary = "Very simple, and yet very tasty! Hardly any effort.",
        //        Ingredients = "Pasta, Pesto",
        //        CookingTimeInMinutes = 15,
        //        Instructions = "Bring water to the boil. Cook the pasta for 10 minutes, then drain it. Add pesto."
        //    },
        //    new RecipeDetailsModel
        //    {
        //        Name = "Tasty Fried Rice",
        //        Summary = "An easy rice base, good for adding extra flavors to.",
        //        Ingredients = "Rice, Eggs, Curry Powder, Coriander, Mint",
        //        CookingTimeInMinutes = 20,
        //        Instructions = "Boil the rice. Whisk the eggs, and then fry them into an omlette. Mix curry powder, coriander and mint in water to make a sauce. Transfer rice to a frying pan with hot oil, cut the omlette into small slices and add it, pour in the sauce and stir the lot together. Serve with mango chutney and/or sambal oelek as you prefer."
        //    },
        //};

        //public RecipeDetailsModel GetRecipe(int id)
        //{
        //    return id < Recipes.Count ? Recipes[id] : null;
        //}

        public RecipeDetailsModel GetRecipe(int id)
        {
            using (var db = new RecipesEntities())
            {
                return (from r in db.Recipes
                        where r.ID == id
                        select new RecipeDetailsModel
                        {
                            Name = r.Name,
                            Summary = r.Summary,
                            CookingTimeInMinutes = r.CookingTime,
                            Ingredients = r.Ingredients,
                            Instructions = r.Instructions
                        }).FirstOrDefault();
            }
        }
        /// <summary>
        /// metod som hämtar delar av informationen och returnerar som en lista
        /// </summary>
        /// <returns></returns>
        /// 

        /*public List<RecipeSummaryModel> GetAllRecipes()
        {
            //tempobjekt
            var result = new List<RecipeSummaryModel>();

            foreach (var recept in Recipes)
            {
                result.Add(new RecipeSummaryModel
                {
                    
                    Name=recept.Name,
                    Summary = recept.Summary

                });
            }
            return result;
        }
        */
        public List<RecipeSummaryModel> GetAllRecipes()
        {
            using (var db = new RecipesEntities())
            {
                return (from recept in db.Recipes
                        select new RecipeSummaryModel
                        {
                            Id = recept.ID,
                            Name = recept.Name,
                            Summary = recept.Summary
                        }).ToList();
            }
        }

        public int AddRecipe(RecipeDetailsModel receptModell)
        {
            ////Utan databas
            //Recipes.Add(receptModell);
            //return Recipes.Count-1;
            using (var db = new RecipesEntities())
            {
                var toAdd = new Recipes
                {
                    Name = receptModell.Name,
                    Summary = receptModell.Summary,
                    CookingTime = receptModell.CookingTimeInMinutes,
                    Ingredients=receptModell.Ingredients,
                    Instructions = receptModell.Instructions
                    
                    
                };
                db.Recipes.Add(toAdd);
                db.SaveChanges();
                return toAdd.ID;
            }

            
        }

        public void EditRecipe(int id, RecipeDetailsModel receptModell)
        {
            //Recipes[id].Name = receptModell.Name;
        }
    }
}