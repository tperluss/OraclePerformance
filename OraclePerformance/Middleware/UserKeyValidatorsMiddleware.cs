using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OraclePerformance.Middleware
{
    public class UserKeyValidatorsMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _config;
        private readonly IHttpContextAccessor _accessor;

        public UserKeyValidatorsMiddleware(RequestDelegate next, IConfiguration config, IHttpContextAccessor accessor)
        {
            _next = next;
            _config = config;
            _accessor = accessor;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Request.Headers.TryGetValue("Authorization", out var authHeader);

            if (string.IsNullOrEmpty(authHeader))
            {
                context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                await context.Response.WriteAsync("Invalid Authorization");
                return;
            }

            if (authHeader != _config.GetSection("ApiKey").Value)
            {
                context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                await context.Response.WriteAsync("Invalid Authorization.  The ApiKey provided is not valid.");
                return;
            }

            await _next.Invoke(context);
        }
    }

    #region ExtensionMethod
    public static class UserKeyValidatorsExtension
    {
        public static IApplicationBuilder ApplyUserKeyValidation(this IApplicationBuilder app)
        {
            app.UseMiddleware<UserKeyValidatorsMiddleware>();
            return app;
        }

        public static Guid TryConvert(this string str)
        {
            var guid = new Guid();
            Guid.TryParse(str, out guid);
            return guid;
        }
    }
    #endregion
}
