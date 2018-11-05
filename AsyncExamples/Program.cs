using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace AsyncExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Main().Wait();
            Program.Main2().Wait();
        }

        private static HttpClient Client = new HttpClient();
        public static async Task Main()
        {
            Console.WriteLine("Starting connections");
            for (int i = 0; i < 10; i++)
            {
                using (var client = new HttpClient())
                {
                    var result = await client.GetAsync("http://aspnetmonsters.com");
                    Console.WriteLine(result.StatusCode);
                }
            }
            Console.WriteLine("Connections done");
        }

        public static async Task Main2()
        {
            Console.WriteLine("Starting connections");
            for (int i = 0; i < 10; i++)
            {
                var result = await Client.GetAsync("http://aspnetmonsters.com");
                Console.WriteLine(result.StatusCode);
            }
            Console.WriteLine("Connections done");
            Console.ReadLine();
        }
    }
}
