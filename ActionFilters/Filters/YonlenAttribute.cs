using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilters.Filters
{
    public class YonlenAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Query["yonlen"] == "true")
                context.Result = new RedirectResult("https://yandex.com");
        }

    }
}
