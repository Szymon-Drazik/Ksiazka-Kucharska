using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationGr3.Model;
using WebApplicationGr3.Repositories;

namespace WebApplicationGr3.Pages
{
    public class ViewModel : PageModel
    {
        private readonly IRecipeRepository _RecipeRepository;
        public ViewModel(IRecipeRepository RecipeRepository)
        {
            _RecipeRepository = RecipeRepository;
        }
        public List<Recipe> RecipeList { get; set; }
        public void OnGet()
        {
            RecipeList = _RecipeRepository.ReadAll();
        }


        public IActionResult OnPost(int Id)
        {
            _RecipeRepository.Delete(_RecipeRepository.Read(Id));

            return RedirectToPage("/View");

        }
    }
}
