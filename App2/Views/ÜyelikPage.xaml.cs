using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Models;
using SQLite;
using App2.ViewModels;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ÜyelikPage : ContentPage
    {
        public ÜyelikPage()
        {
            InitializeComponent();
            this.BindingContext = new ÜyeOlViewModel();
        }

    }
}