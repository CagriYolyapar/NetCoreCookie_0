using Microsoft.AspNetCore.Mvc;

namespace NetCoreCookie_0.Controllers
{
    public class SessionUsageController : Controller
    {

        //Unutmayın ki Session kullanabilmeniz icin onu Middleware'e eklemeniz lazım...
        public IActionResult SessionIndex()
        {
            SetSession();
            ViewBag.Message = GetSession();
            
            return View();
        }

        void SetSession()
        {
            //Session olusturuyorsunuz.Öncelikle olusturacagınız Session'in anahtarını yazıyorsunuz sonra icindeki hangi veriyi saklamak istediginizi yazıyorsunuz.
            HttpContext.Session.SetString("Cagri", "Deneme");
        }

        string GetSession()
        {
            //GetString ile Cagri anahtarına sahip olan session'i cagırıyoruz...
            return HttpContext.Session.GetString("Cagri");
        }
    }
}
