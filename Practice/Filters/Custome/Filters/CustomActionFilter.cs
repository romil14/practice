using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Custome.Filters
{
    public class CustomActionFilter : Attribute, IActionFilter
    {
        //After
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var user = context.HttpContext.User;
            var action = context.ActionDescriptor.DisplayName;
            var controller = context.Controller.ToString();
            context.HttpContext.Response.WriteAsync("Action (after) => ");
        }

        //Before
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var user = context.HttpContext.User;
            var action = context.ActionDescriptor.DisplayName;
            var controller = context.Controller.ToString();

            context.HttpContext.Response.WriteAsync("Action (before) => ");
        }
    }
}
