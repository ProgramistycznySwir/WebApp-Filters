using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using WebApp_Filters.Utils;


namespace WebApp_Filters.Pages
{
    [IpSavingFilterAttributes]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        // Ta zmienna jest ustawiana pomiędzy metodą 1 i 2.
        [BindProperty(SupportsGet = true)]
        public int testVriable { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        
        // 1
        public override void OnPageHandlerSelected(PageHandlerSelectedContext pageContext)
        {
            int a = 0;
        }
        // 2
        public override void OnPageHandlerExecuting(PageHandlerExecutingContext pageContext)
        {
            int a = 0;
        }
        // 4
        public override void OnPageHandlerExecuted(PageHandlerExecutedContext pageContext)
        {
            int a = 0;
        }
        // 3
        public void OnGet()
        {
            int a = 0;
        }
    }
}