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
                ("Notebook", 4000.00m),
                ("Iphone 8", 3000.00m),
                ("Fone Bluetooth", 149.99m)
            };
        }
    }
}
