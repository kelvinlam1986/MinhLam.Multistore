using Microsoft.AspNetCore.Http;
using MinhLam.MultiStore.Domain.Repositories;
using System.Threading.Tasks;

namespace MinhLam.Multistore.Web.Middlewares
{
    public class VerifyInstallMiddleware
    {
        private readonly RequestDelegate next;

        public VerifyInstallMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext context, INoteRepository noteRepository)
        {
            var notes = noteRepository.GetAll();
            if (notes.Count == 0)
            {
                context.Response.Redirect("/Setup/Install");
            }
          
            return next(context);
        }
    }
}
