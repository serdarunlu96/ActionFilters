using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilters.Filters
{
    public class HepsiniGorelimAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("*** OnActionExecuting ***");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("*** OnActionExecuted ***");
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine("*** OnResultExecuting ***");
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine("*** OnResultExecuted ***");
        }
    }
}
