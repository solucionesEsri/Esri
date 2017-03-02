using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Northwinder
{
	public partial class ProductPage : ContentPage
	{
		private Product _product;

		public ProductPage(Product product)
		{
			InitializeComponent();

			_product = product;
			BindingContext = _product;
		}
	}
}
