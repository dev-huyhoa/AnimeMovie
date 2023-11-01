using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Travel.Shared.ViewModels;

namespace MovieShare.Middleware
{
    public class UnauthorizedMiddleware
    {
        private readonly RequestDelegate _next;
        private Response res;

        public UnauthorizedMiddleware(RequestDelegate next)
        {
            _next = next;
            res = new Response();
        }

        public async Task Invoke(HttpContext context)
        {
            await _next(context);

            if (context.Response.StatusCode == 401)
            {
                await context.Response.WriteAsync("Không có quyền truy cập");
            }
        }
    }
}
