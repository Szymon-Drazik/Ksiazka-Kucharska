using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationGr3.Model;
using WebApplicationGr3.Repositories;

namespace WebApplicationGr3.Pages
{
    public class UpdateModel : PageModel
    {
        private readonly IRecipeRepository _RecipeRepository;
        public UpdateModel(IRecipeRepository RecipeRepository)
        {
            _RecipeRepository = RecipeRepository;
        }

        [BindProperty]
        public Recipe Recipe { get; set; }
        public IFormFile PhotoFile { get; set; }
        public void OnGet(int Id)
        {
            Recipe = _RecipeRepository.Read(Id);
        }

        public IActionResult OnPost(int Id)
        {
            Recipe RecipeToUpdate = _RecipeRepository.Read(Id);

            RecipeToUpdate.Name = Recipe.Name;
            RecipeToUpdate.Category = Recipe.Category;
            RecipeToUpdate.Description = Recipe.Description;
            RecipeToUpdate.ShortDescription = Recipe.ShortDescription;
            RecipeToUpdate.Ingridient = Recipe.Ingridient;

            _RecipeRepository.Update(RecipeToUpdate);

            if (PhotoFile != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    PhotoFile.CopyTo(ms);
                    RecipeToUpdate.Image = ms.ToArray();
                }
            }

            _RecipeRepository.Update(RecipeToUpdate);

            return RedirectToPage("/View");

        }
    }
}
