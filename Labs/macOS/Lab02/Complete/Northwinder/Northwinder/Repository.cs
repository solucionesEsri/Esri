using System;
using System.Collections.Generic;

namespace Northwinder
{
	public class Repository
	{
		public IEnumerable<Product> GetAllProducts()
		{
			return new List<Product>()
			{
				new Product() { Id = 1, Name = "Product One", Package = "Box", UnitPrice = 10.00, IsDiscontinued = false },
				new Product() { Id = 2, Name = "Product Two", Package = "Bottle", UnitPrice = 5.00, IsDiscontinued = false }
			};
		}
	}
}
