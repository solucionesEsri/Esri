using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Northwinder
{
    public class Repository
    {
        private const string url = "https://svc.treeloop.com/api/products";

        public async Task<List<Product>> GetAllProducts()
        {
            var retVal = new List<Product>();
            var client = new HttpClient();

            var response = await client.GetAsync(url);
            response.StatusCode = System.Net.HttpStatusCode.NotFound;

            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                retVal = JsonConvert.DeserializeObject<List<Product>>(content);
                DependencyService.Get<ILocalCache>().SaveText(content, "products.json");
            } else {
                var content = await DependencyService.Get<ILocalCache>().LoadText("products.json");
                retVal = JsonConvert.DeserializeObject<List<Product>>(content);
            }
            return retVal;
        }

        public async Task<bool> SaveProduct(Product product)
        {
            var retVal = false;
            var client = new HttpClient();

            var address = $"{url}/{product.Id}";
            var payload = JsonConvert.SerializeObject(product);

            //var response = await client.PutAsync(address, new StringContent(payload, Encoding.UTF8, "application/json"));

            return true;
        }
    }
}
