using App2.Views;
using App2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2.ViewModels
{
    public class ÜyelikGirisViewModel : ContentView
    {

        public ÜyelikGirisViewModel()
        {
        }
        private async void OnÜyeOl(object obj)
        {
            await Shell.Current.GoToAsync(nameof(ÜyelikPage));
        }
        private async void OnGirisYap(object obj)
        {
            await Shell.Current.GoToAsync(nameof(GirişYapPage));
        }


    }
}