using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KayneWestConversation
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine($"Kayne: 'Yo, Ron.'");

            Console.WriteLine($"-------------");

            Console.WriteLine($"Ron: 'Good Day, Mr. Kayne.'");


            for (int i = 0; i < 5; i++)
            {
                KayneQuote.KayneGenQuote();

                RonQuote.RonGenQuote();
            }

            Console.WriteLine($"-------------");

            Console.WriteLine($"Kayne: 'Right. Sounds good, I'm the best, OUT!'");

            Console.WriteLine($"-------------");

            Console.WriteLine($"Ron: 'It's been great. Have one for me. Good Day.'");


            //var kanyeURL = "https://api.kanye.rest";

            //var kanyeClient = new HttpClient();

            //var kanyeResponse = kanyeClient.GetStringAsync(kanyeURL).Result;

            //var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            //Console.WriteLine(kanyeQuote);




            //KayneQuote.KayneGenQuote();

            //RonQuote.RonGenQuote();




            //var ronClient = new HttpClient();

            //var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            //var ronResponse = ronClient.GetStringAsync(ronURL).Result;

            //var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();



        }



    }
}
