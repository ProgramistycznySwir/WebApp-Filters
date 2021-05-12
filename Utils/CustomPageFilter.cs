using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApp_Filters.Utils
{
    public class CustomPageFilter : IPageFilter
    {
        // 1 - działa tylko raz
        public CustomPageFilter(IConfiguration _config)
        {
            int a = 0;
        }
        // 2
        public void OnPageHandlerSelected(PageHandlerSelectedContext pageContext)
        {
            int a = 0;
        }
        // 3
        public void OnPageHandlerExecuting(PageHandlerExecutingContext pageContext)
        {
            int a = 0;
        }
        // 4
        public void OnPageHandlerExecuted(PageHandlerExecutedContext pageContext)
        {
            int a = 0;
        }
    }
}
