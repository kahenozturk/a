using App2.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2.ViewModels
{
    public class ÜyeOlViewModel : BaseViewModel
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

        public Command RegisterCommand { get; set; }

        public ÜyeOlViewModel()
        {
            RegisterCommand = new Command(async () => await RegisterCommandAsync());
        }

        private async Task RegisterCommandAsync()
        {
            if (IsBusyy)
                return;
            try
            {
                IsBusyy = true;
                var üyelikService = new ÜyelikServices();
                Result = await üyelikService.RegisterUser(UserPhone, UserMail);

                if (Result)
                    await Application.Current.MainPage.DisplayAlert("Succes", "Kayıt Tamamlandı", "OK");

                else
                    await Application.Current.MainPage.DisplayAlert("Error", "Kullanıcı zaten kayıtlı", "OK");


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
