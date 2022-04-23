using Firebase.Database;
using Firebase.Database.Query;
using App2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2.Services
{
    public class AddProductsService
    {
        FirebaseClient Client;
        public List<Product> AppProducts { get; set; }

        public AddProductsService()
        {
            Client = new FirebaseClient("https://depoo-2560f-default-rtdb.firebaseio.com/");
            AppProducts = new List<Product>()
            {//1.1=Meyve , 1.2=Sebze , 2.1= Et , 2.2=Balık , 2.3=Tavuk , 3.1=Süt , 3.2=Kahvaltılık
             //4.1=Goda , 4.2=Sekerleme , 5i sonra düşünmemiz lazım.
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="meyvesebze.png",
                    ProductNamee="Maydanoz Adet",
                    Türü=1.2,
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=1.75,

                },
                new Product
                {
                    ProductId=2,
                    CategoryId=1,
                    ImageUrll="sogan.png",
                    ProductNamee="Soğan Kuru Dökme Kg",
                    Türü=1.2,
                    Rating="4.1",
                    HomeSelected="CompleteHeart",
                    Price=1.59,

                },
                new Product
                {
                    ProductId=3,
                    CategoryId=1,
                    ImageUrll="domates_1.png",
                    ProductNamee="Domates Kokteyl",
                    Türü=1.2,
                    Rating="4.3",
                    HomeSelected="EmptyHeart",
                    Price=8.95,

                },
                new Product
                {
                    ProductId=4,
                    CategoryId=1,
                    ImageUrll="Muz.png",
                    ProductNamee="Muz Yerli Kg",
                    Türü=1.1,
                    Rating="4.4",
                    HomeSelected="CompleteHeart",
                    Price=12.99,

                },
                new Product
                {
                    ProductId=5,
                    CategoryId=1,
                    ImageUrll="Limon.png",
                    ProductNamee="Limon",
                    Türü=1.1,
                    Rating="4.6",
                    HomeSelected="CompleteHeart",
                    Price=7.99,

                },
                new Product
                {
                    ProductId=6,
                    CategoryId=1,
                    ImageUrll="avakado.png",
                    ProductNamee="Avakado Adet",
                    Türü = 1.1,
                    Rating="4",
                    HomeSelected="EmptyHeart",
                    Price=5.95,

                },
                new Product
                {
                    ProductId=7,
                    CategoryId=2,
                    ImageUrll="danakiymalik.png",
                    ProductNamee="Dana Kıymalık Kg",
                    Türü=2.1,
                    Rating="4.8",
                    HomeSelected="CompleteHeart",
                    Price=49.90,

                },
                new Product
                {
                    ProductId=8,
                    CategoryId=2,
                    ImageUrll="UzmanKasapDanaKiyma.png",
                    ProductNamee="Uzman Kasap Dana Kıyma Paket 500 G ",
                    Rating="4.3",
                    Türü=2.1,
                    HomeSelected="CompleteHeart",
                    Price=22.35,

                },
                new Product
                {
                    ProductId=9,
                    CategoryId=2,
                    ImageUrll="NorvecSomon.png",
                    ProductNamee="Norveç Somon Fileto Kg",
                    Türü=2.2,
                    Rating="4.5",
                    HomeSelected="CompleteHeart",
                    Price=149.90,

                },
                new Product
                {
                    ProductId=10,
                    CategoryId=2,
                    ImageUrll="BanvitPilicKal.png",
                    ProductNamee="Banvit Kılıç Kalçalı But Kg",
                    Türü=2.3,
                    Rating="4.65",
                    HomeSelected="CompleteHeart",
                    Price=20.90,

                }
               /* new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,

                },
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,

                },
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,

                },
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,

                },
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,

                },
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,

                },
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,

                },
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,

                },
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,

                },
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,
                    
                },
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,

                },
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,

                },
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,

                },
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ImageUrll="",
                    ProductNamee="",
                    Rating="4",
                    HomeSelected="CompleteHeart",
                    Price=2.10,

                }*/
                                       

            };

        }

        public async Task AddProductItemAsync()
        {
            try
            {
                foreach (var item in AppProducts)
                {
                    await Client.Child("Products").PostAsync(new Product()
                    {
                        CategoryId = item.CategoryId,
                        ProductId = item.ProductId,
                        ProductNamee = item.ProductNamee,
                        HomeSelected = item.HomeSelected,
                        Rating = item.Rating,
                        ImageUrll = item.ImageUrll,
                        Price = item.Price,
                        Türü = item.Türü
                    });
                }

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("ERROR", ex.Message, "OK");

            }
        }

    }
}
