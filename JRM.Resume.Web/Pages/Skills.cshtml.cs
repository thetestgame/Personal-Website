using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JRM.Resume.Web.Pages
{
    public class SkillsModal : PageModel
    {
        private readonly ILogger<SkillsModal> _logger;

        public SkillsModal(ILogger<SkillsModal> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
