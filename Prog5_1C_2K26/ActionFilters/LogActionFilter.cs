using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Prog5_1C_2K26.ActionFilters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("Antes de ejecutar la acción");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("Despues de ejecutar la acción");
        }
    }
}
