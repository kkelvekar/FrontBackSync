using FrontBackSync.Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontBackSync.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private static List<Item> items = new List<Item>
        {
            new Item { Id = 1, Name = "Item 1", Description = "Description of Item 1" },
            new Item { Id = 2, Name = "Item 2", Description = "Description of Item 2" }
        };

        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return items;
        }
    }
}
