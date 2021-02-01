using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JRM.Resume.Web.Pages
{
    public class ExperienceModal : PageModel
    {
        private readonly ILogger<ExperienceModal> _logger;

        public ExperienceModal(ILogger<ExperienceModal> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
