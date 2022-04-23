using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using App2.Models;
using Xamarin.Forms;

namespace App2.Services
{
    public class AddKategoriService
    {
       

        FirebaseClient Client;
        public List<Kategoriler> Categories { get; set; }

        public AddKategoriService()
        {
            Client = new FirebaseClient("https://depoo-2560f-default-rtdb.firebaseio.com/");
            Categories = new List<Kategoriler>()
            {
                new Kategoriler()
                {
                    CategoryId=1,
                    CategoryName="Meyve&Sebze",
                    ImageUrl="meyvesebze.png"

                },

                 new Kategoriler()
                {
                    CategoryId=2,
                    CategoryName="Et,Tavuk,Balık",
                    ImageUrl="ettb.png"

                },
                  new Kategoriler()
                {
                    CategoryId=3,
                    CategoryName="Süt,Kahvaltılık",
                    ImageUrl="kahvaltilik_1.png"

                },
                   new Kategoriler()
                {
                    CategoryId=4,
                    CategoryName="Gıda,Şekerleme",
                    ImageUrl="sekerleme_1.png"

                },
                    new Kategoriler()
                {
                    CategoryId=5,
                    CategoryName="İçecekler",
                    ImageUrl="icecek.png"

                }

            };
        }

        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach (var kategori in Categories)
                {
                    await Client.Child("Categories").PostAsync(new Kategoriler()
                    {
                        CategoryId = kategori.CategoryId,
                        CategoryName = kategori.CategoryName,
                        ImageUrl = kategori.ImageUrl

                    });
                }
            }

            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
