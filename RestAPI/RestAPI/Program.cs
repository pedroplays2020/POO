using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
    class Program
    {
        const string Url = "https://jsonplaceholder.typicode.com/posts";
        static void Main(string[] args)
        {
            GetPosts();
            Console.Read();
        }

        static async void GetPosts()
        {
            HttpClient httpClient = new HttpClient();
            List<Post> posts;
            var content = await httpClient.GetStringAsync(Url);
            //Console.WriteLine(content);

            posts = JsonConvert.DeserializeObject<List<Post>>(content);
            int Count = 0;
            foreach(Post post in posts)
            {
                Count++;
                Console.WriteLine(post.title);
            }

            Console.WriteLine("Count {0}", Count);
        }
    }
}
