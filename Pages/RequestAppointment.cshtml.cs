using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Eunoia.Pages
{
    public class RequestAppointmentModel : PageModel
    {
        private readonly ILogger<RequestAppointmentModel> _logger;

        public RequestAppointmentModel(ILogger<RequestAppointmentModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
