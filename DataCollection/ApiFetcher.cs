using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V125.Network;

namespace Sentiment_Analysis_for_Stock_Market_Predictions.DataCollection
{

    internal class ApiFetcher
    {
        private readonly HttpClient httpClient;
        private readonly string accessToken;

        //Using Facebook Graph API to get posts related to stock market

        public ApiFetcher()
        {
            httpClient = new HttpClient();
            accessToken = accessToken
        }

        public async Task<List<string>> ThreadFetcher(string query)
        {

        }