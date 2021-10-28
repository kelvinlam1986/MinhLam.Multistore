using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using MinhLam.Multistore.Web.Middlewares;

namespace MinhLam.Multistore.Web.Extensions
{
    public static class VerifyInstallMiddlewareExtension
    {
        public static IApplicationBuilder UseVerifyInstallMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseWhen(ShouldBeginHomePage, appBuilder =>
            {
                appBuilder.UseMiddleware<VerifyInstallMiddleware>();
            });
        }

        public static bool ShouldBeginHomePage(HttpContext context)
        {
            var path = context.Request.Path;
            if (path.Value == "/")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
