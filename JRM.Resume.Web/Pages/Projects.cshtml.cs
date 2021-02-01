using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JRM.Resume.Web.Pages
{
    public class ProjectsModal : PageModel
    {
        private readonly ILogger<ProjectsModal> _logger;

        public ProjectsModal(ILogger<ProjectsModal> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
