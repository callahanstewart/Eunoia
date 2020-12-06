using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Eunoia.Pages
{
    public class ResponseModel : PageModel
    {
        private readonly ILogger<ResponseModel> _logger;

        public ResponseModel(ILogger<ResponseModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
