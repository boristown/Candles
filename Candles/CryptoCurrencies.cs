﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candles
{
    class CryptoCurrencies : Markets
    {
        public CryptoCurrencies()
        {
            url_mainpage = @"https://www.investing.com/crypto/currencies";
        }
    }
}
