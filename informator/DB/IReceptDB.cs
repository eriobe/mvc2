using informator.Controllers;

namespace informator.DB
{
    public interface IReceptDB
    {
        RecipeDetailsModel GetRecepieDetails(int ID);
    }
}