using informator.Controllers;
using informator.Models;
using System.Collections.Generic;

namespace informator.Data
{
    public interface IRecipeOperations
    {
        RecipeDetailsModel GetRecipe(int id);
        List<RecipeSummaryModel> GetAllRecipes();
        int AddRecipe(RecipeDetailsModel receptModell);
        void EditRecipe(int id, RecipeDetailsModel receptModell);

    }
}