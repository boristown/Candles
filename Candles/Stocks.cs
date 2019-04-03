using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candles
{
    class Stocks : Markets
    {
        public Stocks()
        {
            url_mainpage = @"https://www.investing.com/equities/";
        }
    }
}
