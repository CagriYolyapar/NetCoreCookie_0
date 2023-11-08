using Microsoft.AspNetCore.Mvc;

namespace NetCoreCookie_0.Controllers
{
    public class CookieUsageController : Controller
    {


        //        Client , Server
        //HTTP => Request, Response

        //Bir Cookie'nin olusturulması (setleyebilmek) Response, getirebilmek icin Request kullanılır...

        public IActionResult CookieIndex()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CookieIndex(string deger)
        {
            SetCookie(deger);
            
            return View();

        }


        public IActionResult SimulationPage()
        {
            ViewBag.Message = GetCookie();
            return View();
        }

        void SetCookie(string deger)
        {
            HttpContext.Response.Cookies.Append("Cagri",deger,new CookieOptions
            {
                Expires = DateTime.Now.AddDays(1),
                HttpOnly = true, //document.cookie kodunu console'da(inspect tarafında) yazdıgınızda bu ayarla sistemiyle olusturulan cookie'nin gözlemlenmesini engeller
                SameSite = SameSiteMode.Strict
            });
        }
        

        string GetCookie()
        {
            HttpContext.Request.Cookies.TryGetValue("Cagri",out string? cookie);
            return cookie;           
        }
    }
}
