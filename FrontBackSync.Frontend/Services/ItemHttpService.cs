using FrontBackSync.Frontend.Models;

namespace FrontBackSync.Frontend.Services
{
    public class ItemHttpService
    {
        private readonly HttpClient client;

        public ItemHttpService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<List<Item>> GetItemsAsync()
        {
            try
            {
                var result = await client.GetFromJsonAsync<List<Item>>("Items");
                if (result != null)
                {
                    return result;
                }
                else
                {
                    return new List<Item>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting items", ex);
            }
        }

    }
}
