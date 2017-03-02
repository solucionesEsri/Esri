using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				retVal = JsonConvert.DeserializeObject<List<Product>>(content);
			}
			return retVal;
		}
	}
}
