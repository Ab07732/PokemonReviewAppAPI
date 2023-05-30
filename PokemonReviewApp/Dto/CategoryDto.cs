using Microsoft.AspNetCore.Mvc;

namespace PokemonReviewApp.Dto
{
    public class CategoryDto : Controller
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
