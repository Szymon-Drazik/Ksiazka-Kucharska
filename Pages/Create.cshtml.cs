using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationGr3.Model;
using WebApplicationGr3.Repositories;

namespace WebApplicationGr3.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IRecipeRepository _RecipeRepository;
        public CreateModel(IRecipeRepository placeRepository)
        {
            _RecipeRepository = placeRepository;
        }

        [BindProperty]
        public Recipe Recipe { get; set; }
        public IFormFile PhotoFile { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (PhotoFile != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    PhotoFile.CopyTo(ms);
                    Recipe.Image = ms.ToArray();
                }
            }


            _RecipeRepository.Create(Recipe);

            return RedirectToPage("/View");
        }


    }
}
