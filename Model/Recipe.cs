using System.ComponentModel.DataAnnotations;

namespace WebApplicationGr3.Model
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nazwa")]
        public string? Name { get; set; }
        [Display(Name = "Ingridients")]
        public string? Category { get; set; }
        [Display(Name = "Kategoria")]
        public string? Ingridient { get; set; }
        [Display(Name = "Opis")]
        public string? Description { get; set; }
        [Display(Name = "Krótki Opis")]
        public string? ShortDescription { get; set; }
        [Display(Name = "Zdjęcie")]
        public byte[]? Image { get; set; }

    }
}
