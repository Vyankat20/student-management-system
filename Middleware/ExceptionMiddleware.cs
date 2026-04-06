using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Text.Json;

namespace StudentManagementSystem.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next){_next=next;}

        public async Task Invoke(HttpContext ctx)
        {
            try{await _next(ctx);}
            catch(Exception ex)
            {
                ctx.Response.StatusCode=(int)HttpStatusCode.InternalServerError;
                await ctx.Response.WriteAsync(JsonSerializer.Serialize(new {error=ex.Message}));
            }
        }
    }
}
