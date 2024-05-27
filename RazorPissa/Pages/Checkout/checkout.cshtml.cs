using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPissa.Data;
using RazorPissa.Models;

namespace RazorPissa.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class checkoutModel : PageModel
    {

       
        public string Pizzaname { get; set; }

        public float PizzaPrice { get; set; }

        public string ImageTitle { get; set; }

        private readonly ApplicationDBContext context;
        
        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(Pizzaname))
            {
                Pizzaname = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "tt";
            }
        }
    }
}
