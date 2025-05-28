using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationGr3.Model;
using WebApplicationGr3.Repositories;

namespace WebApplicationGr3.Pages
{
    public class ReadModel : PageModel
    {
        private readonly IRecipeRepository _placeRepository;
        public ReadModel(IRecipeRepository placeRepository)
        {
            _placeRepository = placeRepository;
        }
        public Recipe Recipe { get; set; }
        public void OnGet(int Id)
        {
            Recipe = _placeRepository.Read(Id);
        }
    }
}
