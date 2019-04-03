using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        static void Main(string[] args)
        {
            Console.Title = "Candles";
            foreach (var market in marketDict)
            {
                Console.WriteLine(market.Key + ":" + market.Value);
            }
            foreach (var continent in Countries.continents)
            {
                Console.WriteLine(continent.Key+" Marktes:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine(Markets.url_markets + country);
                }
            }
            Console.ReadLine();
        }
    }
}
