using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Northwinder
{
	public class ProductListViewModel
	{
		public ProductListViewModel(IEnumerable<Product> products = null)
		{
			Products = new ObservableCollection<Product>();
			if (products != null) foreach (var p in products) Products.Add(p);
		}

		public ObservableCollection<Product> Products { get; set; }
	}
}
