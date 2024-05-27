using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPissa.Models;

namespace RazorPissa.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle = "tt.jpeg" ,
                PizzaName="Magerita",
                BasePrice=2,
                TomatoSauce =true,
                Cheese=true,
                FinalPrice=4},
            new PizzasModel(){ImageTitle = "tt" ,
                PizzaName="tt",
                BasePrice=2,
                TomatoSauce =true,
                Cheese=true,
                FinalPrice=4},
        };
        public void OnGet()
        {
        }
    }
}
