using App2.Services;
using App2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App2.ViewModels
{
    class GirisYapViewModel : BaseViewModel
    {
        private string _UserPhone;
        public string UserPhone
        {
            set
            {
                this._UserPhone = value;
                OnPropertyChanged();
            }

            get
            {
                return this._UserPhone;
            }
        }

        private string _UserMail;
        public string UserMail
        {
            set
            {
                this._UserMail = value;
                OnPropertyChanged();
            }

            get
            {
                return this._UserMail;
            }
        }

        private bool _IsBusy;
        public bool IsBusyy
        {
            set
            {
                this._IsBusy = value;
                OnPropertyChanged();
            }

            get
            {
                return this._IsBusy;
            }
        }

        private bool _Result;
        public bool Result
        {
            set
            {
                this._Result = value;
                OnPropertyChanged();
            }

            get
            {
                return this._Result;
            }
        }

        public Command LoginCommand { get; set; }

        public GirisYapViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
        }

        private async Task LoginCommandAsync()
        {
            if (IsBusyy)
                return;
            try
            {
                IsBusyy = true;
                var üyelikService = new ÜyelikServices();
                Result = await üyelikService.LoginUser(UserPhone);

                if (Result)
                {
                    Preferences.Set("TelefonNo", UserPhone);
                    await Application.Current.MainPage.Navigation.PushModalAsync(new AboutPage());
                }

                else
                    await Application.Current.MainPage.DisplayAlert("Error", "Hatalı Giriş", "OK");

            }

            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }

            finally
            {
                IsBusyy = false;
            }
        }
    }
}
