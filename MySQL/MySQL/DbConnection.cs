using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MySQL
{
    class DbConnection
    {
        public static async Task<string> RegisterUser(string username, string password)
        {
            const string Url = "https://myistec.000webhostapp.com/php/registerUser.php";
            HttpClient httpClient = new HttpClient();

            var values = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            };

            var content = new FormUrlEncodedContent(values);
            var response = httpClient.PostAsync(Url, content).Result;

            if(response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            else { return "Comunication Error"; }
        }

        public static async Task<string> LoginUser(string username, string password)
        {
            const string Url = "https://myistec.000webhostapp.com/php/loginUser.php";
            HttpClient httpClient = new HttpClient();

            var values = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            };

            var content = new FormUrlEncodedContent(values);
            var response = httpClient.PostAsync(Url, content).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            else { return "Comunication Error"; }
        }

        public async static Task<string> GetUsers()
        {
            const string Url = "https://myistec.000webhostapp.com/php/getUsers.php";
            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync(Url);
            return response;
        }
    }
}
