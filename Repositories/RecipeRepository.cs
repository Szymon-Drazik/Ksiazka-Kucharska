using WebApplicationGr3.Model;

namespace WebApplicationGr3.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        AppDbContext appDbContext = new AppDbContext();
        public RecipeRepository()
        {
            appDbContext.Database.EnsureCreated();
        }
        public bool Create(Recipe entity)
        {
            appDbContext.Recipes.Add(entity);
            return appDbContext.SaveChanges() == 1;
        }
        public Recipe Read(int Id)
        {
            return appDbContext.Recipes.Find(Id) ?? new Recipe();
        }
        public List<Recipe> ReadAll()
        {
            return appDbContext.Recipes.ToList();
        }
        public bool Update(Recipe entity)
        {
            appDbContext.Recipes.Update(entity);
           
            return appDbContext.SaveChanges() == 1;
        }
        public bool Delete(Recipe entity)
        {
            appDbContext.Recipes.Remove(entity);

            return appDbContext.SaveChanges() == 1;
        }
    }
}
