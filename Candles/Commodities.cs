using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candles
{
    class Commodities : Markets
    {
        public Commodities()
        {
            url_mainpage = @"https://www.investing.com/commodities/real-time-futures";
        }
    }
}
