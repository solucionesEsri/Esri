using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Northwinder
{
    public partial class ProductEditPage : ContentPage
    {
        private Product _product;

        public ProductEditPage(Product product)
        {
            InitializeComponent();

            _product = product;
            BindingContext = _product;
        }
    }
}
