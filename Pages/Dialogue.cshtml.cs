using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Eunoia.Pages
{
    public class DialogueModel : PageModel
    {
        private readonly ILogger<DialogueModel> _logger;

        public DialogueModel(ILogger<DialogueModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
