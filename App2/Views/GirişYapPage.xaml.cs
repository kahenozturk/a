using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using App2.Models;
using App2.ViewModels;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GirişYapPage : ContentPage
    {
        public GirişYapPage()
        {
            InitializeComponent();
            this.BindingContext = new GirisYapViewModel();
        }


    }
}