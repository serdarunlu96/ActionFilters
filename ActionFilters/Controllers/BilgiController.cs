using ActionFilters.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilters.Controllers
{
    public class BilgiController : Controller
    {
        //[Yonlen]
        [HepsiniGorelim]
        public IActionResult Index()
        {
            Console.WriteLine("*** [Action] Bilgi/Index ***");
            return View();
        }
    }
}
