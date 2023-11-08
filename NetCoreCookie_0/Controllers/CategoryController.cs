using Microsoft.AspNetCore.Mvc;
using NetCoreCookie_0.ExtensionMethods;
using NetCoreCookie_0.Models.ContextClasses;
using NetCoreCookie_0.Models.Entities;
using NetCoreCookie_0.Models.ShoppingTools;

namespace NetCoreCookie_0.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindContext _db;
        public CategoryController(NorthwindContext db)
        {
            _db = db;
        }
        public IActionResult SessionUsage()
        {



            //Cart c = new Cart();

            //CartItem ci = new()
            //{
            //    ID = 1,
            //    Name = "Test"
            //};

            //c.AddToCart(ci);



            Category c = new Category()
            {
                CategoryId = 1,
                CategoryName = "Test",
                Description = "Test verisidir",
            };

           

            HttpContext.Session.SetObject("category", c);


            //Cart c2 = HttpContext.Session.GetObject<Cart>("cart");


            return View();
        }
    }
}
