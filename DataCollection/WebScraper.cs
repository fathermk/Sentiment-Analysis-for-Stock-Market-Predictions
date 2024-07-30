using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Sentiment_Analysis_for_Stock_Market_Predictions.DataCollection
{
    internal class WebScraper
    {
        public List<string> ScrapeNewsArticles(string url)
        {
            // Load articles from URL
            var articles = new List<string>();
            var web = new HtmlWeb(); 
            var doc = web.Load()
                //not done
            var articleNodes = doc.DocumentNode.SelectNodes("...")

            foreach(var node in articleNodes)
            {
                var titleNode = node.SelectSingleNode(".//h2");
                var summaryNode = node.SelectSingleNode(".//p");

                if (titleNode != null && summaryNode != null)
                {
                    var title = titleNode.InnerText;
                    var summary = summaryNode.InnerText;
                    articles.Add($"{title} {summary}");
                }    
            }
            return articles;

        }

        //Method to scrape multiple sites

        public List<string> ScrapeMultipleSites()
        {
            var multipleArticles = new List<string>();
            var urls = new List<string>
            {
                "https://finance.yahoo.com/",
                "https://www.cnbc.com/",
                "https://seekingalpha.com/",
                "https://www.nytimes.com/",
                "https://www.marketwatch.com/"
            };

            foreach (var url in urls)
            {
                var articles = ScrapeNewsArticles(url);
                multipleArticles.AddRange(articles);
            }
            return multipleArticles;
        }
    }
}
