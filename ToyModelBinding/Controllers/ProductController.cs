using Microsoft.AspNetCore.Mvc;

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

            

            // Add to database

            //return a view
            return RedirectToActionPermanent("Index", "Home");

        }
    }
}
