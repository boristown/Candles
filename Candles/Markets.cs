﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candles
{
    class Markets
    {
        /// <summary>
        /// Url of main page
        /// </summary>
        public string url_mainpage;

        /// <summary>
        /// Url of markets
        /// </summary>
        public static string url_markets = @"https://www.investing.com/markets/";

        /// <summary>
        /// Override Tostring()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return url_mainpage;
        }
    }
}
