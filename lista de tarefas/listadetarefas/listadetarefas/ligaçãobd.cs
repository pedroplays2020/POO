using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace listadeutilizadores
{
    class ligaçãobd
    {
        private static string registutilizadores;
        private static string nome;

        public static async Task<string> Registutilizadores(string username, string password)
        {
            const string Url = "https://niobic-bets.000webhostapp.com/registutulizadores.php";
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

        internal static Task<string> alterartarefa(object id, string v)
        {
            throw new NotImplementedException();
        }

        public static async Task<string> loginutilizadores(string username, string password)
        {
            const string Url = "https://niobic-bets.000webhostapp.com/loginutilizadores.php";
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
            else { return " falha no login "; }
        }

        public async static Task<string> getutilizadores()
        {
            const string Url = "https://niobic-bets.000webhostapp.com/getutilizadores.php";
            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync(Url);

            return response;
        }

        internal static Task<string> adicionatarefas(object id, string v)
        {
            throw new NotImplementedException();
        }

        public static async Task<string> adicionatarefas(string id, string nome)
        {
            const string Url = "https://niobic-bets.000webhostapp.com/tarefas/registarefas.php";
            HttpClient httpClient = new HttpClient();

            var values = new List<KeyValuePair<string, string>>
            {

                new KeyValuePair<string, string>("nome", nome)
            };

            var content = new FormUrlEncodedContent(values);
            var response = httpClient.PostAsync(Url, content).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            else { return " falha ao adicionar tarefa"; }
        }




        public static async Task<string> alterartarefa(string id, string nome)
        {
            const string Url = "https://niobic-bets.000webhostapp.com/tarefas/alterartarefa.php";
            HttpClient httpClient = new HttpClient();

            var values = new List<KeyValuePair<string, string>>
            {

                new KeyValuePair<string, string>("nome", nome)
            };

            var content = new FormUrlEncodedContent(values);
            var response = httpClient.PostAsync(Url, content).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            else
            {
                return " falha ao alterar tarefa";
            }
        }

        public static async Task<string> Removertarefa(string id, string nome)
        {
            const string Url = "https://niobic-bets.000webhostapp.com/tarefas/deletetarefas.php";
            HttpClient httpClient = new HttpClient();

            var values = new List<KeyValuePair<string, string>>
            {

                new KeyValuePair<string, string>("nome", nome)
            };

            var content = new FormUrlEncodedContent(values);
            var response = httpClient.PostAsync(Url, content).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            else
            {
                return " falha ao remover tarefa";
            }
        }
    }
}
      





  




        

