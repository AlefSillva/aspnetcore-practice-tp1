using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public string Nome { get; set; }

        [BindProperty]
        public decimal Preco { get; set; }

        public bool DadosRecebidos { get; set; } = false;

        public void OnGet()
        { 

        }

        public void OnPost()
        {
            DadosRecebidos = true;
        }

    }
}