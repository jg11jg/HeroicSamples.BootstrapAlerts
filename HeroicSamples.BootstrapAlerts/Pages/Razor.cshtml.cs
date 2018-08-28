using HeroicSamples.BootstrapAlerts.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HeroicSamples.BootstrapAlerts.Pages
{
    public class RazorModel : PageModel
    {
        public IActionResult OnGet()
        {
            return this.WithSuccess("From Razor!", "This was done using a razor extension").Page();
        }
    }
}