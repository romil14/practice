using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware.Custom.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomMiddleware1
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware1(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            //To Do Code..

            //httpContext.Response.WriteAsync("Custome Middleware!");
            //return _next(httpContext);

            await httpContext.Response.WriteAsync("Custome Middleware!");
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CustomMiddleware1Extensions
    {
        public static IApplicationBuilder UseCustomMiddleware1(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleware1>();
        }
    }
}
