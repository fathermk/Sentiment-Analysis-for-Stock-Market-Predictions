using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

namespace Sentiment_Analysis_for_Stock_Market_Predictions.DataCollection
{
    internal class ApiFetcher
    {
        private readonly HttpClient httpClient;

        public ApiFetcher()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<string>> FetchTweets(string query)
        {
            var tweets = new List<String>();

            //not done
            var twitterApiURL = "" + Uri.EscapeDataString(query);
            var twitterBearerToken = Environment.GetEnvironmentVariable("AAAAAAAAAAAAAAAAAAAAAOtUvAEAAAAAQsdLMt8Hp77mnDu79arAjrTMIq0%3DvnaN133uVwDWBkm91COFLWCuUhZOfvHhvejN90xVsTnk1bgMdG");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", twitterBearerToken);

            var response = await httpClient.GetAsync(twitterApiURL);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(content);

                foreach (var tweet in json["data"])
                {
                    tweets.Add(tweet["text"].ToString());
                }
                 
            }
            else
            {
                Console.WriteLine("Error fetching tweets: " + response.ReasonPhrase);
            }
            return tweets;
        }
    }
}
