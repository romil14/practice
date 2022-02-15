using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Custome.Filters
{
    public class CustomAuthorizationFilter : Attribute, IAuthorizationFilter
    {
        public string Role { get; set; }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // To Do: Add Code to check user permission
            //context.HttpContext.Response.WriteAsync("OnAuthorization => ");

            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                if (!context.HttpContext.User.IsInRole(Role))
                {
                    context.Result = new RedirectToActionResult("UnAuthorize", "Account", null);
                }
            }
            else
            {
                context.Result = new RedirectToActionResult("Login", "Account", null);
            }
        }
    }
}
