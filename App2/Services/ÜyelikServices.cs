using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using App2.Models;

namespace App2.Services
{
    public class ÜyelikServices
    {
        readonly FirebaseClient Client;

        public ÜyelikServices()
        {
            Client = new FirebaseClient("https://depoo-2560f-default-rtdb.firebaseio.com/");
        }

        public async Task<bool> IsUserExist(string userPhone)
        {
            var user = (await Client.Child("Users")
                .OnceAsync<Üyelik>())
                .Where(u => u.Object.TelefonNo == userPhone).FirstOrDefault();

            return user != null;

        }

        public async Task<bool> RegisterUser(string UserPhone, string UserMail)
        {
            if (await IsUserExist(UserPhone) == false)
            {
                await Client.Child("Users")
                    .PostAsync(new Üyelik()
                    {
                        TelefonNo = UserPhone,
                        Mail = UserMail
                    });

                return true;
            }

            else
                return false;
        }


        public async Task<bool> LoginUser(string userPhone)
        {
            var user = (await Client.Child("Users")
                .OnceAsync<Üyelik>())
                .Where(u => u.Object.TelefonNo == userPhone).FirstOrDefault();

            return user != null;

        }
    }
}
