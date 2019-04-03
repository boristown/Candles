using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candles
{
    class Indices : Markets
    {
        public Indices()
        {
            url_mainpage = @"https://www.investing.com/indices/major-indices";
        }
    }
}
