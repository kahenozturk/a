using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Models;
using App2.ViewModels;
using App2.Views;

namespace App2.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HesabımPage : ContentPage

    {

        public HesabımPage()
        {
            InitializeComponent();

        }

        private async void UyeGiris_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ÜyelikGirisPage());

        }



    }
}