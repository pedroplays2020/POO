using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUsers();
            Console.Read();
        }

        static async void Login()
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            Task<string> resultTask = DbConnection.LoginUser(username, Hash.sha256_hash(password));
            string result = await resultTask;

            Console.WriteLine(result);
            Console.Read();
        }

        static async void Register()
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            Task<string> resultTask = DbConnection.RegisterUser(username, Hash.sha256_hash(password));
            string result = await resultTask;

            Console.WriteLine(result);
            Console.Read();
        }

        static async void GetUsers()
        {
            Task<string> resultTask = DbConnection.GetUsers();
            string result = await resultTask;

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
