using App2.Models;
using App2.ViewModels;
using App2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;




namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ÜyelikGirisPage : ContentPage
    {

        public ÜyelikGirisPage()
        {
            InitializeComponent();

        }

     

        private async void UyeOl_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ÜyelikPage());

        }
        private async void GirisYap_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GirişYapPage());

        }
    }
}