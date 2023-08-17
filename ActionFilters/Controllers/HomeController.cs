using ActionFilters.Filters;
using ActionFilters.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace ActionFilters.Controllers
{
    //[Yonlen]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //_logger.LogInformation("Index()");
            return View();
        }

        //[Yonlen]
        public IActionResult Privacy()
        {
            //_logger.LogInformation("Privacy()");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //public override void OnActionExecuting(ActionExecutingContext context)
        //{
        //    _logger.LogInformation("OnActionExecuting()");
           
        //    if (context.HttpContext.Request.Query["yonlen"] == "true")
        //        context.Result = new RedirectResult("https://google.com");
        //}

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            //_logger.LogInformation("OnActionExecuted()");
        }
    }
}