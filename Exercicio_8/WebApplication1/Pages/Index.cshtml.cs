using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<(string Nome, decimal Preco)> Produtos { get; set; }

        public void OnGet()
        {
            Produtos = new List<(string, decimal)>
            {
                ("Notebook", 3500.00m),
                ("Celular", 2200.00m),
                ("Fone Bluetooth", 199.99m)
            };
        }
    }
}
