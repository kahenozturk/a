using Firebase.Database;
using App2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Services
{
    class GetKategoriService
    {
        FirebaseClient client;
        public GetKategoriService()
        {
            client = new FirebaseClient("https://depoo-2560f-default-rtdb.firebaseio.com/");
        }

        public async Task<List<Kategoriler>> GetCategoriesAsync()
        {
            var categories = (await client.Child("Categories")
                .OnceAsync<Kategoriler>())
                .Select(c => new Kategoriler
                {
                    CategoryId = c.Object.CategoryId,
                    CategoryName = c.Object.CategoryName,
                    ImageUrl = c.Object.ImageUrl
                }).ToList();
            return categories;
        }
    }
}
