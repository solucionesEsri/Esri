using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Northwinder
{
    public partial class ProductListPage : ContentPage
    {
        private ProductListViewModel _pvm;

        public ProductListPage()
        {
            InitializeComponent();

            var r = new Repository();
            _pvm = new ProductListViewModel(r.GetAllProducts());
            BindingContext = _pvm;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var product = e.SelectedItem as Product;
            if (product != null) {
                listView.SelectedItem = null;
                await Navigation.PushAsync(new ProductPage(product));
            }
        }
    }
}
