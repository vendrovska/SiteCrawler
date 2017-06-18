using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SiteCrawler
{
    class CrawlerMain
    {
        static void Main(string[] args)
        {
            CrawlerMain c = new CrawlerMain();
            c.getCall();

        }
         public void getCall()
        {
            Task t =  httpGetUrl();
            t.Wait(); 
        }

        async private Task httpGetUrl()
        {
            HttpClient client = new HttpClient();
            var responseString = await client.GetStringAsync("https://www.testingmom.com");
            Console.Write("hi");
        }
    }
}
