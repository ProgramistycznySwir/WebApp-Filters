using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Filters.Utils
{
    public class IpSavingFilterAttributes : ResultFilterAttribute, IAsyncPageFilter
    {
        System.Net.IPAddress ip;

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            // Kocham pattern matching, nie mogę się powstrzymać przed składnią z C#9 i zrobieniem tego w taki sposób:
            // if (context.Result as PageResult is var page and page is not null)
            if (context.Result as PageResult is var page && !(page is null))
                page.ViewData["remoteIpAddress"] = ip.ToString();
        }
        public Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            ip = context.HttpContext.Connection.RemoteIpAddress;
            
            //page.ViewData["filterMessage"];
            return next.Invoke();
            //throw new NotImplementedException();
        }

        public Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            //throw new NotImplementedException();
            return Task.CompletedTask;
        }
    }
}
