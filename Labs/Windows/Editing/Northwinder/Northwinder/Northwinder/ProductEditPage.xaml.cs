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
        private Repository _repository;

        public ProductEditPage(Product product)
        {
            InitializeComponent();

            _repository = new Repository();
            _product = product;
            BindingContext = _product;
        }

        public async void OnSaveClicked(object sender, EventArgs e)
        {
            SaveButton.IsEnabled = false;
            await _repository.SaveProduct(_product);
            await Navigation.PopModalAsync();
        }
    }
}
