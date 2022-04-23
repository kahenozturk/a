using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using App2.Models;
using App2.Services;
using App2.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App2.ViewModels
{
    class CategoriesViewModel : BaseViewModel
    {

        //private IEnumerable<string> imageList;
        //public IEnumerable<string> ImageList
        //{
        //    get => imageList;
        //    set => SetProperty(ref imageList, value);
        //}

        //public CategoriesViewModel(INavigationService navigationService)
        //    : base(navigationService)
        //{
        //    Title = "Carousel View";
        //}
        //public override void Initialize(INavigationParameters parameters)
        //{
        //    base.Initialize(parameters);
        //    ImageList = new List<string>
        //    {

        //    };
        //}

        private string _UserPhone;
        public string UserPhone
        {
            get { return _UserPhone; }
            set { _UserPhone = value; OnPropertyChanged(); }
        }

        private int _UserCartItemsCount;
        public int UserCartItemsCount
        {
            get { return _UserCartItemsCount; }
            set { _UserCartItemsCount = value; OnPropertyChanged(); }
        }

        public ObservableCollection<Kategoriler> Kategorilers { get; set; }
        public ObservableCollection<Product> LatestItems { get; set; }


        public Command ViewCartCommand { get; set; }
        public Command LogOutCommand { get; set; }

        public CategoriesViewModel()
        {
            var userphone = Preferences.Get("TelefonNo", string.Empty);
            if (string.IsNullOrEmpty(userphone))
            {
                userphone = "Guest";

            }
            else
                UserPhone = userphone;


            UserCartItemsCount = new CartItemService().GetUserCartCount();

            Kategorilers = new ObservableCollection<Kategoriler>();
            LatestItems = new ObservableCollection<Product>();

            ViewCartCommand = new Command(async () => await ViewCartAsync());
            LogOutCommand = new Command(async () => await LogOutCommandAsync());

            GetKategoriler();
            GetLatestItems();



        }
        private async Task ViewCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new CartView());
        }
        private async Task LogOutCommandAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new LogOutView());

        }



        private async void GetKategoriler()
        {
            var data = await new GetKategoriService().GetCategoriesAsync();
            Kategorilers.Clear();
            foreach (var item in data)
            {
                Kategorilers.Add(item);
            }

        }


        private async void GetLatestItems()
        {
            var data = await new GetProductsService().GetLatestProductAsync();
            LatestItems.Clear();
            foreach (var item in data)
            {
                LatestItems.Add(item);
            }
        }

        


        /*public ObservableCollection<Kategoriler> Kategories { get; set; }

        public CategoriesViewModel()
        {
            Kategories = new ObservableCollection<Kategoriler>();

            GetCategories();
        }

        private async void GetCategories()
        {
            var data = await new GetKategoriService().GetCategoriesAsync();

            Kategories.Clear();
            foreach (var item in data)
            {
                Kategories.Add(item);
            }
        }*/
    }
}
