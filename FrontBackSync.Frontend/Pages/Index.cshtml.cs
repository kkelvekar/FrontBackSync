using FrontBackSync.Frontend.Models;
using FrontBackSync.Frontend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FrontBackSync.Frontend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ItemHttpService itemHttpService;

        public List<Item> Items { get; private set; }

        public IndexModel(ItemHttpService itemHttpService)
        {
            this.itemHttpService = itemHttpService;
        }

        public async Task OnGetAsync()
        {
           Items = await itemHttpService.GetItemsAsync();
        }
    }
}
