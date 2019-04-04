using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candles
{
    class Program
    {
        /// <summary>
        /// Markets Dictionary
        /// </summary>
        static Dictionary<string, Markets> marketDict = new Dictionary<string, Markets>()
        {
            { "Indices", new Indices() },
            { "Stocks", new Stocks() },
            { "ETFs", new ETFs() },
            { "Commodities", new Commodities() },
            { "Currencies", new Currencies() },
            { "CryptoCurrencies", new CryptoCurrencies() },
        };

        [STAThread]
        static void Main(string[] args)
        {
            Console.Title = "Candles";
            foreach (var market in marketDict)
            {
                //string webSource = WebHelper.GetHttpWebRequest(market.Value.ToString());
                if (market.Value is CryptoCurrencies)
                {
                    Console.WriteLine(market.Key + ":" + market.Value);
                    WebPage webInfo = new WebPage(market.Value.ToString());
                    //Console.WriteLine(webSource.Substring(0,1000));
                    foreach (Link link in webInfo.Links)
                    {
                        Console.WriteLine(link.Text + "[" + link.NavigateUrl + "]");
                    }
                }
            }
            foreach (var continent in Countries.continents)
            {
                //Console.WriteLine(continent.Key+" Marktes:");
                foreach (var country in continent.Value)
                {
                    //Console.WriteLine(Markets.url_markets + country);
                }
            }
            Console.ReadLine();
        }
    }
}
