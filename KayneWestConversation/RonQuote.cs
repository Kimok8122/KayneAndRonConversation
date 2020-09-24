using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KayneWestConversation
{
    public class RonQuote
    {
        public static void RonGenQuote()
        {
            var ronClient = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = ronClient.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"-------------");
            Console.WriteLine($"Ron: {ronQuote}");

        }
    }
}
