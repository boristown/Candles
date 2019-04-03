using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candles
{
    class Currencies : Markets
    {
        public Currencies()
        {
            url_mainpage = @"https://www.investing.com/currencies/streaming-forex-rates-majors";
        }
    }
}
