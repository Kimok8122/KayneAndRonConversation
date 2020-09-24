using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KayneWestConversation
{
    public class KayneQuote
    {
        public static void KayneGenQuote()
        {
            var kanyeURL = "https://api.kanye.rest";

            var kanyeClient = new HttpClient();

            var kanyeResponse = kanyeClient.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();


            Console.WriteLine($"-------------");
            Console.WriteLine($"Kayne: '{kanyeQuote}'");
        }
    }
}
