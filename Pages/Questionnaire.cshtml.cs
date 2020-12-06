using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Eunoia.Pages
{
    public class QuestionnaireModel : PageModel
    {
        private readonly ILogger<QuestionnaireModel> _logger;

        public QuestionnaireModel(ILogger<QuestionnaireModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
