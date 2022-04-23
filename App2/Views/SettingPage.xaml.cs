using App2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        async void ButtonCategories_Clicked(System.Object sender, System.EventArgs e)
        {
            var kategoridataekle = new AddKategoriService();
            await kategoridataekle.AddCategoriesAsync();
        }

        async void ButtonProducts_Clicked(System.Object sender, System.EventArgs e)
        {
            var productsekle = new AddProductsService();
            await productsekle.AddProductItemAsync();
        }
    }
}