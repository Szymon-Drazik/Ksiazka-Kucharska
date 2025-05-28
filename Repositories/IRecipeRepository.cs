using WebApplicationGr3.Model;

namespace WebApplicationGr3.Repositories
{
    public interface IRecipeRepository
    {
        bool Create(Recipe entity);
        Recipe Read(int Id);
        List<Recipe> ReadAll();
        bool Update(Recipe entity);
        bool Delete(Recipe entity);
    }
}
