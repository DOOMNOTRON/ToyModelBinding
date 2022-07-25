using Microsoft.AspNetCore.Mvc;
using ToyModelBinding.Models;

namespace ToyModelBinding.Controllers
{
    public class ProductController : Controller
    {
        // GET: /Product/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]// THis action is hit after the user submits form data
        public IActionResult Create(IFormCollection formData)
        {

            // Validate data

            Toy t = new() // Must be the class to use
            {
                Title = formData["title"],

                Price = Convert.ToDouble(formData["price"]),

                Quantity = Convert.ToInt32(formData["quantity"])
            }; 


            // Add to database

            //return a view
            return RedirectToActionPermanent("Index", "Home");

        }

        [HttpGet]
        public IActionResult CreateWithModelBinding()
        {
            return View();
        }

        
    }
}
