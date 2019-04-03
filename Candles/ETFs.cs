using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candles
{
    class ETFs : Markets
    {
        public ETFs()
        {
            url_mainpage = @"https://www.investing.com/etfs/major-etfs";
        }
    }
}
