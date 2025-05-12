using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class AddEventModel : PageModel
    {
        [BindProperty]
        public Event NovoEvento { get; set; }

        public Action<Event> EventoCriado;

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            EventoCriado?.Invoke(NovoEvento);

            return RedirectToPage("/Index");
        }
    }
}
